using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WeChatRobot.Structs
{
    public struct MessageStruct
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public UInt16[] type;       //消息类型
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public UInt16[] source;     //消息来源
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public UInt16[] wxid;       //微信ID/群ID
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public UInt16[] msgSender;  //消息发送者
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20000)]
        public UInt16[] content;   //消息内容
        [MarshalAs(UnmanagedType.Bool)]
        public bool isMoney;   //是否是收款消息
    }
}
