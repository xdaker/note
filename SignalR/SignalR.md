#SignalR
**关于SignalR的dome可以在微软的官方[下载](https://code.msdn.microsoft.com/SignalR-3ec71545),但是官方上提供的代码是web应用程序与web应用程序之间的交互，还有桌面应用程序与桌面应用程序之间的交互。所以，我通过修改dome，做了一个web应用程序与桌面应用程序之间交互的dome。**

##Web应用程序
**首先创建一个web应用程序（基于MVC），那么这个应用程序就要充当服务器和客户端。创建好了之后再做如下步骤：**
  1.引入SignalR包，在NuGet的控制台输入 install-package Microsoft.AspNet.SignalR
  
  2.使用ServerHub这个类来作为服务器。（微软dome中的类，ServerHub.cs）
  
  3.在HomeController下添加一个控件

      public ActionResult Chat()
        {
            return View();
        }

这个控件是用来提供给web客户端使用的。
再生成Chat控件的视图：

    <div class="container">
    <input type="text" id="message" />
    <input type="button" id="sendmessage" value="发送" />
    <input type="hidden" id="displayname" />
    <ul id="discussion"></ul>
    </div>
       @section scripts
               {
    <!--引用SignalR库. -->
    <script src="~/Scripts/jquery.signalR-2.2.0.min.js"></script>
    <!--引用自动生成的SignalR 集线器(Hub)脚本.在运行的时候在浏览器的Source下可看到 -->
    <script src="~/signalr/hubs"></script>
    <script>
        $(function () {
            // 引用自动生成的集线器代理
            var chat = $.connection.serverHub;
            // 定义服务器端调用的客户端sendMessage来显示新消息

            chat.client.sendMessage = function (name, message) {
                // 向页面添加消息
                $('#discussion').append('<li><strong>' + htmlEncode(name)
                    + '</strong>: ' + htmlEncode(message) + '</li>');
            };

            // 设置焦点到输入框
            $('#message').focus();
            // 开始连接服务器
            $.connection.hub.start().done(function () {
                $('#sendmessage').click(function () {
                    // 调用服务器端集线器的Send方法
                    chat.server.send($('#message').val());
                    // 清空输入框信息并获取焦点
                    $('#message').val('').focus();
                });
            });
        });

        // 为显示的消息进行Html编码
        function htmlEncode(value) {
            var encodedValue = $('<div />').text(value).html();
            return encodedValue;
        }

    </script>
      }
4.在Startup中添加
    
     // 配置集线器
     app.MapSignalR();
通过上面的代码就做好了web端的交互。
##桌面应用程序
**同样桌面应用程序也要引用SignalR包。**
1.引入SignalR包，在NuGet的控制台输入 install-package Microsoft.AspNet.SignalR和install-package Microsoft.AspNet.SignalR.Client

2.初始化集线器代理对象

      private async void ConnectAsync()
        {
            try
            {
                Connection = new HubConnection(ServerUri);//初始化连接服务器对象
                Connection.Closed += Connection_Closed;//程序关闭时发生

                // 创建一个集线器代理对象
                HubProxy = Connection.CreateHubProxy("ServerHub");

                // 供服务端调用，将消息输出到消息列表框中
                HubProxy.On<string, string>("sendMessage", (name, message) =>
                     this.Dispatcher.Invoke(() =>
                        RichTextBoxConsole.AppendText(String.Format("{0}: {1}\r", name, message))
                    ));
                try
                {
                    await Connection.Start();//测试与服务器的连接
                }
                catch (HttpRequestException)
                {
                    ChatPanel.Visibility = Visibility.Visible;
                    RichTextBoxConsole.AppendText("请检查服务是否开启：" + ServerUri + "\r");
                    // 连接失败
                    return;
                }

                //// 显示聊天控件
                ChatPanel.Visibility = Visibility.Visible;
                ButtonSend.IsEnabled = true;
                Buttonimge.IsEnabled = true;
                TextBoxMessage.Focus();
                RichTextBoxConsole.AppendText("连上服务：" + ServerUri + "\r");
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.ToString());
            }
        }
3.定义发送按钮

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            // 通过代理来调用服务端的Send方法
            // 服务端Send方法再调用客户端的AddMessage方法将消息输出到消息框中
            HubProxy.Invoke("Send", TextBoxMessage.Text.Trim());

            TextBoxMessage.Text = String.Empty;
            TextBoxMessage.Focus();
        }
###桌面应用程序作为服务器
  **如果要使用桌面应用程序作为服务器那么就要在项目下创建一个Startup类**

    using Microsoft.Owin;
    using Owin;

    [assembly: OwinStartup(typeof(SignalWPFHost.Startup))]

    namespace SignalWPFHost
     {
        public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            // 允许CORS跨域
            //app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
    }
2.启动SignalR服务，这需要一个web应用程序来启动，所以需要Startup.cs。
      
        /// <summary>
        /// 启动SignalR服务，将SignalR服务寄宿在WPF程序中
        /// </summary>
        private void StartServer()
        {
            try
            {
                SignalR = WebApp.Start(ServerUri);  // 启动SignalR服务
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("一个服务已经运行在：" + ServerUri);
                // Dispatcher回调来设置UI控件状态
                this.Dispatcher.Invoke(() => ButtonStart.IsEnabled = true);
                return;
            }

            this.Dispatcher.Invoke(() => ButtonStop.IsEnabled = true);
            WriteToConsole("服务已经成功启动，地址为：" + ServerUri);
        }
3.继承Hub类，这个类将作为一个服务，允许客户端远程调用

        public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }

        public override Task OnConnected()
        {
            //
            Application.Current.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("客户端连接，连接ID是: " + Context.ConnectionId));

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
             Application.Current.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("客户端断开连接，连接ID是: " + Context.ConnectionId));

            return base.OnDisconnected(true);
        }
    }