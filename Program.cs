using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 100;

            for(int i=1; i<=range; i++)
            {
                if (i % 3==0 || i%5==0)
                {
                    if(i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    if(i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                }
                else
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }
        }
    }
}
