using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace AnturaAnalysis.Helpers
{
    internal class FileHandler
    {

        public static string SearchFile()
        {
            string fileToSearch = "";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            WriteLine(Resourses.Languages.CurrentDir + currentDirectory);
            Write(Resourses.Languages.EnterFileName);
            fileToSearch = ReadLine();
            return fileToSearch;

        }

        public static string TextToSearch(string fileToSearch)
        {
            FileInfo fileInfo = new FileInfo(fileToSearch);
            string fileName = fileInfo.Name;
            string fileExtension = fileInfo.Extension;
            string textToSearch = fileName.Replace(fileExtension, "");
            //Console.WriteLine(textToSearch);
            return textToSearch;
        }



        public static bool FileCheck(string fileToSearch)
        {
            bool returnValue = false;

            if (File.Exists(fileToSearch))
            {
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }
    }
}
