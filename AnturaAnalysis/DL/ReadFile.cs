using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnturaAnalysis.DL
{
    internal class ReadFile
    {

        public static string ReadMyFile(string fileToRead)
        {

            string fileContent = "";
            fileContent = File.ReadAllText(fileToRead);

            return fileContent;
        }
    }

 
}
