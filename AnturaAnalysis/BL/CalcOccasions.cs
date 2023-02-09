using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace AnturaAnalysis.BL
{
    internal class CalcOccasions
    {
        public static string Start(string fileToAnalyze)
        {
            string textToSearch = "";
            string fileContent = "";
            string returnValue;

            try
            {
                fileContent = DL.ReadFile.ReadMyFile(fileToAnalyze);
                textToSearch = Helpers.FileHandler.TextToSearch(fileToAnalyze);
                Regex rx = new Regex(textToSearch, RegexOptions.IgnoreCase);
                MatchCollection matches = rx.Matches(fileContent);
                returnValue = string.Format(Resourses.Languages.FoundMatches, matches.Count, textToSearch, fileToAnalyze);
            }
            catch (Exception ex)
            {
                returnValue = string.Format(Resourses.Languages.ErrorReading, fileToAnalyze, ex);
            }

            return returnValue;
        }
    }
}
