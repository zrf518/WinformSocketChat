using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartService
{
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using ChatCommoms;
    using ChatModels;

    public partial class ServiceForm : Form
    {
        Socket _socket;
        private static List<ChatUserInfo> userinfo = new List<ChatUserInfo>();
        public ServiceForm()
        {
            InitializeComponent();

        }

        private void btnServicStart_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox_ip.Text.Trim();
                string port = textBox_port.Text.Trim();
                if (string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(port))
                {
                    MessageBox.Show("IP与端口不可以为空!");
                }
                ServiceStartAccept(ip, int.Parse(port));
            }
            catch (Exception)
            {
                MessageBox.Show("连接失败！或者ip,端口参数异常");
            }
        }
        public void ServiceStartAccept(string ip, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endport = new IPEndPoint(IPAddress.Parse(ip), port);
            socket.Bind(endport);
            socket.Listen(10);
            Thread thread = new Thread(Recevice);
            thread.IsBackground = true;
            thread.Start(socket);
            textboMsg.AppendText("服务开启ok...");
        }

        /// <summary>
        /// 开启接听服务
        /// </summary>
        /// <param name="obj"></param>
        private void Recevice(object obj)
        {
            try
            {
                var socket = obj as Socket;
                while (true)
                {
                    Socket txSocket = socket.Accept();
                    _socket = txSocket;
                    if (txSocket.Connected)
                    {
                        string remoteEpInfo = txSocket.RemoteEndPoint.ToString();
                        textboMsg.AppendText($"\r\n{remoteEpInfo}:连接上线了...");
                        var clientUser = new ChatUserInfo
                        {
                            UserID = Guid.NewGuid().ToString(),
                            ChatUid = remoteEpInfo,
                            ChatSocket = txSocket
                        };
                        userinfo.Add(clientUser);


                        listBoxCoustomerList.Items.Add(new ChatUserInfoBase { UserID = clientUser.UserID, ChatUid = clientUser.ChatUid });
                        listBoxCoustomerList.DisplayMember = "ChatUid";
                        listBoxCoustomerList.ValueMember = "UserID";

                        ReceseMsgGoing(txSocket, remoteEpInfo);
                    }
                    else
                    {
                        if (userinfo.Count > 0)
                        {
                            userinfo.Remove(userinfo.Where(c => c.ChatSocket == c.ChatSocket)?.FirstOrDefault());
                            //移除下拉框对于的socket或者叫用户
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 接受来自客服端发来的消息
        /// </summary>
        /// <param name="txSocket"></param>
        /// <param name="remoteEpInfo"></param>
        private void ReceseMsgGoing(Socket txSocket, string remoteEpInfo)
        {

            //退到一个客服端的时候 int getlength = txSocket.Receive(recesiveByte); 有抛异常
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        byte[] recesiveByte = new byte[1024 * 1024 * 4];
                        int getlength = txSocket.Receive(recesiveByte);
                        if (getlength <= 0) { break; }

                        var getType = recesiveByte[0].ToString();
                        string getmsg = Encoding.UTF8.GetString(recesiveByte, 1, getlength - 1);
                        ShowMsg(remoteEpInfo, getType, getmsg);
                    }
                    catch (Exception)
                    {
                        string userid = userinfo.FirstOrDefault(c => c.ChatSocket == txSocket)?.UserID;
                        listBoxCoustomerList.Items.Remove(userid);
                        userinfo.Remove(userinfo.FirstOrDefault(c => c.ChatSocket == txSocket));//从集合中移除断开的socket

                        listBoxCoustomerList.DataSource = userinfo;//重新绑定下来的信息
                        listBoxCoustomerList.DisplayMember = "ChatUid";
                        listBoxCoustomerList.ValueMember = "UserID";
                        txSocket.Dispose();
                        txSocket.Close();
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();

        }

        private void ShowMsg(string remoteEpInfo, string getType, string getmsg)
        {
            textboMsg.AppendText($"\r\n{remoteEpInfo}:消息类型:{getType}:{getmsg}");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.textBox_ip.Text = "192.168.1.101";//初始值
            this.textBox_port.Text = "50000";
        }

        /// <summary>
        /// 服务器发送消息,可以先选择要发送的一个用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            var getmSg = textBoxSendMsg.Text.Trim();
            if (string.IsNullOrWhiteSpace(getmSg))
            {
                MessageBox.Show("要发送的消息不可以为空", "注意"); return;
            }
            var obj = listBoxCoustomerList.SelectedItem;
            int getindex = listBoxCoustomerList.SelectedIndex;
            if (obj == null || getindex == -1)
            {
                MessageBox.Show("请先选择左侧用户的用户"); return;
            }
            var getChoseUser = obj as ChatUserInfoBase;
            var sendMsg = ServiceSockertHelper.GetSendMsgByte(getmSg, ChatTypeInfoEnum.StringEnum);
            userinfo.FirstOrDefault(c => c.ChatUid == getChoseUser.ChatUid)?.ChatSocket?.Send(sendMsg);
        }

        /// <summary>
        /// 给所有登录的用户发送消息,群发了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var getmSg = textBoxSendMsg.Text.Trim();
            if (string.IsNullOrWhiteSpace(getmSg))
            {
                MessageBox.Show("要发送的消息不可以为空", "注意"); return;
            }
            if (userinfo.Count <= 0)
            {
                MessageBox.Show("暂时没有客服端登录！"); return;
            }
            var sendMsg = ServiceSockertHelper.GetSendMsgByte(getmSg, ChatTypeInfoEnum.StringEnum);
            foreach (var usersocket in userinfo)
            {
                usersocket.ChatSocket?.Send(sendMsg);
            }
        }

        /// <summary>
        /// 服务器给发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendSnak_Click(object sender, EventArgs e)
        {
            var obj = listBoxCoustomerList.SelectedItem;
            int getindex = listBoxCoustomerList.SelectedIndex;
            if (obj == null || getindex == -1)
            {
                MessageBox.Show("请先选择左侧用户的用户"); return;
            }
            var getChoseUser = obj as ChatUserInfoBase;

            byte[] sendMsgByte = ServiceSockertHelper.GetSendMsgByte("", ChatTypeInfoEnum.Snake);
            userinfo.FirstOrDefault(c => c.ChatUid == getChoseUser.ChatUid)?.ChatSocket.Send(sendMsgByte);
        }


    }
}
