using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    class CopyFiles
    {

        // Path to the text file to store copied file names
        private string copiedFilesPath = "D:\\Asterisk My Projects\\File Copy From Linux to Windows\\FileCopy\\Copied_Files.txt";

        public void Copy()
        {
            LogWrite logWrite = new LogWrite();
            logWrite.LogWriteFile("File Copy Project | Copy Start");
            
            try
            {
                logWrite.LogWriteFile("File Copy Project | Check if the Copied_Files.txt exists");
                // Check if the Copied_Files.txt exists
                if (!File.Exists(copiedFilesPath))
                {
                    // Create the file if it doesn't exist
                    File.Create(copiedFilesPath).Close();
                    logWrite.LogWriteFile("File Copy Project | Create the file if it doesn't exist");
                }

                // Read the list of previously copied file names
                string[] copiedFiles = File.ReadAllLines(copiedFilesPath);
                logWrite.LogWriteFile("File Copy Project | Read the list of previously copied file names");
                
                // Set the local directory to save the copied files
                string localDir = @"E:\files";

                // Create the local directory if it doesn't exist
                if (!Directory.Exists(localDir))
                {
                    Directory.CreateDirectory(localDir);
                    logWrite.LogWriteFile("File Copy Project | ");
                }

                logWrite.LogWriteFile("File Copy Project | Start batch file run");
                // Execute the pscp command to copy the files
                Process p = new Process();

                //bat file path
                p.StartInfo.FileName = "D:\\Asterisk My Projects\\File Copy From Linux to Windows\\FileCopy\\FileCopy.bat";

                p.Start();
                p.WaitForExit();

                // Get the list of copied files
                string[] newlyCopiedFiles = Directory.GetFiles(localDir);
                logWrite.LogWriteFile("File Copy Project | Get the list of copied files");

                // Append the newly copied file names to the copied_files.txt
                foreach (var file in newlyCopiedFiles)
                {
                    string fileName = Path.GetFileName(file);
                    if (!Array.Exists(copiedFiles, element => element == fileName))
                    {
                        File.AppendAllText(copiedFilesPath, fileName + Environment.NewLine);
                        logWrite.LogWriteFile("File Copy Project | Append the newly copied file names to the Copied_Files.txt");
                    }
                }

                logWrite.LogWriteFile("File Copy Project | Files copied successfully.");


            }
            catch (Exception ex)
            {
                logWrite.LogWriteFile("File Copy Project | Error: " + ex.Message);
                
            }

        }
    }
}
