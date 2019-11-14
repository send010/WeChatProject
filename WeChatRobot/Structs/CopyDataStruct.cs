using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChatRobot.Structs
{
    public struct CopyDataStruct
    {
        public UInt32 dwData; //保存一个数值, 可以用来作标志等
        public UInt32 cbData; //strlen(szSendBuf);//待发送的数据的长
        public IntPtr lpData; //待发送的数据的起始地址(可以为NULL)
    }
}
