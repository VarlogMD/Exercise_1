using System;
namespace Exercise_1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int a, b = 0;

            try
            {
                Console.WriteLine("Enter first number");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter second number");
                b = int.Parse(Console.ReadLine());
                Menu(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Input string was not in a correct format");
            }

        }


        public static void Menu(int a, int b)
        {
            int selectionOfMenu = 0;

            Console.WriteLine("Make your choice\n\tSum(1)\n\tSubtraction(2)\n\tMultiplication(3)\n\tDivision(4)");

            selectionOfMenu = int.Parse(Console.ReadLine());
            try
            {
                if (selectionOfMenu == 1)
                {
                    Console.WriteLine("The result is " + Calculate(selectionOfMenu, a, b));

                }
                else if (selectionOfMenu == 2)
                {
                    Console.WriteLine("The result is " + Calculate(selectionOfMenu, a, b));

                }
                else if (selectionOfMenu == 3)
                {
                    Console.WriteLine("The result is " + Calculate(selectionOfMenu, a, b));

                }
                else if (selectionOfMenu == 4)
                {
                    if (b != 0)
                    {
                        Console.WriteLine("The result is " + Calculate(selectionOfMenu, a, b));
                    }
                    else
                    {
                        Console.WriteLine("You can not divide by zero!");
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong choice !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static float Calculate(int choice, int x, int y)
        {
            float result;

            if (choice == 1)
            {
                result = x + y;
                return result;
            }
            else if (choice == 2)
            {
                result = x - y;
                return result;

            }
            else if (choice == 3)
            {
                result = x * y;
                return result;

            }
            else if (choice == 4)
            {
                result = (float)x / (float)y;
                return result;
            }

            else
            {
                Console.WriteLine("Calculation error!");
                System.Environment.Exit(1);
                return 0;

            }


        }
    }


}