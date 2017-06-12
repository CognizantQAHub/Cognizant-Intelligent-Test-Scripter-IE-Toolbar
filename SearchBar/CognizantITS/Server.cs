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

namespace SearchBar.CognizantITS
{
    class Server
    {
        private static WebSocket webSocket;
        private static CognizantITSToolbar cognizantitsToolbar;
        private static Boolean isrunning = false;

        #region Set Toolbar
        internal static void setToolbar(CognizantITSToolbar toolbar)
        {
            cognizantitsToolbar = toolbar;
        }
        #endregion

        #region WebSocket
        internal static void setSocket(String address)
        {
            try
            {
                if (!isRunning())
                {
                    webSocket = new WebSocket(address);
                    webSocket.OnMessage += new EventHandler<MessageEventArgs>(websocketMessage);
                    webSocket.OnClose += new EventHandler<CloseEventArgs>(webSocketClose);
                    webSocket.OnOpen += new EventHandler(webSocketOpen);
                    webSocket.Connect();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void websocketMessage(object sender, MessageEventArgs e)
        {
            try
            {
                HealObject data = HealObject.ToObject(e.Data);
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
                MessageBox.Show(ex.ToString());
            }
        }

        private static void checkForObjectInContext(HealObject data)
        {
            if (Heal.permissionGranted)
                Heal.Search(data);
        }

        private static void webSocketClose(object sender, CloseEventArgs e)
        {
            isrunning = false;
            cognizantitsToolbar.setConnectionImage(global::SearchBar.Properties.Resources.error);
            cognizantitsToolbar.stopAll();
            Util.showConnectionError();
        }

        private static void webSocketOpen(object sender, EventArgs e)
        {
            isrunning = true;
            cognizantitsToolbar.setConnectionImage(global::SearchBar.Properties.Resources.success);
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
