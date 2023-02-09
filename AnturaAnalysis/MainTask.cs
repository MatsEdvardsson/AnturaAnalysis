using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnturaAnalysis
{
    internal class MainTask
    {

        public void Start(string fileToAnalyze)
        {
            Title = "Antura Analysis - Ett program för analys av filinnehåll";

            if (fileToAnalyze != "")
            {
                AnalyzeFile(fileToAnalyze);
            }
            else
            {

            }

            RunMainMenu();
            ReadKey();

        }

        private void RunMainMenu()
        {
            Console.BackgroundColor = Resourses.Colors.DefBackColor;
            Console.ForegroundColor = Resourses.Colors.DefFrontColor;

            BL.MenuCreate mainMenu = new BL.MenuCreate(Resourses.IntroText.MainMenuPrompt, Resourses.MenuItems.mainOptions);

            int selectedOption = mainMenu.RunOptions();

            switch (selectedOption)
            {
                case 0:
                    AnalyzeFile("");
                    break;
                case 1:
                    RunColorMenu();
                    break;
                case 2:
                    RunLangMenu();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    break;
            }

        }

        private void RunColorMenu()
        {
            BL.MenuCreate mainMenu = new BL.MenuCreate(Resourses.IntroText.MainMenuPrompt, Resourses.MenuItems.colorOptions);

            int selectedOption = mainMenu.RunOptions();

            switch (selectedOption)
            {
                case 0:
                    Resourses.Colors.DefBackColor = ConsoleColor.DarkRed;
                    Resourses.Colors.DefFrontColor = ConsoleColor.Yellow;
                    break;
                case 1:
                    Resourses.Colors.DefBackColor = ConsoleColor.Cyan;
                    Resourses.Colors.DefFrontColor = ConsoleColor.Black;
                    break;
                case 2:
                    Resourses.Colors.DefBackColor = ConsoleColor.Black;
                    Resourses.Colors.DefFrontColor = ConsoleColor.Gray;
                    break;
                default:
                    break;
            }

            RunMainMenu();

        }

        private void RunLangMenu()
        {
            BL.MenuCreate mainMenu = new BL.MenuCreate(Resourses.IntroText.MainMenuPrompt, Resourses.MenuItems.langOptions);

            int selectedOption = mainMenu.RunOptions();

            switch (selectedOption)
            {
                case 0:
                    Resourses.Languages.SetSwedish();
                    break;
                case 1:
                    Resourses.Languages.SetEnglish();
                    break;
                default:
                    break;
            }

            RunMainMenu();

        }

        private void AnalyzeFile(string fileToAnalyze)
        {
            string resultToPrint = "";

            if(fileToAnalyze == "")
            {
                fileToAnalyze = Helpers.FileHandler.SearchFile();
            }
            else
            {

            }

            bool fileFound = Helpers.FileHandler.FileCheck(fileToAnalyze);

            if (fileFound)
            {
                resultToPrint = BL.CalcOccasions.Start(fileToAnalyze);
                Output.PrintOutput(resultToPrint);
            }
            else
            {
                Console.WriteLine(Resourses.Languages.FileNotFound, fileToAnalyze);
            }

            Console.WriteLine(Resourses.Languages.HitEnter);
            ReadKey(true);
            RunMainMenu();
        }


        private void Exit()
        {
            Animation ani = new Animation();
            ani.StartAni();
            Environment.Exit(0);
        }
    }
}
