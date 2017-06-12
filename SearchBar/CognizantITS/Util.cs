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
using System.Linq;
using System.Text;

namespace SearchBar.CognizantITS
{
    class Util
    {
        static String highlightcolor = "#00f";
        internal static String getAttribute(IHTMLElement element, String attribute)
        {
            Object value = element.getAttribute(attribute);
            return value != null ? value.ToString() : null;
        }

        internal static Boolean isAttributePresent(IHTMLElement element, String attribute)
        {
            String value = getAttribute(element, attribute);
            return !String.IsNullOrEmpty(value);
        }

        internal static String getElementCount(IHTMLElement element)
        {
            if (element.parentElement != null)
            {
                IHTMLElementCollection children = element.parentElement.children as IHTMLElementCollection;
                for (int i = 0; i < children.length; i++)
                {
                    if ((children.item(i) as IHTMLElement).Equals(element))
                        return i + "";
                }
            }
            return null;
        }

        internal static IHTMLElement getElement(Object sender)
        {
            IHTMLElement element = getEvent(sender).srcElement;
            setFrame(element, sender);
            return element;
        }

        internal static IHTMLEventObj getEvent(Object sender)
        {
            HtmlHandler htmlHandler = (HtmlHandler)sender;
            return htmlHandler.SourceHTMLWindow.@event;
        }

        internal static void setFrame(IHTMLElement changeElement, object sender)
        {
            changeElement.setAttribute("frameName", getFrameName(sender));
        }

        internal static string getFrameName(object sender)
        {
            HtmlHandler htmlHandler = (HtmlHandler)sender;
            return htmlHandler.SourceHTMLWindow.name;
        }

        internal static string getFrameName(IHTMLElement element)
        {
            return getAttribute(element, "frameName");
        }

        internal static void deghlightElement(IHTMLElement element)
        {
            if (element != null)
                element.style.setAttribute("outline", "none");
        }

        internal static void highlightElement(IHTMLElement element)
        {
            if (element != null)
                element.style.setAttribute("outline", "solid 2px " + highlightcolor);
        }

        internal static void setHighlightColor(string color)
        {
            highlightcolor = color;
        }

        internal static void showConnectionError()
        {
            showNotification("Seems like CognizantITS is not running or connection is lost with CognizantITS");
        }

        internal static void showNotification(string message)
        {
           // NotificationWindow.PopupNotifier popupNotification = new NotificationWindow.PopupNotifier();
           // popupNotification.ContentText = message;
           // popupNotification.Popup();
        }
    }
}
