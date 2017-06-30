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

using MSHTML;
using SHDocVw;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CITS_IE_Addon
{
    class Helper
    {
        static Helper helper;

        Type type = Type.GetTypeFromCLSID(new System.Guid("{3050F4E7-98B5-11CF-BB82-00AA00BDCE0B}"));

        internal System.Windows.Forms.ContextMenuStrip contextMenu;
        internal WebBrowserClass Explorer { get; set; }

        internal static Helper getHelper()
        {
            if (helper == null)
                helper = new Helper();
            return helper;
        }

        internal Object getDocumentProperty(String property)
        {
            return type.InvokeMember(property, BindingFlags.GetProperty, null, Explorer.Document, null);
        }

        internal Object getDocumentProperty(DispHTMLDocument doc, String property)
        {
            return type.InvokeMember(property, BindingFlags.GetProperty, null, doc, null);
        }

        internal Object getExplorerProperty(String property)
        {
            return Explorer.GetType().InvokeMember(property, BindingFlags.GetProperty, null, Explorer, null);
        }

        internal Object setDocumentProperty(String property, DispHTMLDocument doc, Object[] args)
        {
            return type.InvokeMember(property, BindingFlags.InvokeMethod, null, doc, args);
        }

        internal Object getDocument()
        {
            return getExplorerProperty("Document");
        }

        internal String getTitle()
        {
            return getDocumentProperty("title") as String;
        }

        internal String getURL()
        {
            return Explorer.LocationURL;
        }

        internal void addEventListener(DispHTMLDocument doc, String eventName, HtmlHandler handler)
        {
            try
            {
                doc.addEventListener(eventName, handler, true);
            }
            catch
            {
                doc.attachEvent("on" + eventName, handler);
            }
        }

        internal void removeEventListener(DispHTMLDocument doc, String eventName, HtmlHandler handler)
        {
            try
            {
                doc.removeEventListener(eventName, handler, true);
            }
            catch
            {
                doc.detachEvent("on" + eventName, handler);
            }
        }

        internal void showContextMenu(int x, int y)
        {
            if (CITS_IE_Addon.Main.Recorder.isRunning())
                contextMenu.Show(x, y);
        }

        internal List<DispHTMLDocument> getDocumentList()
        {
            List<DispHTMLDocument> documents = new List<DispHTMLDocument>();
            DispHTMLDocument doc = (DispHTMLDocument)getDocument();
            IHTMLWindow2 window = (doc as IHTMLDocument2).parentWindow;
            window.name = "";
            documents.Add(doc);
            documents.AddRange(getFrameDocuments());
            return documents;
        }

        internal IEnumerable<DispHTMLDocument> getFrameDocuments()
        {
            List<DispHTMLDocument> documents = new List<DispHTMLDocument>();
            try
            {
                FramesCollection frames = Helper.getHelper().getDocumentProperty("frames") as FramesCollection;
                for (int i = 0; i < frames.length; i++)
                {
                    Object frameObject = frames.item(i);
                    IHTMLWindow2 frame = (IHTMLWindow2)frameObject;
                    frameObject = CrossFrameIE.GetDocumentFromWindow(frame).activeElement.document;
                    DispHTMLDocument FrameDoc = (DispHTMLDocument)frameObject;
                    string framedata = getFrameValue(FrameDoc);
                    frame.name = framedata != null ? framedata : i + "";
                    documents.Add(FrameDoc);
                }
            }
            catch (Exception ex)
            {

            }
            return documents;
        }

        private static String getFrameValue(DispHTMLDocument FrameDoc)
        {
            try
            {
                IHTMLWindow2 window = (FrameDoc as IHTMLDocument2).parentWindow;
                if (window.name != null && window.name.Trim().Length > 0)
                    return window.name;
                IHTMLWindow4 frameWindow = (FrameDoc as IHTMLDocument2).parentWindow as IHTMLWindow4;
                IHTMLElement frame = frameWindow.frameElement as IHTMLElement;
                if (!String.IsNullOrEmpty(frame.id))
                    return frame.id;
            }
            catch { }
            return null;
        }
    }
}
