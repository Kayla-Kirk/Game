using Game_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameUI
    {

        Repository _repo = new Repository();

        public void Run()
        {
            Console.Title = "Fortune Game";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            _repo.User();
            Menu();
        }


        private void Menu()
        {

            bool keeprunning = true;
            while (keeprunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Pick a color any color, any color at all (As long as it is on the list below)\n" +
                    "1) Magenta\n" +
                    "2) Green\n" +
                    "3) Purple\n" +
                    "4) Cyan\n" +
                    "5) Exit\n" +
                    "Please type a number corresponding to a color above. Then, press enter to continue...");

                string inputColor = Console.ReadLine();
                Console.Clear();
                switch (inputColor)
                {
                    // Magenta
                    case "1":
                        Console.WriteLine("Pick a number:\n" +
                            "1\n" +
                            "2\n" +
                            "5\n" +
                            "6\n" +
                            "Please type a number from the list above. Then, press enter to continue...");
                        int inputNum1 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum1 == 1)
                        {
                            _repo.Fortune1();
                        }
                        else if (inputNum1 == 2)
                        {
                            _repo.Fortune2();
                        }
                        else if (inputNum1 == 5)
                        {
                            _repo.Fortune5();
                        }
                        else if (inputNum1 == 6)
                        {
                            _repo.Fortune6();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1, 2, 5, or 6.");
                            goto case "1";
                        }

                        break;
                    //Green
                    case "2":
                        Console.WriteLine("Pick a number:\n" +
                            "3\n" +
                            "4\n" +
                            "7\n" +
                            "8\n" +
                            "Please type a number from the list above. Then, press enter to continue...");
                        int inputNum2 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum2 == 3)
                        {
                            _repo.Fortune3();
                        }
                        else if (inputNum2 == 4)
                        {
                            _repo.Fortune4();
                        }
                        else if (inputNum2 == 7)
                        {
                            _repo.Fortune7();
                        }
                        else if (inputNum2 == 8)
                        {
                            _repo.Fortune8();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 3, 4, 7, or 8.");
                            goto case "2";
                        }
                        break;
                    // Purple
                    case "3":
                        Console.WriteLine("Pick a number:\n" +
                            "1\n" +
                            "2\n" +
                            "5\n" +
                            "6\n" +
                            "Please type a number from the list above. Then, press enter to continue...");
                        int inputNum3 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum3 == 1)
                        {
                            _repo.Fortune1();
                        }
                        else if (inputNum3 == 2)
                        {
                            _repo.Fortune2();
                        }
                        else if (inputNum3 == 5)
                        {
                            _repo.Fortune5();
                        }
                        else if (inputNum3 == 6)
                        {
                            _repo.Fortune6();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1, 2, 5, or 6.");
                            goto case "3";
                        }
                        break;
                    //Cyan
                    case "4":
                        Console.WriteLine("Pick a number:\n" +
                            "3\n" +
                            "4\n" +
                            "7\n" +
                            "8\n" +
                            "Please type a number from the list above. Then, press enter to continue...");
                        int inputNum4 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum4 == 3)
                        {
                            _repo.Fortune3();
                        }
                        else if (inputNum4 == 4)
                        {
                            _repo.Fortune4();
                        }
                        else if (inputNum4 == 7)
                        {
                            _repo.Fortune7();
                        }
                        else if (inputNum4 == 8)
                        {
                            _repo.Fortune8();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 3, 4, 7, or 8.");
                            goto case "4";
                        }
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
