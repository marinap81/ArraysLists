using System;

namespace Arrays1._2
{
    class Program
    {
        static void Main(string[] args)
        /*A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. Write a program that adds all 
        numbers together and outputs the total. */
        {
            int [] Values = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int sum = 0;
            for (int i = 0; i <10; i++)
                {
                    sum += Values[i]; /*compound assignment operator, always used for mathematical outputs
                    shorthand 
                    /* same as sum = sum + values[i] .. in this example sum = 0 as is declared above*/
                }

                Console.WriteLine(sum);
        }
 
    }        
}
