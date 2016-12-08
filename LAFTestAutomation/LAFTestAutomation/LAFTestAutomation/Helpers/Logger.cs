
using System.IO;
using System.Text;

namespace LAFTestAutomationFramework.Helpers
{
    public class Logger
    {

        public static void Log(string logString)
        {
            StreamWriter sw = File.AppendText("C:\\Projects\\LAFSampleTestAutomation\\LAFSampleTestAutomation\\Logs\\Logs.txt");
            try
            {
                string logLine = string.Format("{0:G}: {1}.", System.DateTime.Now, logString);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
