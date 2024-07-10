using System;
using System.ComponentModel.Design;

namespace assignment1

{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sumofnumbers();
            //Evenumbers();
            //Leapyear();
            //Conversion();
            //Buzznumber();
            //Table();
            //Factorial();
            Triangle();
            //Palindrome();
        }

        static void Sumofnumbers()
        {
            string sum;
            Console.WriteLine("enter num1 and num2");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 + num2;
            sum = num3.ToString();

            Console.WriteLine(sum);


        }

        static void Evenumbers()
        {
            for (int i = 2; i <= 100; i++)
            {
                Console.WriteLine(i);

            }
        }

        static void Leapyear()
        {
            Console.WriteLine("enter year");

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("it is a leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");
            }
        }

        static void Conversion()
        {
            Console.WriteLine("enter speed");

            double speed = Convert.ToDouble(Console.ReadLine());

            speed = speed * 0.6213;

            Console.WriteLine(speed);

        }

        static void Buzznumber()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 7 == 0 || num % 10 == 7)
            {
                Console.WriteLine("it is a buzz number");
            }
            else
            {
                Console.WriteLine("it is not a buzz number");
            }

        }

        static void Table()
        {
            Console.WriteLine("enter number");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", num, i, num * i);
            }
        }

        static void Factorial()
        {
            Console.WriteLine("enter number");

            int num = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= num; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }

        //static void Primenumber()
        //{
        //    Console.WriteLine("enter any number");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    int num2 = num - 1;
        //    IsPrime = true;

        //    while (num2 != 1) 
        //    {
        //        if (num / num2 == 0)
        //        {
        //            IsPrime = false
        //        }
              
                
        //            num2 = num2 - 1;
                
        //    }
        //    if (IsPrime == true)
        //    {
        //        Console.WriteLine("prime");

        //        else 
        //        { 
        //            (Console.WriteLine("Not prime"));

        //        }
        //    }

        //}

        static void Triangle() 
        {
            Console.WriteLine("enter lenght of sides of triangle");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            if (A != B && A != C && B != C)
            {
                Console.WriteLine("it is a scalene triangle");

            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("it is a isoceles triangle");
            }
            else if (A == B && B==C)
            {
                Console.WriteLine("it is an equilateral triangle");
            }
        }
    }
}