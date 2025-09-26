using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCalculations
{
    internal class Menu
    {
        // A menu renders here.
        // In: menuHeader, String array full of lines to be before the different options in the list,
        // In: menuOptions, String array the menu options themselves.
        // Out: menuSelection, Integer containing a value corresponding to the menu index.
        public static int Render(string[] menuHeader, string[] menuOptions)
        {
            int menuSelection;
            int currentSelection = 0;

            while (true)
            {
                Console.Clear();
                string arrowMarker = " -> ";
                string emptyMarker = "    ";


                // Draw menu header.
                foreach (string headerLine in menuHeader)
                {
                    Console.WriteLine(headerLine);
                }

                // Draw the actual menu.
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == currentSelection)
                    {
                        Console.WriteLine($"{arrowMarker}{menuOptions[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{emptyMarker}{menuOptions[i]}");
                    }
                }

                // Receive user input and update cursor on screen. 
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                switch (pressed.Key)
                {
                    // "UP" keys
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.NumPad8:
                        if (currentSelection > 0) { currentSelection--; }
                        break;

                    // "DOWN" keys
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.NumPad5:
                        if (currentSelection < menuOptions.Length-1) { currentSelection++; }
                        break;

                    // "CONFIRM" keys
                    case ConsoleKey.Enter:
                    case ConsoleKey.E:
                    case ConsoleKey.F:
                        menuSelection = currentSelection;
                        return menuSelection;

                    // "QUIT" keys
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
