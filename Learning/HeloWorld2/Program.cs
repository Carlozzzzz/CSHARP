using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorld2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            List<string> tasks = new List<string>();

            while (true) {


                // Variables declaration
                string title = "Todo List App";
                bool isDone = false;

                int menuSelection = ShowMenu();

                // Using switch expression
                switch (isDone)
                {
                    case true:
                        //Console.WriteLine("✅ Task is done");
                        break;
                    case false:
                        //Console.WriteLine("❌ Task is not done");
                        break;
                    default:
                        Console.WriteLine("Unknown task status");
                        break;
                }


                if (menuSelection == 1)
                {
                    Console.WriteLine("=====================");
                    Console.WriteLine("Displaying the tasks: ");
                    foreach (var item in tasks)
                    {
                        Console.WriteLine("=" + item);
                    }
                    Console.WriteLine("=====================");
                    Console.WriteLine();

                } else if (menuSelection == 2)
                {
                    Console.WriteLine("Enter a Task: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    
                } else if (menuSelection == 3)
                {
                    Console.WriteLine("Exiting the application...");
                    break;
                }


            }

            int ShowMenu() {
                string[] menus = {
                    "1. Print Task",
                    "2. Add Task",
                    "3. Exit"
                };

                Console.Write("Select an option: \n");

                for (int i = 0; i < menus.Length; i++)
                {
                    Console.WriteLine(menus[i]);
                }

                Console.WriteLine("");
                Console.WriteLine("Enter your option: ");
                string result = Console.ReadLine();

                return int.TryParse(result, out int selection) ? selection : 0;
                
            }


        }
    }
}
