using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BandObjectLib;
using System.Runtime.InteropServices;
using CITS_IE_Addon.Main;
using SHDocVw;
using MSHTML;

namespace CITS_IE_Addon
{
    #region Toolbar Config For IE
    //If you change the Guid value below, replace it at all the places it is being used using the find and replace option.
    [Guid("C9A6357B-25CC-4bcf-96C1-78736985D412")]
    [BandObject("CognizantITS", BandObjectStyle.Horizontal | BandObjectStyle.ExplorerToolbar, HelpText = "CognizantITS")]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    #endregion
    public partial class CITSToolbar : BandObject
    {
        public CITSToolbar()
        {
            InitializeComponent();
            this.MinSize = new System.Drawing.Size(624, 24);
            Helper.getHelper().contextMenu = CustomContextMenu.getContextMenu();
        }

        #region Add DocumentCompleteListener
        public override void initListeners()
        {
            Explorer.DocumentComplete += new DWebBrowserEvents2_DocumentCompleteEventHandler(OnDocumentComplete);
        }

        private void init()
        {
            Server.setToolbar(this);
            setExplorer();
            Server.setSocket(addressTextBox.Text);
        }

        public void setExplorer()
        {
            Helper.getHelper().Explorer = Explorer;
        }
        #endregion

        #region InjectScript
        void OnDocumentComplete(object pDisp, ref object URL)
        {
            if (iCanProceed())
            {
                if (URL.Equals("about:blank"))
                    return;
                if (URL.Equals(Explorer.LocationURL))
                    checkAndInjectInDocument();
                else
                    checkAndInjectInFrames();
            }
        }

        private void checkAndInjectInDocument()
        {
            DispHTMLDocument doc = (DispHTMLDocument)Helper.getHelper().getDocument();
            IHTMLWindow2 window = (doc as IHTMLDocument2).parentWindow;
            window.name = "";
            registerEvents(doc);
        }

        private void checkAndInjectInFrames()
        {
            List<DispHTMLDocument> documents = Helper.getHelper().getFrameDocuments() as List<DispHTMLDocument>;
            foreach (DispHTMLDocument doc in documents)
                registerEvents(doc);
        }

        private void registerEvents(DispHTMLDocument doc)
        {
            try
            {
                if (Recorder.isRunning())
                    Recorder.register(doc);
                else if (Spy.isRunning())
                    Spy.register(doc);

            }
            catch (Exception dd) { MessageBox.Show(dd.ToString()); }
        }

        private Boolean iCanProceed()
        {
            return Server.isRunning() && (Spy.isRunning() || Recorder.isRunning());
        }

        #endregion

        #region CognizantITS Action
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            init();
        }

        private void spyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (spyToolStripMenuItem.Checked)
            {
                setButtonText("SH");
                Spy.register();
            }
            else
            {
                setButtonText("H");
                Spy.deRegister();
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorTextBox.BackColor = colorDialog1.Color;
                Util.setHighlightColor("#" + colorDialog1.Color.R.ToString("X2") +
                colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2"));
            }
        }

        #endregion

        #region Enable Toolbar in All Windows
        private void enableToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.enableToolbar();
        }
        #endregion

        private void mainToolBarButton_Click(object sender, EventArgs e)
        {

        }

        private Boolean toggleSpy()
        {
            if (Spy.isRunning())
            {
                Spy.deRegister();
                return false;
            }
            else
            {
                Spy.register();
                return true;
            }
        }
        private Boolean toggleHeal()
        {
            if (Heal.isRunning())
            {
                Heal.deRegister();
                Spy.deRegister();
                spyToolStripMenuItem.Checked = false;
                spyToolStripMenuItem.Visible = false;
                return false;
            }
            else
            {
                Heal.register();
                spyToolStripMenuItem.Visible = true;
                return true;
            }
        }
        private Boolean toggleRecord()
        {
            if (Recorder.isRunning())
            {
                Recorder.deRegister();
                return false;
            }
            else
            {
                Recorder.register();
                return true;
            }
        }

        public void startSpy()
        {
            setButtonText("S");
            cogToolBarSplitButton.ForeColor = Color.DarkRed;
            Util.showNotification("Press Ctrl+RightClick to save/update the higlighted Object");
        }

        public void startHeal()
        {
            setButtonText("H");
            cogToolBarSplitButton.ForeColor = Color.DarkRed;
            Util.showNotification("To heal any object, select the object in the tree then switch on the spy");
        }

        public void startRecord()
        {
            setButtonText("R");
            cogToolBarSplitButton.ForeColor = Color.DarkRed;
            Util.showNotification("Check Context menu (Ctrl+Right click) for assertions and other functionalities");
        }

        public void stopAll()
        {
            setButtonText("");
            try
            {
                if (Spy.isRunning())
                    Spy.deRegister();
            }
            catch
            { //MessageBox.Show(ex.ToString());
            }
            try
            {
                if (Heal.isRunning())
                    Heal.deRegister();
            }
            catch
            { //MessageBox.Show(ex.ToString());
            }
            try
            {
                if (Recorder.isRunning())
                    Recorder.deRegister();
            }
            catch
            { //MessageBox.Show(ex.ToString());
            }
        }


        public void setConnectionImage(Image image)
        {
            toolStripButton1.Image = image;
        }

        public void setButtonText(String text)
        {
            cogToolBarSplitButton.Text = text;
            cogToolBarSplitButton.ForeColor = System.Drawing.Color.Green;
        }
    }
}
