/**
Copyright 2014 - 2017 Cognizant Technology Solutions

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebSocketSharp;
using CITS_IE_Addon.Tools;

namespace CITS_IE_Addon.Main
{
    class WebSocketClient
    {
        private static WebSocket webSocket;
        private static CITSToolbar cognizantitsToolbar;
        private static Boolean isrunning = false;
        private enum SslProtocolsHack
        {
            Tls = 192,
            Tls11 = 768,
            Tls12 = 3072
        }

        #region Set Toolbar
        internal static void setToolbar(CITSToolbar toolbar)
        {
            cognizantitsToolbar = toolbar;
        }
        #endregion

        #region WebSocket
        internal static void setSocket(String address)
        {
            try
            {
                Tools.Logger.Log("Check if Server is running");
                if (!isRunning())
                {
                    Tools.Logger.Log("Trying to connect with server");
                    Tools.Logger.Log("Server " + address);
                    webSocket = new WebSocket(address);
                    webSocket.OnMessage += new EventHandler<MessageEventArgs>(websocketMessage);
                    webSocket.OnClose += new EventHandler<CloseEventArgs>(webSocketClose);
                    webSocket.OnOpen += new EventHandler(webSocketOpen);
                    webSocket.OnError += (sender, e) =>
                    {
                        Tools.Logger.Log("OnError");
                        Tools.Logger.Log(e.Message.ToString());
                    };
                    Tools.Logger.Log("Connecting");
                    webSocket.Connect();
                    Tools.Logger.Log("Connected");
                }

            }
            catch (Exception ex)
            {
                Tools.Logger.Log("Error Connecting Server");
                Tools.Logger.Log(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private static void websocketMessage(object sender, MessageEventArgs e)
        {
            try
            {
                HealObject data = HealObject.ToObject(e.Data);
                Tools.Logger.Log("Message from Server - " + data.action);
                switch (data.action)
                {
                    case "find":
                        checkForObjectInContext(data);
                        break;
                    case "serverStop":
                        cognizantitsToolbar.stopAll();
                        break;
                    case "startSpy":
                        cognizantitsToolbar.startSpy();
                        break;
                    case "startHeal":
                        cognizantitsToolbar.startHeal();
                        break;
                    case "startRecord":
                        cognizantitsToolbar.startRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                Tools.Logger.Log(ex.ToString());
            }
        }

        private static void checkForObjectInContext(HealObject data)
        {
            if (Heal.permissionGranted)
                Heal.Search(data);
        }

        private static void webSocketClose(object sender, CloseEventArgs e)
        {
            var sslProtocolHack = (System.Security.Authentication.SslProtocols)(SslProtocolsHack.Tls12 | SslProtocolsHack.Tls11 | SslProtocolsHack.Tls);

            if (e.Code == 1015 && webSocket.SslConfiguration.EnabledSslProtocols != sslProtocolHack)
            {
                Tools.Logger.Log("TlsHandshakeFailure Trying again");
                webSocket.SslConfiguration.EnabledSslProtocols = sslProtocolHack;
                webSocket.Connect();
            }
            else
            {
                isrunning = false;
                cognizantitsToolbar.setConnectionImage(global::CITS_IE_Addon.Properties.Resources.error);
                cognizantitsToolbar.stopAll();
                Util.showConnectionError();
            }
        }

        private static void webSocketOpen(object sender, EventArgs e)
        {
            isrunning = true;
            cognizantitsToolbar.setConnectionImage(global::CITS_IE_Addon.Properties.Resources.success);
        }

        private static void sendMessage(string msg)
        {
            try
            {
                if (isRunning())
                    webSocket.Send(msg);
                else
                    cognizantitsToolbar.stopAll();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        internal static void send(string message)
        {
            sendMessage(message);
        }

        internal static bool isRunning()
        {
            return isrunning;
        }

        #endregion
    }
}
