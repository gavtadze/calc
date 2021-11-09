using System;

    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Please insert a number");

            string num1 = Console.ReadLine();

            int result = int.Parse(num1);

            Console.WriteLine("Plese choose and insert one of the actions: *,/,+,-");

            string action = Console.ReadLine();

            Console.WriteLine("Please insert another one number");

            string num2 = Console.ReadLine();

            int result2 = int.Parse(num2);

            if (action == "*")
            {
                int result3 = result * result2;

                Console.WriteLine($"Your result is:{result3}");

            }
            else if (action == "/")
            {

                int result4 = result / result2;

                Console.WriteLine($"Your result is:{result4}");
            }

            else if (action == "+")
            {
                int result5 = result + result2;
                Console.WriteLine($"Your result is:{result5}");
            }

            else if (action == "-")
            {
                int result6 = result - result2;
                Console.WriteLine($"Your result is:{result6}");
            }
            else
                Console.WriteLine("Wrong input. Please choose one of the actions: *,/,+,-");


        }
    }




