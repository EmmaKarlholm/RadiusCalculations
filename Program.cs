using Microsoft.VisualBasic;

namespace RadiusCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Circle myCircle = new Circle();
            Triangle myTriangle = new Triangle();
            bool appStillRunning = true;
            while (appStillRunning)
            {

                string[] menuHeader = [
                    "\t\tWelcome to RadiusCalculations!\n",
                "\tWhat would you like to calculate today?\n"
                ];

                string[] menuOptions = [
                    "Circumference of a circle",
                    "Area of a circle",
                    "Volume of a sphere",
                    "Perimeter of a triangle",
                    "Area of a triangle",
                    "Angles of a triangle",
                    "- QUIT",
                ];
                
                int menuSelection = Menu.Render(menuHeader, menuOptions);

                bool isTriangle = false;
                double sideA = 0;
                double sideB = 0;
                double sideC = 0;
                double userInput = 0;

                switch (menuSelection)
                {
                    case 0: // Circle circumference
                        PresentCircle("circle");
                        userInput = UserInput.PositiveDouble();
                        myCircle.SetRadius(userInput);
                        Console.WriteLine($"\nThe circumference of your circle is {myCircle.GetCircumference()}");
                        break;
                        
                    case 1: // Circle area
                        PresentCircle("circle");
                        userInput = UserInput.PositiveDouble();
                        myCircle.SetRadius(userInput);
                        Console.WriteLine($"\nThe area of your circle is {myCircle.GetArea()}");
                        break;
                        
                    case 2: // Circle volume
                        PresentCircle("sphere");
                        userInput = UserInput.PositiveDouble();
                        myCircle.SetRadius(userInput);
                        Console.WriteLine($"\nThe volume of your sphere is {myCircle.GetVolume()}");
                        break;

                    case 3: // Triangle perimeter
                        (sideA, sideB, sideC) = PresentTriangle();
                        myTriangle.SetSides(sideA, sideB, sideC);
                        isTriangle = myTriangle.IsTriangle();
                        if (isTriangle == true)
                        {
                            Console.WriteLine($"\nThe perimeter of your triangle is {myTriangle.GetPerimeter()}");
                        }
                        else
                        {
                            Console.WriteLine("\nA triangle cannot be formed out of the numbers you supplied.");
                        }
                        break;

                    case 4: // Triangle area
                        (sideA, sideB, sideC) = PresentTriangle();
                        myTriangle.SetSides(sideA,sideB,sideC);    
                        isTriangle = myTriangle.IsTriangle();
                        if (isTriangle == true)
                        {
                            Console.WriteLine($"\nThe area of your triangle is {myTriangle.GetArea()}");
                        }
                        else
                        {
                            Console.WriteLine("A triangle cannot be formed out of the numbers you supplied.");
                        }
                        break;

                    case 5: // Triangle angles
                        (sideA, sideB, sideC) = PresentTriangle();
                        myTriangle.SetSides(sideA, sideB, sideC);
                        isTriangle = myTriangle.IsTriangle();
                        if (isTriangle == true)
                        {
                            Console.WriteLine($"\nThe angles of your triangle's edges are {myTriangle.GetAngles()}");
                        }
                        else
                        {
                            Console.WriteLine("A triangle cannot be formed out of the numbers you supplied.");
                        }
                        break;

                    case 6: // Quit
                        Console.WriteLine("\n\n\t\tHave a nice day!");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n\n");
                Console.Write("\t");
                Thread.Sleep(500);
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }


        public static void PresentCircle(string shape)
        {
            Console.Clear();
            DrawCircle();
            Console.Write($"Please input the (r)adius of the {shape}: ");
        }

        // PresentCircle and PresentTriangle behaviours differ. This is inelegant.
        // I'm currently at a little bit of a loss for how this should be improved
        // exactly without every case in the (menuSelection) switch above including
        // six lines of repeating text, which also feels inelegant.
        public static (double sideA, double sideB, double sideC) PresentTriangle()
        {
            Console.Clear();
            DrawTriangle();
            Console.Write("Please input the length of side A: ");
            double sideA = UserInput.PositiveDouble();
            Console.Write("Please input the length of side B: ");
            double sideB = UserInput.PositiveDouble();
            Console.Write("Please input the length of side C: ");
            double sideC = UserInput.PositiveDouble();            
            return (sideA, sideB, sideC);
        }


        public static void DrawCircle()
        {
            Console.WriteLine("" +
                "         ______" + "\n" +
                "        /      \\" + "\n" +
                "       /        \\" + "\n" +
                "      |          |" + "\n" +
                "      |     --r--|" + "\n" +
                "       \\        /" + "\n" +
                "        \\______/" + "\n" +
                "");
        }

        public static void DrawTriangle()
        {
            Console.WriteLine("" +
                "           /\\" + "\n" +
                "       A  /  \\  B" + "\n" +
                "         /    \\" + "\n" +
                "        /      \\" + "\n" +
                "       /________\\" + "\n" +
                "            C" + "\n" +
                "");
        }


    }
}
