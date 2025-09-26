namespace RadiusCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    "Circumference of a triangle",
                    "Area of a triangle",
                    "Circumference of a triangle",
                    "QUIT"
                ];
                int menuSelection = Menu.Render(menuHeader, menuOptions);

                switch (menuSelection)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("\n\n\tHave a nice day!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
