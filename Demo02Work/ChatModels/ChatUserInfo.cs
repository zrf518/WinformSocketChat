using System;

namespace ChatModels
{
    using System.Net.Sockets;
    public class ChatUserInfoBase
    {
        public string UserID { get; set; }
        public string ChatUid { get; set; }
     
    }
    public class ChatUserInfo: ChatUserInfoBase
    {
        public Socket ChatSocket { get; set; }
    }
}
