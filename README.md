# WeChatProject
微信助手 C#版本  支持微信版本：2.6.8.52

基于开源项目：https://github.com/TonyChen56/WeChatRobot  进行修改 把WFC改成Winform而已~方便csharper学习

流程：把C++的微信hookdll注入到微信中，然后通过SendMessage这种方式来通信

WeChatForm中重写了WndProc来获取消息数据
