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

namespace SearchBar.CognizantITS
{
    class Heal
    {
        static Boolean running = false;

        public static Boolean permissionGranted = false;
        static HashSet<IHTMLElement> elementList = new HashSet<IHTMLElement>();

        internal static Boolean isRunning()
        {
            return running;
        }

        internal static void register()
        {
            running = true;
            permissionGranted = true;
        }

        internal static void deRegister()
        {
            running = false;
            permissionGranted = false;
            dehighlightOldElements();
        }

        internal static void Search(HealObject message)
        {
            findAndHighlightElement(message);
        }

        private static void dehighlightOldElements()
        {
            foreach (IHTMLElement element in elementList)
            {
                Util.deghlightElement(element);
            } elementList.Clear();
        }

        private static void highlightElements(IHTMLElement element)
        {
            elementList.Add(element);
            Util.highlightElement(element);
        }

        private static void findAndHighlightElement(HealObject message)
        {
            dehighlightOldElements();
            searchElements(message.objects);
        }

        private static void searchElements(List<HObject> objects)
        {
            DispHTMLDocument doc = Helper.getHelper().getDocument() as DispHTMLDocument;
            foreach (HObject x in objects)
            {
                DispHTMLDocument document = getDocument(x.frame, doc);
                searchElement(x, doc);
            }
        }

        private static void searchElement(HObject x, DispHTMLDocument doc)
        {
            String exist = "false";
            Element result = findElement(x.prop, doc);
            if (result != null && result.element != null)
            {
                exist = result.count > 1 ? "partial" : "true";
                highlightElements(result.element);
            }
            CognizantITS.sendHealResult(x.pageName, x.objectname, exist);
        }

        private static Element findElement(List<Property> x, DispHTMLDocument doc)
        {
            foreach (Property prop in x)
            {
                String property = prop.property;
                String value = prop.value;
                if (!String.IsNullOrEmpty(value))
                {
                    Element result = getElement(property, value, doc);
                    if (result != null && result.element != null)
                        return result;
                }
            }
            return null;
        }

        private static Element getElement(String property, String value, DispHTMLDocument doc)
        {
            switch (property)
            {
                case Attributes.id:
                    return getElementById(value, doc);
                case Attributes.name:
                    return getElementByName(value, doc);
                case Attributes.linktext:
                    return getElementByLinkText(value, doc);
                case Attributes.css:
                    return getElementByXPathOrCSS(value, doc);
                case Attributes.classname:
                    return getElementByClassName(value, doc);
                case Attributes.rxpath:
                case Attributes.xpath:
                default:
                    return null;
            }
        }

        #region Get Element
        private static Element getElementById(String Id, DispHTMLDocument doc)
        {
            Element element = new Element();
            try
            {
                element.element = doc.getElementById(Id);
                element.count = 0;
            }
            catch { }
            return element;
        }

        private static Element getElementByName(String Name, DispHTMLDocument doc)
        {
            Element element = new Element();
            try
            {
                element = getFromCollection(doc.getElementsByName(Name));
            }
            catch { }
            return element;
        }

        private static Element getElementByClassName(String className, DispHTMLDocument doc)
        {
            Element element = new Element();
            try
            {
                element = getFromCollection(doc.getElementsByClassName(className));
            }
            catch { }
            return element;
        }

        private static Element getElementByXPathOrCSS(String Xpath, DispHTMLDocument doc)
        {
            Element element = new Element();
            try
            {
                element = getFromCollection(doc.querySelectorAll(Xpath));
            }
            catch { }
            return element;
        }

        private static Element getElementByLinkText(String LinkText, DispHTMLDocument doc)
        {
            Element element = new Element();
            try
            {
                IHTMLElementCollection Collection = doc.getElementsByTagName("a");
                foreach (IHTMLElement Element in Collection)
                {
                    String Link = Element.innerText;
                    if (Link != null && Link.Trim().Equals(LinkText))
                    {
                        element.element = Element;
                        element.count = 0;
                        return element;
                    }

                }

            }
            catch { }
            return element;
        }

        private static Element getFromCollection(IHTMLElementCollection Collection)
        {
            Element element = new Element();
            if (Collection != null && Collection.length > 0)
            {
                element.element = Collection.item(0) as IHTMLElement;
                element.count = Collection.length;
            }
            return element;
        }

        private static Element getFromCollection(IHTMLDOMChildrenCollection Collection)
        {
            Element element = new Element();
            if (Collection != null && Collection.length > 0)
            {
                element.element = Collection.item(0) as IHTMLElement;
                element.count = Collection.length;
            }
            return element;
        }

        private static DispHTMLDocument getDocument(String frameData, DispHTMLDocument doc)
        {
            if (frameData != null && frameData.Trim().Length > 0)
            {
                return getDocumentByFrame(doc, frameData.Trim());
            }
            return doc;
        }

        private static DispHTMLDocument getDocumentByFrame(DispHTMLDocument doc, String frameData)
        {
            try
            {
                FramesCollection frames = Helper.getHelper().getDocumentProperty("frames") as FramesCollection;
                int index;
                if (Int32.TryParse(frameData, out index) && frames.length >= index)
                {
                    return getFrameDocument(frames.item(index) as IHTMLWindow2);
                }
                else
                    for (int i = 0; i < frames.length; i++)
                    {
                        Object frameObject = frames.item(i);
                        IHTMLWindow2 frame = (IHTMLWindow2)frameObject;
                        if (frame.name.Equals(frameData))
                        {
                            frameObject = CrossFrameIE.GetDocumentFromWindow(frame).activeElement.document as DispHTMLDocument;
                            return (DispHTMLDocument)frameObject;
                        }
                    }
            }
            catch
            {

            }
            return doc;
        }

        private static DispHTMLDocument getFrameDocument(IHTMLWindow2 frame)
        {
            Object frameObject = CrossFrameIE.GetDocumentFromWindow(frame).activeElement.document as DispHTMLDocument;
            return (DispHTMLDocument)frameObject;
        }

        #endregion

    }
    class Element
    {
        public IHTMLElement element { get; set; }
        public int count { get; set; }
    }
}
