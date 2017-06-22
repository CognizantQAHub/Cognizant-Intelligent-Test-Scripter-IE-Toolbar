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

namespace CITS_IE_Addon.Main
{
    class CognizantITSObject
    {

        #region Object Name Creater
        internal static string getObjectName(IHTMLElement elem, List<Prop> props)
        {
            String objectName = getObjectText(elem);
            if (objectName != null)
                return objectName;
            if (getProp(Attributes.linktext, props) != null)
                return getProp(Attributes.linktext, props);
            if (getProp(Attributes.name, props) != null)
                return getProp(Attributes.name, props);
            if (getProp(Attributes.id, props) != null)
                return getProp(Attributes.id, props);
            if (getProp(Attributes.classname, props) != null)
                return getProp(Attributes.classname, props);
            if (getProp(Attributes.type, props) != null)
                return getProp(Attributes.type, props);
            return objectName;
        }

        static String getProp(String prop, List<Prop> props)
        {
            foreach (Prop pp in props)
            {
                if (pp.prop.Equals(prop) && pp.val != null && pp.val.Length > 0)
                {
                    return pp.val;
                }
            }
            return null;
        }

        private static String getObjectText(IHTMLElement element)
        {
            if (element.tagName == "IMG")
            {
                String value = Util.getAttribute(element, "alt");
                if (!String.IsNullOrEmpty(value))
                    return value;
                if (!String.IsNullOrEmpty(element.title))
                    return element.title;
            }
            else if (element.tagName == "INPUT")
            {
                String type = Util.getAttribute(element, "type");
                if (type == "submit" || type == "button" || type == "reset")
                {
                    String value = Util.getAttribute(element, "value");
                    if (value != null)
                        return value.Trim();
                }
                else
                    return getLabelValue(element);

            }
            else if (element.tagName == "TEXTAREA")
            {
                return getLabelValue(element);
            }
            else
            {
                String value = getTextForObjectName(element);
                if (!String.IsNullOrEmpty(value))
                    return value.Trim();
            }
            return null;
        }

        private static String getLabelValue(IHTMLElement element)
        {
            String value = checkForLabel(element);
            if (!String.IsNullOrEmpty(value))
                return value;
            value = Util.getAttribute(element, "placeholder");
            if (!String.IsNullOrEmpty(value))
                return value;
            value = element.title;
            if (!String.IsNullOrEmpty(value))
                return value;
            return null;
        }

        private static String checkForLabel(IHTMLElement element)
        {
            String value = checkForSuitableElement(element);
            if (!String.IsNullOrEmpty(value))
                return value;
            element = element.parentElement;
            while (element != null)
            {
                if (element.tagName == "DD" || element.tagName == "TD")
                    return checkForSuitableElement(element);
                element = element.parentElement;
            }
            return null;
        }

        private static String checkForSuitableElement(IHTMLElement element)
        {
            IElementTraversal el = element as IElementTraversal;
            if (el.previousElementSibling != null)
            {
                if (el.previousElementSibling.tagName == "LABEL")
                    return el.previousElementSibling.innerText;
                IElementSelector selector = el.previousElementSibling as IElementSelector;
                if (selector.querySelector("label") != null)
                    return selector.querySelector("label").innerText;
                selector = element.parentElement as IElementSelector;
                if (selector.querySelector("label") != null)
                    return selector.querySelector("label").innerText;
            }
            return null;
        }

        private static String getTextForObjectName(IHTMLElement element)
        {
            String txt = element.innerText;
            if (!String.IsNullOrEmpty(txt) && txt.Trim().Length > 30)
                txt = txt.Trim().Substring(0, 30);
            return txt;
        }

        #endregion

        #region Get Object Properties
        internal static List<Prop> getProperties(MSHTML.IHTMLElement elem)
        {
            List<Prop> properties = new List<Prop>();
            foreach (String attr in Attributes.attrs)
            {
                Prop property = new Prop();
                property.prop = attr;
                switch (attr)
                {
                    case Attributes.id:
                        property.val = elem.id == null ? "" : elem.id.Trim();
                        break;
                    case Attributes.name:
                        property.val = Util.getAttribute(elem, "name");
                        break;
                    case Attributes.linktext:
                        property.val = getLinkText(elem);
                        break;
                    case Attributes.classname:
                        property.val = elem.className == null ? "" : elem.className.Trim();
                        break;
                    case Attributes.css:
                        property.val = getCssPath(elem);
                        break;
                    case Attributes.xpath:
                        property.val = getXpath(elem);
                        break;
                    case Attributes.rxpath:
                        property.val = getRelXpath(elem);
                        break;
                    case Attributes.type:
                        property.val = elem.tagName.ToLower();
                        break;
                }
                properties.Add(property);

            }

            return properties;
        }

