using System;
using FileCopy;
using Renci.SshNet;
using static System.Net.Mime.MediaTypeNames;

namespace WAVFileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyFiles copyFiles = new CopyFiles();
            copyFiles.Copy();

        }
    }
}
