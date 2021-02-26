using System;

using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Process[] pname = Process.GetProcessesByName("ModernWarfare");

                if (pname.Length == 0)
                {
                    Console.WriteLine("ModernWarfare not running");
                    System.Threading.Thread.Sleep(10000);
                }

                else
                {
                    Console.WriteLine("ModernWarfare running, checking priority");
                    foreach (var process in Process.GetProcessesByName("ModernWarfare"))
                    {
                        //Default priority is "AboveNormal" but it can be changed to "Normal" as well
                        process.PriorityClass = ProcessPriorityClass.AboveNormal;
						Console.WriteLine("ModernWarfare priority set to AboveNormal");
						System.Threading.Thread.Sleep(10000);
						System.Environment.Exit(1);
                    }
                }
            }
        }
    }
}