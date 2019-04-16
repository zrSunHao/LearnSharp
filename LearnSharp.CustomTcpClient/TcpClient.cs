using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace LearnSharp.CustomTcpClient
{
    public partial class TcpClient : Form
    {
        #region 变量

        //声明变量
        private const int portNum = 51338;
        private TcpListener tcpListener = null;
        private System.Net.Sockets.TcpClient myTcpClient = null;
        private IPAddress ipAddress;
        private NetworkStream networkStream = null;
        private BinaryReader reader;
        private BinaryWriter writer;

        //声明委托
        //显示消息
        private delegate void ShowMessage(string str);
        private ShowMessage showMessageCallback;
        //清空消息
        private delegate void ResetMessage();
        private ResetMessage resetMessageCallback;

        #endregion

        public TcpClient()
        {
            InitializeComponent();

            # region 实例化委托
            //显示消息
            showMessageCallback = new ShowMessage(showMessage);
            //重置消息
            resetMessageCallback = new ResetMessage(resetMessage);

            #endregion

            ipAddress = IPAddress.Loopback;

            //IP地址
            ipText.Text = ipAddress.ToString();
            //端口号
            portText.Text = portNum.ToString();

            receivelistBox.Items.Clear();
        }

        private void TcpClient_Load(object sender, EventArgs e)
        {

        }

        #region 定义回调函数

        private void showMessage(string str)
        {
            receivelistBox.Items.Add(str);
            receivelistBox.TopIndex = receivelistBox.Items.Count - 1;
        }

        private void resetMessage()
        {
            sendText.Text = string.Empty;
            sendText.Focus();
        }


        #endregion

        private void startListenBtn_Click(object sender, EventArgs e)
        {
            //通过一个线程发起请求，多线程
            Thread connectThread = new Thread(ConnectToServer);
            connectThread.Start();
        }

        private void ConnectToServer()
        {
            //通过一个线程发起请求，建立连接的过程
            try
            {
                if (string.IsNullOrEmpty(ipText.Text) || string.IsNullOrEmpty(portText.Text))
                {
                    MessageBox.Show("请先输入服务器的地址和端口号");
                }

                IPAddress ipAddress = IPAddress.Parse(ipText.Text);
                myTcpClient = new System.Net.Sockets.TcpClient();
                myTcpClient.Connect(ipAddress,int.Parse(portText.Text));

                //延时操做
                Thread.Sleep(1000);
                if (myTcpClient != null)
                {
                    MessageBox.Show("连接成功");
                    networkStream = myTcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败，请重试！");
            }
        }

        private void clearMsgBtn_Click(object sender, EventArgs e)
        {
            receivelistBox.Items.Clear();
        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            Thread receiveThread = new Thread(receiveMessage);
            receiveThread.Start();
        }

        private void receiveMessage()
        {
            try
            {
                string receiveMsg = reader.ReadString();
                receivelistBox.Invoke(showMessageCallback, receiveMsg);
            }
            catch (Exception e)
            {
                if (reader != null) reader.Close();

                if (writer != null) writer.Close();

                if (myTcpClient != null) myTcpClient.Close();
            }
        }

        private void disConnectBtn_Click(object sender, EventArgs e)
        {
            if (reader != null) reader.Close();

            if (writer != null) writer.Close();

            if (myTcpClient != null) myTcpClient.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Thread receiveThread = new Thread(SendMessage);
            receiveThread.Start(sendText.Text);
        }

        //发送消息
        private void SendMessage(object state)
        {
            receivelistBox.Invoke(showMessageCallback, "正在发送");
            try
            {
                writer.Write(state.ToString());
                Thread.Sleep(100);
                writer.Flush();
                
                sendText.Invoke(resetMessageCallback, null);
                receivelistBox.Invoke(showMessageCallback, state.ToString());
            }
            catch (Exception e)
            {
                if (reader != null) reader.Close();

                if (writer != null) writer.Close();

                if (myTcpClient != null) myTcpClient.Close();
            }
        }
    }
}
