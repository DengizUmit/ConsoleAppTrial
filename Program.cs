using System;

namespace ConsoleAppTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               //
            */
            Console.WriteLine("Hello C#! \t My name is Umit, I am Software Developer & I am full of hope ");
            Console.ReadLine();
            Console.WriteLine("Success. \n ");





            Object a;
            a = 5;
            Console.WriteLine(a.GetType());
            a = 'Z';
            Console.WriteLine(a.GetType());
            a = 12.5f;
            Console.WriteLine(a.GetType());
            a = false;
            Console.WriteLine(a.GetType());
            a = 3.14m;
            Console.WriteLine(a.GetType());





            int num1 = 0, num2 = 0;

            Console.WriteLine("\nConsole Calculator in C#");

            Console.WriteLine("\nType a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nChoose an option from the following list");
            Console.WriteLine("\ta Add");
            Console.WriteLine("\ts Subtract");
            Console.WriteLine("\tm Multiply");
            Console.WriteLine("\td Divide\n");
            Console.WriteLine("Your option ? ");

            switch (Console.ReadLine())
            {
                case "a" :
                    Console.WriteLine("\nYour Result: {num1}+{num2} = " + (num1+num2));
                    break;
                case "s" :
                    Console.WriteLine("\nYour Result: {num1}-{num2} = " + (num1-num2));
                    break;
                case "m" :
                    Console.WriteLine("\nYour Result: {num1}*{num2} = " + (num1*num2));
                    break;
                case "d":
                    Console.WriteLine("\nYour Result: {num1}/{num2} = " + (num1/num2));
                    break;
            }

            Console.Write("\nPress any key to close the calculator Console App\n");
            Console.ReadKey();






            string n1, n2;

            int number1, number2;
            int sum = 0;

            Console.WriteLine("Enter first number:");
            n1 = Console.ReadLine();

            Console.WriteLine("Enter second number\n");
            n2 = Console.ReadLine();

            number1 = Convert.ToInt32(n1);
            number2 = Convert.ToInt32(n2);

            sum = number1 + number2;

            Console.WriteLine("Sum = \n" + sum.ToString());




            // Arrays

            int[][] array = new int[3][];

            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 4, 5 };
            array[2] = new int[] { 6, 7, 8, 9 };


            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array[i].GetLength(0); ++j)
                {
                    Console.WriteLine("array[{0}][{1}] = {2}\n", i, j, array[i][j]);
                }
            }


            



            // fact(n) = (fact)(fact-1)(fact-2)(fact-3) -> 4*3*2*1

            static int Factorial ( int fact)
            {
                if (fact == 0)
                {
                    return 1;
                }
                else
                {
                    return fact * Factorial(fact - 1);
                }
            }

            Console.WriteLine("Factorial(0) = " + Factorial(0));
            Console.WriteLine("Factorial(3) = " + Factorial(3));
            Console.WriteLine("Factorial(8) = " + Factorial(8));





            // fib(n) = fib(n-1) + fib(n-2) -> 0,1,1,2,3,5,8...

            static int Fibonacci ( int fib)
            {
                if ( fib == 0)
                {
                    return 0;

                }else if (fib == 1)
                {
                    return 1;

                }else
                {
                    return Fibonacci(fib - 1) + Fibonacci(fib - 2);
                }
            }

            Console.WriteLine("Fibonacci = " + Fibonacci(6));
        }


    }
}
