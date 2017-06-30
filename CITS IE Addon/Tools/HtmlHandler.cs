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
using CITS_IE_Addon.Main;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace CITS_IE_Addon
{
    class HtmlHandler : IReflect
    {
        public HtmlHandler(EventHandler evHandler, IHTMLWindow2 sourceWindow)
        {
            this.eventHandler = evHandler;
            this.htmlWindow = sourceWindow;
        }

        public IHTMLWindow2 SourceHTMLWindow
        {
            get { return this.htmlWindow; }
        }

        public String frame
        {
            get { return this.htmlWindow.name; }
        }

        #region IReflect

        FieldInfo IReflect.GetField(string name, BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetField(name, bindingAttr);
        }

        FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetFields(bindingAttr);
        }

        MemberInfo[] IReflect.GetMember(string name, BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetMember(name, bindingAttr);
        }

        MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetMembers(bindingAttr);
        }

        MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetMethod(name, bindingAttr);
        }

        MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
        {
            return this.typeIReflectImplementation.GetMethod(name, bindingAttr, binder, types, modifiers);
        }

        MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetMethods(bindingAttr);
        }

        PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetProperties(bindingAttr);
        }

        PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr)
        {
            return this.typeIReflectImplementation.GetProperty(name, bindingAttr);
        }

        PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            return this.typeIReflectImplementation.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
        }

        object IReflect.InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            if (name == "[DISPID=0]")
            {
                if (this.eventHandler != null)
                {
                    if(Server.isRunning())
                    this.eventHandler(this, EventArgs.Empty);
                }
            }

            return null;
        }

        Type IReflect.UnderlyingSystemType
        {
            get
            {
                return this.typeIReflectImplementation.UnderlyingSystemType;
            }
        }

        #endregion


        private IReflect typeIReflectImplementation = typeof(HtmlHandler);
        private EventHandler eventHandler;
        private IHTMLWindow2 htmlWindow;
    }
}
