using System;

namespace Arrays1._1
{
    class Program
    {
        static void Main(string[] args)
        /*Create a program that reads in 5 names from the console.  It then prints out "Hello <name>" for all the names entered*/
        {
            string [] Names = {"Bill", "Mary", "John", "Sam", "Steve"};
      
            foreach (string N in Names)
            {
                Console.WriteLine("Hello" + " " + N);
            }

        }
    }
}
