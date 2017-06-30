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
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CITS_IE_Addon.Main
{
    class Recorder
    {
        static Boolean running = false;

        #region Handlers
        private static HtmlHandler clickHandler;
        private static HtmlHandler changeHandler;
        private static HtmlHandler focusHandler;
        private static HtmlHandler blurHandler;
        private static HtmlHandler contextHandler;
        #endregion

        internal static Boolean isRunning()
        {
            return running;
        }

        #region Register Events

        public static void register()
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

        private static void registerEvents(DispHTMLDocument doc)
        {
            IHTMLWindow2 wnd = (doc as IHTMLDocument2).parentWindow;
            deRegisterEvents(doc, wnd);
            registerClickEvents(doc, wnd);
            registerChangeEvents(doc, wnd);
            registerContextEvent(doc, wnd);
        }

        private static void registerClickEvents(DispHTMLDocument document, IHTMLWindow2 window)
        {
            clickHandler = new HtmlHandler(recordClickEvent, window);
            Helper.getHelper().addEventListener(document, "click", clickHandler);
        }

        private static void registerChangeEvents(DispHTMLDocument document, IHTMLWindow2 window)
        {
            changeHandler = new HtmlHandler(recordChangeEvent, window);
            focusHandler = new HtmlHandler(onFocusEvent, window);
            blurHandler = new HtmlHandler(onBlurEvent, window);
            Helper.getHelper().addEventListener(document, "change", changeHandler);
            Helper.getHelper().addEventListener(document, "focus", focusHandler);
            Helper.getHelper().addEventListener(document, "blur", blurHandler);
        }

        private static void registerContextEvent(DispHTMLDocument document, IHTMLWindow2 window)
        {
            contextHandler = new HtmlHandler(recordContextEvent, window);
            Helper.getHelper().addEventListener(document, "contextmenu", contextHandler);
        }
        #endregion

        #region Deregister Events
        public static void deRegister()
        {
            running = false;
            List<DispHTMLDocument> documents = Helper.getHelper().getDocumentList();
            foreach (DispHTMLDocument doc in documents)
                deRegister(doc);
        }

        public static void deRegister(DispHTMLDocument doc)
        {
            deRegisterEvents(doc);
        }

        private static void deRegisterEvents(DispHTMLDocument doc)
        {
            IHTMLWindow2 wnd = (doc as IHTMLDocument2).parentWindow;
            deRegisterEvents(doc, wnd);
        }

        private static void deRegisterEvents(DispHTMLDocument doc, IHTMLWindow2 wnd)
        {
            deRegisterClickEvents(doc, wnd);
            deRegisterChangeEvents(doc, wnd);
            deRegisterContextEvent(doc, wnd);
        }

        private static void deRegisterClickEvents(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (clickHandler != null)// && clickHandler.SourceHTMLWindow.Equals(window))
                Helper.getHelper().removeEventListener(document, "click", clickHandler);
        }

        private static void deRegisterChangeEvents(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (changeHandler != null)// && clickHandler.SourceHTMLWindow.Equals(window))
            {
                Helper.getHelper().removeEventListener(document, "change", changeHandler);
                Helper.getHelper().removeEventListener(document, "focus", focusHandler);
                Helper.getHelper().removeEventListener(document, "blur", blurHandler);
            }
        }

        private static void deRegisterContextEvent(DispHTMLDocument document, IHTMLWindow2 window)
        {
            if (contextHandler != null)// && clickHandler.SourceHTMLWindow.Equals(window))
                Helper.getHelper().removeEventListener(document, "contextmenu", contextHandler);
        }
        #endregion

        #region Click
        private static void recordClickEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement clickElement = Util.getElement(sender);
                if (findClickableElement(clickElement) != null)
                {
                    CognizantITS.sendRecordedObject(clickElement, "Click");
                }
                else if (clickElement.tagName.ToLower() == "li")
                {
                    unorderedListClickListener(clickElement);
                }
                else if (clickElement.tagName.ToLower() != "select")
                {
                    // checkForMutatation(clickElement);
                }
            }
        }

        private static IHTMLElement findClickableElement(IHTMLElement element)
        {
            if (element.tagName == null)
                return null;
            if (Events.isClickableTag(element.tagName)
                    || Util.isAttributePresent(element, "onclick"))
            {
                return element;
            }
            else
            {
                if (element.parentElement != null)
                {
                    return findClickableElement(element.parentElement);
                }
                else
                {
                    return null;
                }
            }
        }

        private static void unorderedListClickListener(IHTMLElement clickElement)
        {
            var value = clickElement.innerText.Trim();
            if (value.Length > 0)
            {
                CognizantITS.sendRecordedObject(clickElement.parentElement, "selectValueFromUnorderedList", "@" + value);
            }
            else
            {
                CognizantITS.sendRecordedObject(clickElement.parentElement, "selectIndexFromUnorderedList", "@" + Util.getElementCount(clickElement));
            }
        }

        #endregion

        #region Set & Select

        private static Boolean isInputTypeText(IHTMLElement element)
        {
            if (element.tagName.ToLower().Equals("input"))
            {
                String type = Util.getAttribute(element, "type");
                return type != null &&
                    (type.ToLower().Equals("text") || type.ToLower().Equals("password"));
            }
            return false;
        }

        private static void onFocusEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement element = Util.getElement(sender);
                if (isInputTypeText(element))
                    element.setAttribute("previousValue", Util.getAttribute(element, "value"));
            }
        }

        private static void onBlurEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement element = Util.getElement(sender);
                if (isInputTypeText(element))
                {
                    String pvalue = Util.getAttribute(element, "previousValue");
                    String value = Util.getAttribute(element, "value");
                    if (value != null && (pvalue == null || !pvalue.Equals(value)))
                    {
                        if (Util.getAttribute(element, "type").ToLower().Equals("password"))
                            CognizantITS.sendRecordedObject(element, "setEncrypted", "@" + value);
                        else
                            CognizantITS.sendRecordedObject(element, "Set", "@" + value);
                    }
                }
            }
        }

        private static void recordChangeEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLElement changeElement = Util.getElement(sender);
                if (changeElement.tagName.ToLower() == "select")
                {
                    recordSelectEvent(changeElement);
                }
                else if (changeElement.tagName.ToLower() == "textarea" ||
                        (Util.isAttributePresent(changeElement, "type") &&
                         Events.isInputType(Util.getAttribute(changeElement, "type"))))
                {
                    String input = Util.getAttribute(changeElement, "value");
                    if (!String.IsNullOrEmpty(input))
                    {
                        if (Util.getAttribute(changeElement, "type").ToLower().Equals("password"))
                            CognizantITS.sendRecordedObject(changeElement, "setEncrypted", "@" + input);
                        else
                            CognizantITS.sendRecordedObject(changeElement, "Set", "@" + input);
                    }
                    else
                        CognizantITS.sendRecordedObject(changeElement, "clear");
                }
            }

        }

        private static void recordSelectEvent(IHTMLElement element)
        {
            IHTMLSelectElement selectelement = element as IHTMLSelectElement;
            IHTMLElement selement = selectelement.item(selectelement.selectedIndex) as IHTMLElement;
            String value = selement.innerText;
            if (!String.IsNullOrEmpty(value))
                CognizantITS.sendRecordedObject(element, "selectByVisibleText", "@" + value);
            else
                CognizantITS.sendRecordedObject(element, "selectByIndex", "@" + selectelement.selectedIndex);
        }
        #endregion

        #region ContextMenu
        private static IHTMLElement contextElement;
        private static void recordContextEvent(object sender, EventArgs e)
        {
            if (isRunning())
            {
                IHTMLEventObj eventObj = Util.getEvent(sender);
                if (eventObj.ctrlKey)
                {
                    contextElement = eventObj.srcElement;
                    Util.setFrame(contextElement, sender);
                    Helper.getHelper().showContextMenu(eventObj.screenX, eventObj.screenY);
                    eventObj.returnValue = false;
                }
            }
        }

        internal static void contextClick(String menuItem)
        {
            if (menuItem.Contains("Text"))
            {
                CognizantITS.sendRecordedObject(contextElement, menuItem, "@" + CognizantITSObject.getTextORValue(contextElement));
            }
            else if (menuItem.Contains("Title"))
            {
                CognizantITS.sendRecordedObject(menuItem, "@" + Helper.getHelper().getTitle());
            }
            else if (menuItem.Contains("Url"))
            {
                CognizantITS.sendRecordedObject(menuItem, "@" + Helper.getHelper().getURL());
            }
            else if (menuItem.ToLower().Equals("open"))
            {
                CognizantITS.sendRecordedObject("Open", "@" + Helper.getHelper().getURL());
            }
            else if (menuItem.Equals("capturePageTimings"))
            {
                CognizantITS.sendRecordedObject(menuItem, "@" + Helper.getHelper().getTitle().Split(' ')[0]);
            }
            else if (menuItem.Contains("add"))
            {
                switch (menuItem)
                {
                    case "addElementWithInput":
                        CognizantITS.sendRecordedObject(contextElement, null, "@" + CognizantITSObject.getTextORValue(contextElement));
                        break;
                    case "addElement":
                        CognizantITS.sendRecordedObject(contextElement, null);
                        break;
                    case "addBrowserWithInput":
                        CognizantITS.sendRecordedObject("", "@" + CognizantITSObject.getTextORValue(contextElement));
                        break;
                }

            }
            else if (menuItem.Contains("Element"))
            {
                CognizantITS.sendRecordedObject(contextElement, menuItem);
            }
            else
            {
                CognizantITS.sendRecordedObject(menuItem);
            }

        }
        #endregion

    }
}

class Events
{
    static ArrayList clickTags = new ArrayList(new String[] { "button", "input", "a", "textarea" });
    static ArrayList inputtype = new ArrayList(new String[] { "color", "date", "datetime", "datetime-local", "email", "file", "month", "number", "password", "range", "search", "tel", "text", "time", "url", "week" });

    internal static Boolean isClickableTag(String tag)
    {
        return clickTags.Contains(tag.ToLower());
    }

    internal static Boolean isInputType(String type)
    {
        return inputtype.Contains(type.ToLower());
    }

}
