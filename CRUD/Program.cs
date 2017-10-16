using CRUD.ConsoleApp;
using CRUD.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        public static ConsoleKeyInfo key;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Menu menu = new Menu();
            Console.Clear();
            menu.drawMenu();
          

            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < 6)
                        {
                            menu.WriteAt("  ", 0);
                            menu.WriteAt("->", 1);
                        }
                         break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 1)
                        {
                            menu.WriteAt("  ", 0);
                            menu.WriteAt("->", -1);
                        }
                            break;
                    case ConsoleKey.Enter:
                        switch (Console.CursorTop)
                        {
                            case 1:
                                menu.bookTheRoom();
                                break;
                            case 2:
                                menu.checkAvailability();
                                break;
                            case 3:
                                menu.extendReservation();
                                break;
                            case 4:
                                menu.deleteReservation();
                                break;
                            case 5:
                                menu.addTheRoom();
                                break;
                            case 6:
                                menu.deleteTheRoom();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (true);
            //Operations operations = new Operations();
            //operations.postMethod();
            Console.ReadKey();
        }
    }
}
