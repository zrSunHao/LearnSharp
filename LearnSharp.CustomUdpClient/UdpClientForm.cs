using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LearnSharp.CustomUdpClient
{
    public partial class UdpClientForm : Form
    {
        private UdpClient sendUdpClient;
        private UdpClient receiveUdpClient;

        public UdpClientForm()
        {
            InitializeComponent();
            IPAddress[] ips = Dns.GetHostAddresses("");
            foreach (var ip in ips)
            {
                if (ip.ToString().Contains("192"))
                {
                    localIpText.Text = ip.ToString();
                    sendIpText.Text = ip.ToString();
                    break;
                }
            }

            int portNum = 51883;
            int sendPortNum = 11883;
            localPortText.Text = portNum.ToString();
            sendPortText.Text = sendPortNum.ToString();
        }

        private void UdpClientView_Load(object sender, EventArgs e)
        {

        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            //创建接收套接字
            IPAddress localIp = IPAddress.Parse(localIpText.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp,int.Parse(localPortText.Text));

            try
            {
                receiveUdpClient = new UdpClient(localIpEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }

        private void ReceiveMessage()
        {
            if (receiveUdpClient == null) return;

            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    //关闭receiveUdpClient时会产生异常
                    byte[] receiveBytes = receiveUdpClient.Receive(ref remoteIpEndPoint);
                    string message = Encoding.Unicode.GetString(receiveBytes);

                    //显示消息内容
                    ShowMessageForView(msgListView,string.Format("{0}{1}",remoteIpEndPoint,message));
                }
                catch (Exception e)
                {
                    break;
                }
            }
        }

        delegate void ShowMessageForViewCallBack(ListBox listbox,string text);

        private void ShowMessageForView(ListBox listbox, string text)
        {
            if (listbox.InvokeRequired)
            {
                ShowMessageForViewCallBack showMessageForViewCallBack = ShowMessageForView;
                listbox.Invoke(showMessageForViewCallBack, new object[] {listbox, text});
            }
            else
            {
                msgListView.Items.Add(text);
                msgListView.SelectedIndex = msgListView.Items.Count - 1;
                msgListView.ClearSelected();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.msgListView.Items.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contentText.Text))
            {
                MessageBox.Show("发送内容不能为空","提示");
                return;
            }
            IPAddress localIp = IPAddress.Parse(localIpText.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp,int.Parse(localPortText.Text));
            sendUdpClient = new UdpClient(localIpEndPoint);

            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(contentText.Text);
        }

        private void SendMessage(object obj)
        {
            string message = (string) obj;
            byte[] sendBytes = Encoding.Unicode.GetBytes(message);
            IPAddress remoteIp = IPAddress.Parse(sendIpText.Text);
            IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp,int.Parse(sendPortText.Text));
            sendUdpClient.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);

            sendUdpClient.Close();

        }

        delegate void ResetMessageCallback(TextBox textBox);

        private void ResetMessageText(TextBox textBox)
        {
            //如果处理空间与调用线程是在不同线程上创建的，取值为true，否则为false
            if (textBox.InvokeRequired)
            {
                ResetMessageCallback resetMessageCallback = ResetMessageText;
                textBox.Invoke(resetMessageCallback,new object[] {textBox});
            }
            else
            {
                textBox.Clear();
                textBox.Focus();
            }
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            receiveUdpClient.Close();
        }

        
    }
}
