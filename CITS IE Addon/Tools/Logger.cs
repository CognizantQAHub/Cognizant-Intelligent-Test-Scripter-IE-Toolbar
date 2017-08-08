using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;

namespace CITS_IE_Addon.Tools
{
    public static class Logger
    {

        public static StreamWriter streamwriter;

        public static void Init()
        {
            try
            {
                string logPath = getLogLoc();
                String message = "StreamWriter is null : " + (streamwriter == null) + "\n LogPath : " + logPath;
                System.Windows.Forms.MessageBox.Show(message);
                if (streamwriter == null)
                {
                    System.Windows.Forms.MessageBox.Show("Inside " + logPath);
                    FileStream filestream = new FileStream(logPath + "\\log.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    streamwriter = new StreamWriter(filestream);
                    streamwriter.AutoFlush = true;
                }

                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
                Logger.Log("Starting Logging");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Log File Creation");
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private static String getLogLoc()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\CITS_Toolbar";
            //if (!File.Exists(path))
            Directory.CreateDirectory(path);
            //System.Windows.Forms.MessageBox.Show(path);
            System.Windows.Forms.MessageBox.Show("File Exists " + Directory.Exists(path));
            return path;
        }

        public static void Log(string logMessage)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            Console.WriteLine("{0}", logMessage);
        }
    }
}
