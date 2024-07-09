using System;

namespace assignment1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sumofnumbers();
            //evenumbers();
            //Leapyear();
            conversion();
        }

        static void sumofnumbers() 
        {
            string sum;
            Console.WriteLine("enter num1 and num2");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 + num2; 
            sum = num3.ToString();

            Console.WriteLine(sum);
            


        }

        static void evenumbers() 
        {
            for (int i = 2; i <= 100; i++)
            {
                Console.WriteLine(i);
                    
            };
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

        static void conversion() 
        {
            Console.WriteLine("enter speed");

            double speed = Convert.ToDouble(Console.ReadLine());

            speed = speed * 0.6213;

            Console.WriteLine(speed);

        }
    }
}