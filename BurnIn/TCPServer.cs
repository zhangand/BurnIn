using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;  // IP，IPAddress, IPEndPoint，端口等；
using System.Threading;
using System.IO;

namespace BurnIn
{
    public partial class frm_server : Form
    {
        public frm_server()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        Thread threadWatch = null; // monitor client request thread；
        Socket socketWatch = null;
        Boolean bIsExecute = true;

        private const int SendBufferSize = 1024 * 1024;
        private const int ReceiveBufferSize = 2048 * 1024;
        private string strClientAddress = string.Empty;
        

        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();

        // Control Action Method
        private void btnBeginListen_Click(object sender, EventArgs e)// setup server listening
        {
            btnBeginListen.Enabled = false;
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);// 创建负责监听的套接字，注意其中的参数；
            IPAddress address = IPAddress.Parse(txtIp.Text.Trim());// 获得文本框中的IP对象；
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));// 创建包含ip和端口号的网络节点对象；
            try
            {
                socketWatch.Bind(endPoint); // 将负责监听的套接字绑定到唯一的ip和端口上；
            }
            catch (SocketException se)
            {
                MessageBox.Show("Error：" + se.Message);
                return;
            }
            socketWatch.Listen(10);// 设置监听队列的长度；
            threadWatch = new Thread(WatchConnecting);// 创建负责监听的线程；
            threadWatch.IsBackground = true;
            threadWatch.Start();
            ShowMsg("Server Start Listening Successfully!");
        }
        private void btnSend_Click(object sender, EventArgs e)//send message
        {
            strClientAddress = lbOnline.Text.Trim();
            ClientSendMsg(txtMsgSend.Text.Trim(),0);
            txtMsgSend.Clear();
        }
        private void btnSendFile_Click(object sender, EventArgs e)//send file
        {
            strClientAddress = lbOnline.Text.Trim();
            //0. check the client selected
            if (string.IsNullOrEmpty(strClientAddress))   // 判断是不是选择了发送的对象；
            {
                MessageBox.Show("Please Select Client Address!");
                return;
            }

            //1.select file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT File(*.txt)|*.txt|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSelectFile.Text = ofd.FileName;//send the filename to global Variable
            }
            else return;

            //2. check file exist
            if (string.IsNullOrEmpty(txtSelectFile.Text))//check file selected
            {
                MessageBox.Show("Please Select File!");
            }
            else
            {
                //3. send file name and length
                long fileLength = new FileInfo(txtSelectFile.Text).Length;
                string totalMsg = string.Format("{0}-{1}", txtSelectFile.Text, fileLength);
                ClientSendMsg(totalMsg, 2);

                //4. send file
                byte[] buffer = new byte[SendBufferSize];

                using (FileStream fs = new FileStream(txtSelectFile.Text, FileMode.Open, FileAccess.Read))
                {
                    int readLength = 0;
                    bool firstRead = true;
                    long sentFileLength = 0;
                    while ((readLength = fs.Read(buffer, 0, buffer.Length)) > 0 && sentFileLength < fileLength)
                    {
                        sentFileLength += readLength;
                        
                        if (firstRead)//在第一次发送的字节流上加个前缀1
                        {
                            byte[] firstBuffer = new byte[readLength + 1];
                            firstBuffer[0] = 1; //告诉机器该发送的字节数组为文件
                            Buffer.BlockCopy(buffer, 0, firstBuffer, 1, readLength);
                            dict[strClientAddress].Send(firstBuffer, 0, readLength + 1, SocketFlags.None);
                            firstRead = false;
                            continue;
                        }
                        //之后发送的均为直接读取的字节流
                        dict[strClientAddress].Send(buffer, 0, readLength, SocketFlags.None);
                    }
                    fs.Close();
                }
                txtMsg.AppendText(GetCurrentTime() + " send: " + txtSelectFile.Text + "\r\n");
            }
        }
        private void frm_server_FormClosed(object sender, FormClosedEventArgs e)//close form, close TCP
        {
            bIsExecute = false; //此处拆除循环条件
            if (socketWatch!=null)
            {
                socketWatch.Close();
            }
        }

        //user define method
        private void WatchConnecting()// monitor client connection request
        {

            while (bIsExecute)  // 持续不断的监听客户端的连接请求；
            {
                // 开始监听客户端连接请求，Accept方法会阻断当前的线程；
                try
                {
                    Socket sokConnection = socketWatch.Accept(); // 一旦监听到一个客户端的请求，就返回一个与该客户端通信的 套接字；
                    lbOnline.Items.Add(sokConnection.RemoteEndPoint.ToString());// 想列表控件中添加客户端的IP信息；
                    lbOnline.SetSelected(lbOnline.Items.Count - 1, true);
                    dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);// 将与客户端连接的 套接字 对象添加到集合中；
                    ShowMsg("Client " + sokConnection.RemoteEndPoint.ToString() + " Connected!");
                    Thread thr = new Thread(RecMsg);
                    thr.IsBackground = true;
                    thr.Start(sokConnection);
                    dictThread.Add(sokConnection.RemoteEndPoint.ToString(), thr);  //  将新建的线程 添加 到线程的集合中去。
                }
                catch (Exception)
                {

                    break;
                }
                
            }

        }
        private void RecMsg(object socketClientPara)//process receive message
        {
            Socket socketServer = socketClientPara as Socket;
            string strSRecMsg = null;

            long fileLength = 0;
            while (true)
            {
                int firstReceived = 0;
                byte[] buffer = new byte[ReceiveBufferSize];
                try
                {
                    //获取接收的数据,并存入内存缓冲区  返回一个字节数组的长度
                    if (socketServer != null) firstReceived = socketServer.Receive(buffer);

                    if (firstReceived > 0) //接受到的长度大于0 说明有信息或文件传来
                    {
                        if (buffer[0] == 0) //0为文字信息
                        {
                            strSRecMsg = System.Text.Encoding.UTF8.GetString(buffer, 1, firstReceived - 1);//真实有用的文本信息要比接收到的少1(标识符)
                            ShowMsg(strSRecMsg, 2);
                        }
                        if (buffer[0] == 2)//2为文件名字和长度
                        {
                            string fileNameWithLength = System.Text.Encoding.UTF8.GetString(buffer, 1, firstReceived - 1);
                            strSRecMsg = fileNameWithLength.Split('-')[0]; //文件名
                            fileLength = Convert.ToInt64(fileNameWithLength.Split('-')[1]);//文件长度
                        }
                        if (buffer[0] == 1)//1为文件
                        {

                            SaveFileDialog sfDialog = new SaveFileDialog();
                            sfDialog.Filter = "TXT File(*.txt)|*.txt|All Files(*.*)|*.*"; //文件类型

                            if (sfDialog.ShowDialog(this) == DialogResult.OK) //如果点击了对话框中的保存文件按钮 
                            {
                                string savePath = sfDialog.FileName; //获取文件的全路径
                                int received = 0;//保存文件
                                long receivedTotalFilelength = 0;
                                bool firstWrite = true;
                                using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                    while (receivedTotalFilelength < fileLength) //之后收到的文件字节数组
                                    {
                                        if (firstWrite)
                                        {
                                            fs.Write(buffer, 1, firstReceived - 1); //第一次收到的文件字节数组 需要移除标识符1 后写入文件
                                            fs.Flush();

                                            receivedTotalFilelength += firstReceived - 1;

                                            firstWrite = false;
                                            continue;
                                        }
                                        received = socketServer.Receive(buffer); //之后每次收到的文件字节数组 可以直接写入文件
                                        fs.Write(buffer, 0, received);
                                        fs.Flush();

                                        receivedTotalFilelength += received;
                                    }
                                    fs.Close();
                                }

                                string fName = System.IO.Path.GetFileName(savePath); //文件名 不带路径
                                string fPath = System.IO.Path.GetDirectoryName(savePath); //文件路径 不带文件名
                                ShowMsg("Success Receive " + fName + "\r\nSave Path is :" + fPath + "\r\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowMsg("Error:" + ex.Message);
                    break;
                }
            }
        }
        private void ShowMsg(string str, int MessageTypeFlag =3)//show message in text box
        {
            if (MessageTypeFlag == 1)//1 send
            {
                txtMsg.AppendText(GetCurrentTime() + " Send : " + str + "\r\n");
            }
            else if (MessageTypeFlag == 2)//2 Receive
            {
                txtMsg.AppendText(GetCurrentTime() + " Receive : " + str + "\r\n");
            } 
            else txtMsg.AppendText(GetCurrentTime() + " : " +  str + "\r\n");
        }
        private void ClientSendMsg(string sendMsg, byte symbol)// send message and show
        {

            if (string.IsNullOrEmpty(strClientAddress))   // 判断是不是选择了发送的对象；
            {
                MessageBox.Show("Please Select Client Address!");
                return;
            }
            else
            {
                byte[] arrClientMsg = System.Text.Encoding.UTF8.GetBytes(sendMsg);
                //实际发送的字节数组比实际输入的长度多1 用于存取标识符
                byte[] arrClientSendMsg = new byte[arrClientMsg.Length + 1];
                arrClientSendMsg[0] = symbol;  //在索引为0的位置上添加一个标识符
                Buffer.BlockCopy(arrClientMsg, 0, arrClientSendMsg, 1, arrClientMsg.Length);
                dict[strClientAddress].Send(arrClientSendMsg);
                ShowMsg(sendMsg,1);
            }
        }
        private DateTime GetCurrentTime()// Get Current System Time
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
