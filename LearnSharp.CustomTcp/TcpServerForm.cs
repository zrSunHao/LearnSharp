using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LearnSharp.CustomTcp
{
    public partial class TcpServerForm : Form
    {
        #region 变量

        //声明变量
        private const int portNum = 51338;
        private TcpListener tcpListener = null;
        private TcpClient tcpClient = null;
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


        public TcpServerForm()
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

            ReceivelistBox.Items.Clear();
        }

        private void TcpServerForm_Load(object sender, EventArgs e)
        {

        }

        #region 定义回调函数

        private void showMessage(string str)
        {
            ReceivelistBox.Items.Add(str);
            ReceivelistBox.TopIndex = ReceivelistBox.Items.Count - 1;
        }

        private void resetMessage()
        {
            sendText.Text = string.Empty;
            sendText.Focus();
        }

        #endregion

        //开始监听
        private void startListenBtn_Click(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(ipAddress, portNum);
            tcpListener.Start();
            //启动一个线程来接收请求
            Thread acceptThread = new Thread(AcceptClientConnect);
        }

        //接收请求
        private void AcceptClientConnect()
        {
            try
            {
                ReceivelistBox.Invoke(showMessageCallback, "等待连接");
                tcpClient = tcpListener.AcceptTcpClient();
                if (tcpListener != null)
                {
                    ReceivelistBox.Invoke(showMessageCallback, "接收到连接");
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                }
            }
            catch (Exception ex)
            {
                ReceivelistBox.Invoke(showMessageCallback, "停止监听");
            }
        }

        //结束监听
        private void endListenBtn_Click(object sender, EventArgs e)
        {
           tcpListener.Stop();
        }

        //清空消息
        private void clearMsgBtn_Click(object sender, EventArgs e)
        {
            ReceivelistBox.Items.Clear();
        }

        //接收请求
        private void receiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string receiveMsg = reader.ReadString();
                ReceivelistBox.Invoke(showMessageCallback, receiveMsg);
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();

                if (writer != null) writer.Close();

                if(tcpClient != null) tcpClient.Close();

                //重新开启一个线程
                Thread accepThread = new Thread(AcceptClientConnect);
                accepThread.Start();
            }
        }

        //断开连接
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (reader != null) reader.Close();

            if (writer != null) writer.Close();

            if (tcpClient != null) tcpClient.Close();

            //重新开启一个线程
            Thread accepThread = new Thread(AcceptClientConnect);
            accepThread.Start();
        }

        //发送消息
        private void sendBtn_Click(object sender, EventArgs e)
        {
            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(sendText.Text);
        }
        
        //发送消息
        private void SendMessage(object state)
        {
            ReceivelistBox.Invoke(showMessageCallback, "正在发送");
            try
            {
                writer.Write(state.ToString());
                Thread.Sleep(100);
                writer.Flush();
                ReceivelistBox.Invoke(showMessageCallback, "发送完毕");
                sendText.Invoke(resetMessageCallback, null);
                ReceivelistBox.Invoke(showMessageCallback, state.ToString());
            }
            catch (Exception e)
            {
                if (reader != null) reader.Close();

                if (writer != null) writer.Close();

                if (tcpClient != null) tcpClient.Close();

                //重新开启一个线程
                Thread accepThread = new Thread(AcceptClientConnect);
                accepThread.Start();
            }
        }



    }
}
