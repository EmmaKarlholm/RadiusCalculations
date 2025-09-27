using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCalculations
{
    internal class UserInput
    {

        public static int Integer()
        {
            int value = 0;
            bool wasSuccessful = false;

            bool stillValidating = true;
            while (stillValidating)
            {
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    string trimmedUserInput = userInput.Trim();
                    wasSuccessful = int.TryParse(trimmedUserInput, out value);
                }

                if (wasSuccessful)
                {
                    stillValidating = false;
                }
                else
                {
                    Thread.Sleep(200);
                    Console.Write("Not a valid number. Try again: ");
                }
            }
            return value;
        }

        public static double Double()
        {
            double value = 0;
            bool wasSuccessful = false;

            bool stillValidating = true;
            while (stillValidating)
            {
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    string trimmedUserInput = userInput.Trim();
                    wasSuccessful = double.TryParse(trimmedUserInput, out value);
                }

                if (wasSuccessful)
                {
                    stillValidating = false;
                }
                else
                {
                    Thread.Sleep(200);
                    Console.Write("Not a valid number. Try again: ");
                }
            }
            return value;
        }

        public static double PositiveDouble()
        {
            double value = 0;
            bool wasSuccessful = false;

            bool stillValidating = true;
            while (stillValidating)
            {
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    string trimmedUserInput = userInput.Trim();
                    bool wasNumber = double.TryParse(trimmedUserInput, out value);
                    if (wasNumber)
                    {
                        if (value > 0)
                        {
                            wasSuccessful = true;
                        }
                    }
                }

                if (wasSuccessful)
                {
                    stillValidating = false;
                }
                else
                {
                    Thread.Sleep(200);
                    Console.Write("Not a valid number. Try again: ");
                }
            }
            return value;
        }

        public static string TrimmedString()
        {
            string value = "";
            bool wasSuccessful = false;

            bool stillValidating = true;
            while (stillValidating)
            {
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    string trimmedUserInput = userInput.Trim();
                    wasSuccessful = true;
                }

                if (wasSuccessful)
                {
                    stillValidating = false;
                }
                else
                {
                    Thread.Sleep(200);
                    Console.Write("Not a valid input. Try again: ");
                }
            }
            return value;
        }



    }
}
