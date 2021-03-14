using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCommoms
{
    using ChatModels;
    using System.Net;
    using System.Net.Http;
    using System.Net.Sockets;
    using System.Threading;

    public class ServiceSockertHelper
    {
        ///// <summary>
        ///// 服务器开始监听
        ///// </summary>
        ///// <param name="ip"></param>
        ///// <param name="port"></param>
        ///// <returns></returns>
        //public Socket ServiceStartAccept(string ip, int port)
        //{
        //    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    IPEndPoint endport = new IPEndPoint(IPAddress.Parse(ip), port);
        //    socket.Bind(endport);
        //    socket.Listen(10);
        //    Thread thread = new Thread(Recevice);
        //    thread.IsBackground = true;
        //    thread.Start();
        //    return socket;
        //}
        //private void Recevice(object obj)
        //{
        //    var socket = obj as Socket;
        //    while (true)
        //    {
        //        Socket txSocket = socket.Accept();
        //        if (txSocket.Connected)
        //        {
        //            byte[] recesiveByte = new byte[1024 * 1024 * 2];
        //            // txSocket.Receive(recesiveByte,0,SocketFlags.)
        //            int getlength = txSocket.Receive(recesiveByte);
        //            if (getlength > 0)
        //            {
        //                string getmsg = Encoding.UTF8.GetString(recesiveByte, 0, getlength);
        //                ShowMsg(getmsg);
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 要发送的消息 并带上了类型 
        /// </summary>
        /// <param name="msg">具体的消息</param>
        /// <param name="_enumType">类型如：1:文字信息，2：jpg,png图片等 3：震动 4：其他...</param>
        /// <returns></returns>
        public static byte[] GetSendMsgByte(string msg, ChatTypeInfoEnum _enumType)
        {
            byte[] byMsg = Encoding.UTF8.GetBytes(msg);
            List<byte> byMsgAndType = new List<byte>();
            byMsgAndType.Add((byte)_enumType);
            byMsgAndType.AddRange(byMsg);
            return byMsgAndType.ToArray();
        }
    }
}
