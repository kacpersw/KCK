using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ConsoleApp
{
    class Menu
    {
        private ConsoleKeyInfo key;
        public void drawMenu()
        {
            Console.WriteLine("Rezerwacja sal");
            Console.WriteLine("   1. Zarezerwuj");
            Console.WriteLine("   2. Sprawdź dostępność");
            Console.WriteLine("   3. Przedłuż rezerwację");
            Console.WriteLine("   4. Usuń rezrwację");
            Console.WriteLine("   5. Dodaj");
            Console.WriteLine("   6. Usuń");
            Console.SetCursorPosition(0, 1);
            WriteAt("->", 0);
        }

        public void bookTheRoom()
        {
            Console.Clear();
            Console.WriteLine("Wybierz salę, którą chcesz zarezerwować");
            while (true)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        drawMenu();
                        return;
                        break;
                    default:
                        break;
                }
            }
        }

        public void checkAvailability()
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer sali");
            while (true) ;

        }

        public void extendReservation()
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer sali");
            while (true) ;

        }

        public void deleteReservation()
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer sali");
            while (true) ;

        }

        public void addTheRoom()
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer sali");
            while (true) ;

        }

        public void deleteTheRoom()
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer sali");
            while (true) ;

        }

        public void WriteAt(string s, int y)
        {
            try
            {
                Console.SetCursorPosition(0, Console.CursorTop + y);
                Console.Write(s);
            }
            catch
            {

            }
        }
    }
}
