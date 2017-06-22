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
using System;
using System.Collections.Generic;
using System.Text;

namespace CITS_IE_Addon.Main
{
    class Spy
    {
        static Boolean running = false;

        private static HtmlHandler mouseOverHandler;
        private static HtmlHandler mouseOutHandler;
        private static HtmlHandler contextHandler;

        internal static Boolean isRunning()
        {
            return running;
        }

        internal static void register()
        {
            running = true;
            List<DispHTMLDocument> documents = Helper.getHelper().getDocumentList();
            foreach (DispHTMLDocument doc in documents)
                register(doc);
        }

        internal static void register(DispHTMLDocument doc)
        {
            registerEvents(doc);
        }

        internal static void deRegister()
        {
            running = false;
            List<DispHTMLDocument> documents = Helper.getHelper().getDocumentList();
            foreach (DispHTMLDocument doc in documents)
                Spy.deRegister(doc);
        }

        internal static void deRegister(DispHTMLDocument doc)
        {
            deRegisterEvents(doc);
        }

        private static void registerEvents(DispHTMLDocument doc)
        {
            IHTMLWindow2 wnd = (doc as IHTMLDocument2).parentWindow;
            registerMouseOver(doc, wnd);
            registerMouseOut(doc, wnd);
            registerContextEvent(doc, wnd);
        }

        private static void deRegisterEvents(DispHTMLDocument doc)
        {
            IHTMLWindow2 wnd = (doc as IHTMLDocument2).parentWindow;
            deRegisterEvents(doc, wnd);
        }

        private static void deRegisterEvents(DispHTMLDocument doc, IHTMLWindow2 wnd)
        {
            deRegisterMouseOver(doc, wnd);
            deRegisterMouseOut(doc, wnd);
            deRegisterContextEvent(doc, wnd);
        }

        private static void registerMouseOver(DispHTMLDocument document, IHTMLWindow2 window)
        {
            mouseOverHandler = new HtmlHandler(highlightOnMouseOver, window);
            Helper.getHelper().addEventListener(document, "mouseover", mouseOverHandler);
        }

        private static void registerMouseOut(DispHTMLDocument document, IHTMLWindow2 window)
        {
            mouseOutHandler = new HtmlHandler(deHighlightOnMouseOut, window);
            Helper.getHelper().addEventListener(document, "mouseout", mouseOutHandler);
        }

        private static void registerContextEvent(DispHTMLDocument document, IHTMLWindow2 window)
        {
            contextHandler = new HtmlHandler(recordContextEvent, window);
            Helper.getHelper().addEventListener(document, "contextmenu", contextHandler);
        }

        private static void deRegisterMouseOver(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (mouseOverHandler != null)
                Helper.getHelper().removeEventListener(document, "mouseover", mouseOverHandler);
        }

        private static void deRegisterMouseOut(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (mouseOutHandler != null)
                Helper.getHelper().removeEventListener(document, "mouseout", mouseOutHandler);
        }

        private static void deRegisterContextEvent(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (contextHandler != null)
                Helper.getHelper().removeEventListener(document, "contextmenu", contextHandler);
        }

        private static void highlightOnMouseOver(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement element = Util.getElement(sender);
                Util.highlightElement(element);
                CognizantITS.sendSpiedObject(element);
            }
        }

        private static void deHighlightOnMouseOut(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement element = Util.getElement(sender);
                Util.deghlightElement(element);
            }
        }

        #region ContextMenu
        private static IHTMLElement contextElement;
        private static void recordContextEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLEventObj eventObj = Util.getEvent(sender);
                if (eventObj.ctrlKey)
                {
                    IHTMLElement currContextElement = eventObj.srcElement;
                    Util.setFrame(currContextElement, sender);
                    if ((contextElement != null && !contextElement.Equals(currContextElement)) || contextElement == null)
                        CognizantITS.sendSpiedObjectToSave(currContextElement);
                    contextElement = currContextElement;
                    eventObj.returnValue = false;
                }
            }
        }
        #endregion

    }
}
