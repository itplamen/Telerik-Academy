//11.Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move 
//left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to 
//avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is 
//(O). Ensure a constant game speed by Thread.Sleep(150). Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Information about rock
struct Rock
{
    public int x; // x position, horyzontal
    public int y; // y position vertical
    public char symbol; // rock symbol
    public ConsoleColor color; // rock color
}

class FallingRocks
{
    static void PrintOnPosition(int x, int y, char symbol, ConsoleColor color = ConsoleColor.Gray)
    {
        //To write on the console
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }
    static void PrintStringOnPosition(int x, int y, String str, ConsoleColor color = ConsoleColor.Gray)
    {
        //To write on the console
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main(string[] args)
    {
        double speed = 100.0;
        int playFieldWith = 0;
        int livesCount = 5;

        // Remove the scrolbar and set console height and width 
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;

        //Information abouy our rock
        Rock userRock = new Rock();
        userRock.x = 2;
        userRock.y = Console.WindowHeight - 1;
        userRock.symbol = '@';
        userRock.color = ConsoleColor.Blue;

        Random randomGenerator = new Random();
        List<Rock> rocks = new List<Rock>();

        while (true)
        {
            speed++;
            if (speed > 400)
            {
                speed = 400;
            }

            bool hitted = false;
            {
                //Information about the falling rock
                Rock newRock = new Rock();
                newRock.color = ConsoleColor.Green;
                newRock.x = randomGenerator.Next(0, playFieldWith);
                newRock.y = 0;
                newRock.symbol = '#';
                rocks.Add(newRock);
            }

            //If some key is presed
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo presedKey = Console.ReadKey(true);

                //For faster move to our rock
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (presedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userRock.x - 1 >= 0)
                    {
                        userRock.x = userRock.x - 1;

                    }
                }
                else if (presedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userRock.x + 1 < playFieldWith)
                    {
                        userRock.x = userRock.x + 1;
                    }
                }
            }

            List<Rock> newList = new List<Rock>();

            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.symbol = oldRock.symbol;
                newRock.color = oldRock.color;

                if (newRock.y == userRock.y && newRock.x == userRock.x)
                {
                    livesCount--;
                    hitted = true;
                    speed += 50;

                    if (speed > 400)
                    {
                        speed = 400;
                    }

                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(8, 7, "Game Over!!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 10, "Press [Press Enter] to exit ...", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }

            rocks = newList;

            // Clear the console
            Console.Clear();

            foreach (Rock rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.symbol, rock.color);
            }

            if (hitted)
            {
                PrintOnPosition(userRock.x, userRock.y, 'X', ConsoleColor.Red);
                Console.Beep();
            }
            else
            {
                PrintOnPosition(userRock.x, userRock.y, userRock.symbol, userRock.color);
            }

            //Draw information
            PrintStringOnPosition(30, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(30, 5, "Speed: " + speed, ConsoleColor.White);

            //Slow down program
            Thread.Sleep((int)(500 - speed));
        }
    }
}