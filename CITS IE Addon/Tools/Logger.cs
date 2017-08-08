using System;

using System.IO;

namespace CITS_IE_Addon.Tools
{
    public static class Logger
    {

        public static StreamWriter streamwriter = null;

        public static string logPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\CITS_Toolbar";

        public static void Init()
        {
            try
            {
                createFolderIfNotExists();
                if (streamwriter == null)
                {
                    FileStream filestream = new FileStream(logPath + "\\log.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    streamwriter = new StreamWriter(filestream);
                    streamwriter.AutoFlush = true;
                }

                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
                Logger.Log("Started Logging");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Log file creation." + ex.ToString());
            }
        }

        private static void createFolderIfNotExists()
        {
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);
        }

        public static void Log(string logMessage)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            Console.WriteLine("{0}", logMessage);
        }
    }
}
