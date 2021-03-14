using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    using ChatCommoms;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.textBoxIp.Text = "192.168.1.101";//先初始化一个默认的ip等
            this.textBoxPort.Text = "50000";
        }

        Socket clientSocket;
        /// <summary>
        /// 客服端连接到服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServicStart_Click(object sender, EventArgs e)
        {
            try
            {
                var ipstr = textBoxIp.Text.Trim();
                var portstr = textBoxPort.Text.Trim();
                if (string.IsNullOrWhiteSpace(ipstr) || string.IsNullOrWhiteSpace(portstr))
                {
                    MessageBox.Show("要连接的服务器ip和端口都不可以为空！");
                    return;
                }
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(IPAddress.Parse(ipstr), int.Parse(portstr));
                labelStatus.Text = "连接到服务器成功...!";
                ReseviceMsg(clientSocket);

            }
            catch (Exception)
            {
                MessageBox.Show("请检查要连接的服务器的参数");
            }
        }
        private void ReseviceMsg(Socket clientSocket)
        {

            Thread thread = new Thread(() =>
             {
                 while (true)
                 {
                     try
                     {
                         Byte[] byteContainer = new Byte[1024 * 1024 * 4];
                         int getlength = clientSocket.Receive(byteContainer);
                         if (getlength <= 0)
                         {
                             break;
                         }
                         var getType = byteContainer[0].ToString();
                         string getmsg = Encoding.UTF8.GetString(byteContainer, 1, getlength - 1);

                         GetMsgFomServer(getType, getmsg);
                     }
                     catch (Exception ex)
                     {
                     }
                 }
             });
            thread.IsBackground = true;
            thread.Start();

        }

        private void GetMsgFomServer(string strType, string msg)
        {
            this.textboMsg.AppendText($"\r\n类型：{strType};{msg}");
        }

        /// <summary>
        /// 文字消息的发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            var msg = textBoxSendMsg.Text.Trim();
            var sendMsg = ServiceSockertHelper.GetSendMsgByte(msg, ChatModels.ChatTypeInfoEnum.StringEnum);
            int sendMsgLength = clientSocket.Send(sendMsg);
        }
    }
}
