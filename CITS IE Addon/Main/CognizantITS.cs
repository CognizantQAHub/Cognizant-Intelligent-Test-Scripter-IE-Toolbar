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

namespace CITS_IE_Addon.Main
{
    class CognizantITS
    {
        private static MSHTML.IHTMLElement previousElement;
        internal static void sendRecordedObject(MSHTML.IHTMLElement element, String method, String data)
        {
            try
            {
                RecordObjectWithInput rObject = new RecordObjectWithInput();
                rObject.method = method;
                rObject.input = data;
                setObjectProperties(element, rObject);
                rObject.objectname = CognizantITSObject.getObjectName(element, rObject.prop);
                Server.send(rObject.ToString());
            }
            catch (Exception ex)
            {
                Util.showNotification(ex.ToString());
            }
        }

        internal static void sendRecordedObject(MSHTML.IHTMLElement element, String method)
        {
            try
            {
                RecordObjectElement rObject = new RecordObjectElement();
                rObject.method = method;
                setObjectProperties(element, rObject);
                rObject.objectname = CognizantITSObject.getObjectName(element, rObject.prop);
                Server.send(rObject.ToString());
            }
            catch (Exception ex)
            {
                Util.showNotification(ex.ToString());
            }
        }

        internal static void sendRecordedObject(String method)
        {
            RecordBrowser rObject = new RecordBrowser();
            rObject.method = method;
            Server.send(rObject.ToString());
        }

        internal static void sendRecordedObject(String method, String input)
        {
            RecordBrowserWithInput rObject = new RecordBrowserWithInput();
            rObject.method = String.IsNullOrEmpty(method.Trim())?null:method;
            rObject.input = input;
            Server.send(rObject.ToString());
        }

        internal static void sendSpiedObject(MSHTML.IHTMLElement element)
        {
            try
            {
                SpyObject sObject = new SpyObject();
                setObjectProperties(element, sObject);
                Server.send(sObject.ToString());
            }
            catch (Exception ex)
            {
                Util.showNotification(ex.ToString());
            }
        }

        internal static void sendSpiedObjectToSave(MSHTML.IHTMLElement element)
        {
            try
            {
                SpySaveObject sObject = new SpySaveObject();
                setObjectProperties(element, sObject);
                sObject.objectname = CognizantITSObject.getObjectName(element, sObject.prop);
                Server.send(sObject.ToString());
            }
            catch (Exception ex)
            {
                Util.showNotification(ex.ToString());
            }
        }

        internal static void sendHealResult(string pageName, string objectname, string exist)
        {
            HealResult hResult = new HealResult();
            hResult.pageName = pageName;
            hResult.objectname = objectname;
            hResult.exist = exist;
            Server.send(hResult.ToString());
        }

        private static ObjectPropertyForElement setObjectProperties(MSHTML.IHTMLElement element, ObjectPropertyForElement data)
        {
            Util.deghlightElement(previousElement);
            previousElement = element;
            Util.highlightElement(element);
            data.page = new Page();
            data.page.title = getTitle();
            data.prop = CognizantITSObject.getProperties(element);
            data.frame = getFrameData(element);
            return data;
        }

        private static String getFrameData(MSHTML.IHTMLElement element)
        {
            return Util.getFrameName(element);
        }

        private static String getTitle()
        {
            return Helper.getHelper().getTitle();
        }


    }

}