        #region Get LinkText
        private static String getLinkText(MSHTML.IHTMLElement elem)
        {
            if (elem.tagName.Equals("A"))
            {
                if (!String.IsNullOrEmpty(elem.innerText))
                    return elem.innerText.Trim();
            }
            return "";
        }
        #endregion

        #region Get the CssPath for the Element
        private static String getCssPath(IHTMLElement Element)
        {
            String CssPath = getCssSubPath(Element);
            while (Element != null && !CssPath.StartsWith("#"))
            {
                Element = Element.parentElement;
                String X = getCssSubPath(Element);
                if (X.Length > 0)
                    CssPath = X + " > " + CssPath;
            }
            return CssPath;
        }
        #endregion

        #region Get the Relative CssPath for the Element
        private static String getCssSubPath(IHTMLElement Element)
        {
            if (Element != null)
            {
                String CssPath = Element.tagName.ToLower();
                if (Element.id != null)
                {
                    CssPath = "#" + Element.id;
                    return CssPath;
                }
                if (Element.className != null)
                {
                    String Value = Element.className.Trim().Replace(" ", ".");
                    CssPath = Element.tagName.ToLower() + "." + Value;
                    return CssPath;
                }
                String[] Attributes = { "name", "type", "alt", "title", "value" };
                for (int i = 0; i < Attributes.Length; i++)
                {
                    String Attr = Attributes[i];
                    Object Value = Element.getAttribute(Attr);
                    if (Value != null && Value.ToString().Trim().Length > 0)
                    {
                        CssPath = Element.tagName.ToLower() + "[" + Attr + "=\"" + Value + "\"]";
                        return CssPath;
                    }
                }
                int count = getCount(Element);
                if (count > 1)
                    CssPath = CssPath + ":nth-child(" + count + ")";
                return CssPath;
            }
            return "";
        }
        #endregion

        #region getXpath Value for the Element
        private static String getXpath(IHTMLElement Element)
        {
            String Xpath = "";
            while (Element != null)
            {
                Xpath = "/" + Element.tagName.ToLower() + getElementCount(Element) + Xpath;
                Element = Element.parentElement;
            }
            Console.WriteLine(Xpath);
            return Xpath;
        }
        #endregion

        #region get Relative Xpath with reference to Id Value of the Element
        private static String getRelXpath(IHTMLElement Element)
        {
            String Xpath = "";
            while (Element != null)
            {
                if (Element.id != null)
                {
                    Xpath = "id(\"" + Element.id + "\")" + Xpath;
                    break;
                }
                Xpath = "/" + Element.tagName.ToLower() + getElementCount(Element) + Xpath;
                Element = Element.parentElement;
            }
            Console.WriteLine(Xpath);
            return Xpath;
        }
        #endregion

        #region GetCount and Append to the Value if count is more than one
        private static String getElementCount(IHTMLElement Element)
        {
            String Value = "";
            int count = getCount(Element);
            if (count > 1)
                Value = "[" + count + "]";
            return Value;
        }
        #endregion

        #region Find the index of Element among its siblings
        private static int getCount(IHTMLElement Element)
        {
            IHTMLDOMNode Prevoius = ((IHTMLDOMNode)Element).previousSibling;
            int count = 1;
            while (Prevoius != null && Element.parentElement != null)
            {
                if (Prevoius.nodeName.Equals(Element.tagName))
                    count++;
                Prevoius = Prevoius.previousSibling;
            }

            return count;
        }
        #endregion
        #endregion

        public static String getTextORValue(IHTMLElement element)
        {
            if ("input".Equals(element.tagName.ToLower()))
            {
                String value = Util.getAttribute(element, "value");
                if (value == null)
                {
                    value = "";
                }

                return value;
            }
            else return element.innerText.Trim();

        }

    }

    class Attributes
    {
        public const String id = "id";
        public const String name = "name";
        public const String linktext = "link_text";
        public const String rxpath = "relative_xpath";
        public const String xpath = "xpath";
        public const String css = "css";
        public const String classname = "class";
        public const String type = "type";

        public static List<String> attrs = new List<String>(new String[] { id, name, linktext, rxpath, xpath, css, classname, type });
    }
}
