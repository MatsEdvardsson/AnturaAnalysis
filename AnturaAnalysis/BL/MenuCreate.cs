using AnturaAnalysis.Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnturaAnalysis.BL
{
    internal class MenuCreate
    {
        private int SelectedOption;
        private string[] Options;
        private string Prompt;

        public MenuCreate(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedOption = 0;
        }

        private void DisplayOptions()
        {
            Console.BackgroundColor = Resourses.Colors.DefBackColor;
            Console.ForegroundColor = Resourses.Colors.DefFrontColor;

            WriteLine(Prompt);
            Console.WriteLine(Resourses.Languages.IntroTxt);
            
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedOption)
                {
                    prefix = "*";
                    Console.BackgroundColor = Resourses.Colors.DefFrontColor;
                    Console.ForegroundColor = Resourses.Colors.DefBackColor;

                }
                else
                {
                    Console.BackgroundColor = Resourses.Colors.DefBackColor;
                    Console.ForegroundColor = Resourses.Colors.DefFrontColor;
                    prefix = " ";
                }
                WriteLine($" {prefix} [ {currentOption} ]");
            }

        }

        public int RunOptions()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedOption--;
                    if(SelectedOption == -1) 
                    {
                        SelectedOption = Options.Length - 1;
                    }
                }else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedOption++;
                    if (SelectedOption == Options.Length)
                    {
                        SelectedOption = 0;
                    }
                }
                Console.BackgroundColor = Resourses.Colors.DefBackColor;
                Console.ForegroundColor = Resourses.Colors.DefFrontColor;


            } while (keyPressed != ConsoleKey.Enter);

            return SelectedOption;
        }


    }
}
