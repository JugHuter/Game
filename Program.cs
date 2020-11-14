using System;
using System.ComponentModel.Design;

namespace Game
{
    class Laba9
    {
        static void Main(string[] args)
        {
            int choice = 1;

            Menu(choice);
            Choice(choice);

            Console.Read();
        }
        static void Choice(int choice)
        {
            while (true)
            {
                ConsoleKey Key = Console.ReadKey().Key;

                if (Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (choice)
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
                if (choice > 1)
                    if (Key == ConsoleKey.W || Key == ConsoleKey.UpArrow)
                        choice -= 1;

                if (choice < 4)
                    if (Key == ConsoleKey.S || Key == ConsoleKey.DownArrow)
                        choice += 1;

                Console.Clear();
                Menu(choice);
            }
        }

        static void Menu(int select)
        {
            int count = 0;

            ReadFream("   FEELWORDS   ", select, count);
            Console.WriteLine("\n");
            count++;

            ReadFream(" NEW GAME ", select, count);
            Console.WriteLine("");
            count++;

            ReadFream(" CONTINUE ", select, count);
            Console.WriteLine("");
            count++;

            ReadFream(" RATING    ", select, count);
            Console.WriteLine("");
            count++;

            ReadFream(" EXIT      ", select, count);
            Console.WriteLine("");

        }
        static void ReadFream(string text, int select, int count)
        {
            int numSpace = 50;
            if (text == "   FEELWORDS   ")
                numSpace = 48;

            string line = "";
            for (int i = 0; i < text.Length; i++)
                line += '-';

            CreateSpace(numSpace, select, count);
            Fream('╔', line, '╗', numSpace);

            CreateSpace(numSpace, select, count);
            Fream('|', text, '|', numSpace);

            CreateSpace(numSpace, select, count);
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
