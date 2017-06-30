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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CITS_IE_Addon.Main
{
    class CustomContextMenu
    {
        const String menu = "[\"Open\", \"waitForPageLoaded\",\"capturePageTimings\"]";
        const String subMenu = "{\"Element\":[\"assertElementSelected\",\"assertElementEnabled\",\"assertElementDisplayed\",\"assertElementPresent\",\"---\",\"verifyElementSelected\",\"verifyElementEnabled\",\"verifyElementDisplayed\",\"---\",\"waitForElementToBePresent\",\"waitForElementToBeVisible\",\"waitForElementToBeClickable\"],\"Text\":[\"assertElementTextEquals\",\"assertElementTextContains\",\"assertElementTextStartsWith\",\"assertElementTextEndsWith\",\"assertElementTextMatches\"],\"Title\":[\"assertTitleEquals\",\"assertTitleContains\",\"assertTitleStartsWith\",\"assertTitleEndsWith\",\"assertTitleMatches\",\"---\",\"waitForTitleToBe\",\"waitForTitleToContain\",\"---\",\"switchToWindowByTitle\",\"switchToWindowByTitleContains\",\"switchToWindowByTitleStartsWith\"],\"URL\":[\"assertUrlEquals\",\"assertUrlContains\",\"assertUrlStartsWith\",\"assertUrlEndsWith\",\"assertUrlMatches\"],\"Other\":[\"AddElement\",\"AddElementWithInput\",\"AddBrowserWithInput\"]}";

        public static ContextMenuStrip getContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            List<String> menuList = JsonConvert.DeserializeObject<List<String>>(menu);
            foreach (String val in menuList)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(Char.ToUpperInvariant(val[0]) + val.Substring(1));
                menuItem.Click += contextMenuClick;
                contextMenu.Items.Add(menuItem);
            }

            Dictionary<String, List<String>> values = JsonConvert.DeserializeObject<Dictionary<String, List<String>>>(subMenu);
            foreach (KeyValuePair<string, List<String>> entry in values)
            {
                ToolStripMenuItem submenuItem = new ToolStripMenuItem(entry.Key);
                foreach (String val in entry.Value)
                {
                    if (val.Equals("---"))
                        submenuItem.DropDownItems.Add(new ToolStripSeparator());
                    else
                    {
                        ToolStripMenuItem menuItem = new ToolStripMenuItem(Char.ToUpperInvariant(val[0]) + val.Substring(1));
                        menuItem.Click += subcontextMenuClick;
                        submenuItem.DropDownItems.Add(menuItem);
                    }
                }
                contextMenu.Items.Add(submenuItem);
            }
            return contextMenu;
        }

        private static void subcontextMenuClick(object sender, EventArgs e)
        {
            String value = (sender as ToolStripMenuItem).Text;
            Recorder.contextClick(Char.ToLowerInvariant(value[0]) + value.Substring(1));
        }

        private static void contextMenuClick(object sender, EventArgs e)
        {
            String value = (sender as ToolStripMenuItem).Text;
            Recorder.contextClick(Char.ToLowerInvariant(value[0]) + value.Substring(1));
        }
    }
}
