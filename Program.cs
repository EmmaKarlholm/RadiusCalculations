namespace RadiusCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

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


                switch (menuSelection)
                {
                    case 0:
                        {
                            PresentCircle("circle");
                            double userInput = UserInput.Double();
                            Circle myCircle = new Circle(userInput);
                            Console.WriteLine($"\nThe circumference of your circle is {myCircle.GetCircumference()}");
                            break;
                        }
                    case 1:
                        {
                            PresentCircle("circle");
                            double userInput = UserInput.Double();
                            Circle myCircle = new Circle(userInput);
                            Console.WriteLine($"\nThe area of your circle is {myCircle.GetArea()}");
                            break;
                        }
                    case 2:
                        {
                            PresentCircle("sphere");
                            double userInput = UserInput.Double();
                            Circle myCircle = new Circle(userInput);
                            Console.WriteLine($"\nThe volume of your sphere is {myCircle.GetVolume()}");
                            break;
                        }
                    case 3:
                        {
                            (double sideA, double sideB, double sideC) = PresentTriangle();
                            Triangle myTriangle = new Triangle(sideA, sideB, sideC);
                            bool isTriangle = myTriangle.IsTriangle();
                            if (isTriangle == true)
                            {
                                Console.WriteLine($"\nThe perimeter of your triangle is {myTriangle.GetPerimeter()}");
                            }
                            else
                            {
                                Console.WriteLine("\nA triangle cannot be formed out of the numbers you supplied.");
                            }
                            break;
                        }
                    case 4:
                        {
                            (double sideA, double sideB, double sideC) = PresentTriangle();
                            Triangle myTriangle = new Triangle(sideA, sideB, sideC);
                            bool isTriangle = myTriangle.IsTriangle();
                            if (isTriangle == true)
                            {
                                Console.WriteLine($"\nThe area of your triangle is {myTriangle.GetArea()}");
                            }
                            else
                            {
                                Console.WriteLine("A triangle cannot be formed out of the numbers you supplied.");
                            }
                        }
                        break;
                    case 5:
                        {
                            (double sideA, double sideB, double sideC) = PresentTriangle();
                            Triangle myTriangle = new Triangle(sideA, sideB, sideC);
                            bool isTriangle = myTriangle.IsTriangle();
                            if (isTriangle == true)
                            {
                                Console.WriteLine($"\nThe angles of your triangle's edges are {myTriangle.GetAngles()}");
                            }
                            else
                            {
                                Console.WriteLine("A triangle cannot be formed out of the numbers you supplied.");
                            }
                        }
                        break;
                    case 6:
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


        public static (double sideA, double sideB, double sideC) PresentTriangle()
        {
            Console.Clear();
            DrawTriangle();
            Console.Write("Please input the length of side A: ");
            double sideA = UserInput.Double();
            Console.Write("Please input the length of side B: ");
            double sideB = UserInput.Double();
            Console.Write("Please input the length of side C: ");
            double sideC = UserInput.Double();
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
