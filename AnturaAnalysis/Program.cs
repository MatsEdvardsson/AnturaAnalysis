using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnturaAnalysis
{
    internal class Program
    {
        private static string FileToAnalyze = "";
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    // Console.WriteLine("Ingen fil vald");
                    // Gå direkt till huvudmenyn
                }
                else
                {
                    //Console.WriteLine(" hittade " + args[0]);
                    FileToAnalyze = args[0];
                }

                System.Threading.Thread anturaThread = new System.Threading.Thread(AnturaStart);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                anturaThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(Resourses.Languages.ErrorOccurred + ex);
            }
        }

        static void AnturaStart()
        {
            try
            {
                Resourses.Languages.SetSwedish();
                MainTask mainTask = new MainTask();
                mainTask.Start(FileToAnalyze);

                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

 
            Console.ReadKey();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(Resourses.Languages.ThreadError + e);
            Console.ReadKey();
        }
    }
}
