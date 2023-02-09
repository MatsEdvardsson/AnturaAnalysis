using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnturaAnalysis.Resourses
{
    internal class Languages
    {
        public static string HitEnter { get; set; } = "";
        public static string CurrentDir { get; set; } = "";
        public static string EnterFileName { get; set; } = "";
        public static string FoundMatches { get; set; } = "";
        public static string ErrorReading { get; set; } = "";
        public static string FileNotFound { get; set; } = "";
        public static string ThreadError { get; set; } = "";
        public static string ErrorOccurred { get; set; } = "";
        public static string IntroTxt { get; set; } = "";


        public static void SetEnglish()
        {
            HitEnter = "Press <Enter> to continue";
            CurrentDir = "You are now in directory: ";
            EnterFileName = "Enter path and filename to analyze: ";
            FoundMatches = "Found {0} matches of {1} in file: {2}.";
            ErrorReading = "Error reading file: {0} - {1}";
            FileNotFound = "File not found {0}";
            ErrorOccurred = "Error occured. ";
            ThreadError = "Error in thred. ";
            IntroTxt = "Welcome to Antura Analysis - A program for analyzing file content\r\nUse <Up Arrow> and <Down Arrow> and <Enter> to navigate the menu\r\n";


            MenuItems.mainOptions[0] = "Analyze file";
            MenuItems.mainOptions[1] = "Choose color";
            MenuItems.mainOptions[2] = "Change language";
            MenuItems.mainOptions[3] = "Exit";

            MenuItems.colorOptions[0] = "Yellow/Red";
            MenuItems.colorOptions[1] = "Cyan/Black";
            MenuItems.colorOptions[2] = "Gray/Black";


    }

    public static void SetSwedish()
        {
            HitEnter = "Tryck <Enter> för att fortsätta";
            CurrentDir = "Du är nu i katalog: ";
            EnterFileName = "Ange sökväg och filnamn för analys: ";
            FoundMatches = "Hittade {0} matchningar av {1} i fil: {2}.";
            ErrorReading = "Fel vid läsning av fil: {0} - {1}";
            FileNotFound = "Hittar tyvärr inte {0}";
            ErrorOccurred = "Ett fel uppstod. ";
            ThreadError = "Ett fel uppstod i tråden. ";
            IntroTxt = "Välkommen till Antura Analysis - Ett program för analys av filinnehåll\r\nAnvänd <pil upp> och <pil ner> samt <Enter> för ditt val\r\n";



            MenuItems.mainOptions[0] = "Analysera fil";
            MenuItems.mainOptions[1] = "Välj färg";
            MenuItems.mainOptions[2] = "Välj språk/language";
            MenuItems.mainOptions[3] = "Avsluta";

            MenuItems.colorOptions[0] = "Gul/Röd";
            MenuItems.colorOptions[1] = "Cyan/Svart";
            MenuItems.colorOptions[2] = "Grå/Svart";
        }

    }


}
