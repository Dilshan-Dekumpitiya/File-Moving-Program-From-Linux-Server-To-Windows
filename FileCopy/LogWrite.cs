using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    public class LogWrite
    {
        public void LogWriteFile(string Message)
        {
            try
            {
                string logFile = "FileCopyLogs_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                //log file path
                string Filepath = "D:\\Asterisk My Projects\\File Copy From Linux to Windows\\FileCopy\\";
                Filepath = Filepath + logFile;
                DateTime CurrentTime = DateTime.Now;
                using (StreamWriter file = new StreamWriter(@Filepath, true))
                {
                    file.WriteLine(CurrentTime + " || " + Message);
                }
            }
            catch (Exception ex)
            {
                LogWriteFile("FileCopy | LogWrite() - Error occured : " + ex.Message);
            }
        }
    }

    
}
