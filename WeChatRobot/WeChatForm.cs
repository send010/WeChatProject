using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeChatRobot.Enum;
using WeChatRobot.Handle;
using WeChatRobot.Structs;

namespace WeChatRobot
{
    public class WeChatForm:Form
    {
        protected unsafe override void WndProc(ref System.Windows.Forms.Message msg)
        {
            if (msg.Msg == 0x004A)
            {
                var data = (CopyDataStruct)Marshal.PtrToStructure(msg.LParam, typeof(CopyDataStruct));
                switch ((CopyMessageTypeEnum)data.dwData)
                {
                    case CopyMessageTypeEnum.WM_Login:
                        Console.WriteLine("CopyMessageTypeEnum.WM_Login");
                        break;
                    case CopyMessageTypeEnum.WM_ShowQrPicture:
                        Console.WriteLine("CopyMessageTypeEnum.WM_ShowQrPicture");
                        break;
                    case CopyMessageTypeEnum.WM_Logout:
                        Console.WriteLine("CopyMessageTypeEnum.WM_Logout");
                        break;
                    case CopyMessageTypeEnum.WM_GetFriendList:
                        Console.WriteLine("CopyMessageTypeEnum.WM_GetFriendList");
                        break;
                    case CopyMessageTypeEnum.WM_ShowChatRecord:
                        ReceiveMessageHandle.ShowChatRecord(data.lpData);
                        break;
                    case CopyMessageTypeEnum.WM_SendTextMessage:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SendTextMessage");
                        break;
                    case CopyMessageTypeEnum.WM_SendFileMessage:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SendFileMessage");
                        break;
                    case CopyMessageTypeEnum.WM_GetInformation:
                        Console.WriteLine("CopyMessageTypeEnum.WM_GetInformation");
                        break;
                    case CopyMessageTypeEnum.WM_SendImageMessage:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SendImageMessage");
                        break;
                    case CopyMessageTypeEnum.WM_SetRoomAnnouncement:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SetRoomAnnouncement");
                        break;
                    case CopyMessageTypeEnum.WM_DeleteUser:
                        Console.WriteLine("CopyMessageTypeEnum.WM_DeleteUser");
                        break;
                    case CopyMessageTypeEnum.WM_QuitChatRoom:
                        Console.WriteLine("CopyMessageTypeEnum.WM_QuitChatRoom");
                        break;
                    case CopyMessageTypeEnum.WM_AddGroupMember:
                        Console.WriteLine("CopyMessageTypeEnum.WM_AddGroupMember");
                        break;
                    case CopyMessageTypeEnum.WM_SendXmlCard:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SendXmlCard");
                        break;
                    case CopyMessageTypeEnum.WM_ShowChatRoomMembers:
                        Console.WriteLine("CopyMessageTypeEnum.WM_ShowChatRoomMembers");
                        break;
                    case CopyMessageTypeEnum.WM_ShowChatRoomMembersDone:
                        Console.WriteLine("CopyMessageTypeEnum.WM_ShowChatRoomMembersDone");
                        break;
                    case CopyMessageTypeEnum.WM_DecryptDatabase:
                        Console.WriteLine("CopyMessageTypeEnum.WM_DecryptDatabase");
                        break;
                    case CopyMessageTypeEnum.WM_AddUser:
                        Console.WriteLine("CopyMessageTypeEnum.WM_AddUser");
                        break;
                    case CopyMessageTypeEnum.WM_SetRoomName:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SetRoomName");
                        break;
                    case CopyMessageTypeEnum.WM_AutoChat:
                        Console.WriteLine("CopyMessageTypeEnum.WM_AutoChat");
                        break;
                    case CopyMessageTypeEnum.WM_CancleAutoChat:
                        Console.WriteLine("CopyMessageTypeEnum.WM_CancleAutoChat");
                        break;
                    case CopyMessageTypeEnum.WM_AlreadyLogin:
                        Console.WriteLine("CopyMessageTypeEnum.WM_AlreadyLogin");
                        break;
                    case CopyMessageTypeEnum.WM_SendAtMsg:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SendAtMsg");
                        break;
                    case CopyMessageTypeEnum.WM_DelRoomMember:
                        Console.WriteLine("CopyMessageTypeEnum.WM_DelRoomMember");
                        break;
                    case CopyMessageTypeEnum.WM_OpenUrl:
                        Console.WriteLine("CopyMessageTypeEnum.WM_OpenUrl");
                        break;
                    case CopyMessageTypeEnum.WM_SaveFriendList:
                        Console.WriteLine("CopyMessageTypeEnum.WM_SaveFriendList");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                base.WndProc(ref msg);
            }
        }
    }
}
