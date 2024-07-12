using System;

namespace assignment2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Removeduplicate();
            Largestnumber();

        }

        static void Removeduplicate() 
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] unique = numbers.Distinct().ToArray();
            Console.WriteLine("array after removing duplicate values");

            for (int i = 0; i < 10; i++) 
            {
                Console.Write(unique[i]+ " , ");
            }


        }

        static void Largestnumber() 
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = int.MinValue;
            int seclargest = int.MinValue;

            foreach (int i in numbers)
            {
                if(i > largest) 
                {
                    seclargest = largest;
                    largest = i;
                }

                else if (i > seclargest && i != largest) 
                {
                    seclargest = i;
                }

                Console.WriteLine("largest number is" + largest);
                Console.WriteLine("second largest is" + seclargest);
            }

        }
    }
}