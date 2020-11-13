using System;
using System.ComponentModel.Design;

namespace Game
{
    class Laba9
    {
        static void Main(string[] args)
        {
            int select = 1;

            ReadMenu(select);
            Choice(select);

            Console.Read();
        }
        static void Choice(int select)
        {
            while (true)
            {
                ConsoleKey Key = Console.ReadKey().Key;

                if (Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (select)
                    {
                        case 1:
                            NewGame();
                            break;

                        case 2:
                            Continue();
                            break;

                        case 3:
                            Rating();
                            break;

                        case 4:
                            Exit();
                            break;
                    }
                    break;
                }
                if (select > 1)
                    if (Key == ConsoleKey.W || Key == ConsoleKey.UpArrow)
                        select -= 1;

                if (select < 4)
                    if (Key == ConsoleKey.S || Key == ConsoleKey.DownArrow)
                        select += 1;

                Console.Clear();
                ReadMenu(select);
            }
        }

        static void ReadMenu(int select)
        {
            int counter = 0;

            ReadFream("   FEELWORDS   ", select, counter);
            Console.WriteLine("\n");
            counter++;

            ReadFream(" NEW GAME ", select, counter);
            Console.WriteLine("");
            counter++;

            ReadFream(" CONTINUE ", select, counter);
            Console.WriteLine("");
            counter++;

            ReadFream(" RATING    ", select, counter);
            Console.WriteLine("");
            counter++;

            ReadFream(" EXIT      ", select, counter);
            Console.WriteLine("");

        }
        static void ReadFream(string text, int select, int counter)
        {
            int numSpace = 50;
            if (text == "   FEELWORDS   ")
                numSpace = 48;

            string line = "";
            for (int i = 0; i < text.Length; i++)
                line += '═';

            CreateSpace(numSpace, select, counter);
            Fream('╔', line, '╗', numSpace);

            CreateSpace(numSpace, select, counter);
            Fream('║', text, '║', numSpace);

            CreateSpace(numSpace, select, counter);
            Fream('╚', line, '╝', numSpace);
        }

        static void Fream(char oneChar, string text, char twoChar, int numSpace)
        {
            Console.Write(" ");

            Console.Write(oneChar);
            Console.Write(text);
            Console.WriteLine(twoChar);

            Console.ResetColor();
        }

        static void CreateSpace(int numSpace, int select, int counter)
        {
            for (int i = 0; i < numSpace; i++)
                Console.Write(" ");

            if (select == counter)
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }

        static void NewGame()
        {
            Console.WriteLine("Enter a nickname");
            string Name = Console.ReadLine();
        }

        static void Continue()
        {
            Console.WriteLine("During development");
        }

        static void Rating()
        {
            Console.WriteLine("During development");
        }

        static void Exit()
        {
            Console.WriteLine("During development");
        }
    }
}