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
                if (streamwriter==null)
                {
                    string logPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    FileStream filestream = new FileStream(logPath + "\\log.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    streamwriter = new StreamWriter(filestream);
                    streamwriter.AutoFlush = true;
                }
               
                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
                Logger.Log("Starting Logging");
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Log File Creation");
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        public static void Log(string logMessage)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            Console.WriteLine("{0}", logMessage);
        }
    }
}
