using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WeChatRobot.Structs;

namespace WeChatRobot.Handle
{
    public unsafe static class ReceiveMessageHandle
    {
        public static void ShowChatRecord(IntPtr lpData)
        {
            var data1 = (MessageStruct)Marshal.PtrToStructure(lpData, typeof(MessageStruct));
            IntPtr typePtr;
            fixed (UInt16* pc = data1.type)
            {
                var p = (void*)pc;
                typePtr = new IntPtr(p);
            }
            var type = Marshal.PtrToStringUni(typePtr);

            IntPtr sourcePtr;
            fixed (UInt16* pc = data1.source)
            {
                var p = (void*)pc;
                sourcePtr = new IntPtr(p);
            };
            var source = Marshal.PtrToStringUni(sourcePtr);

            IntPtr wxidPtr;
            fixed (UInt16* pc = data1.wxid)
            {
                var p = (void*)pc;
                wxidPtr = new IntPtr(p);
            };
            var wxid = Marshal.PtrToStringUni(wxidPtr);

            IntPtr msgSenderPtr;
            fixed (UInt16* pc = data1.msgSender)
            {
                var p = (void*)pc;
                msgSenderPtr = new IntPtr(p);
            };
            var msgSender = Marshal.PtrToStringUni(msgSenderPtr);

            IntPtr contentPtr;
            fixed (UInt16* pc = data1.content)
            {
                var p = (void*)pc;
                contentPtr = new IntPtr(p);
            };
            var content = Marshal.PtrToStringUni(contentPtr);
            Console.WriteLine($"{type}  {source}  {wxid}  {content}");
        }
    }
}
