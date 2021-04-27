using System;
using System.Collections.Generic;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        /*Write a program that reads in 5 numbers. It then asks the user for another number
         and outputs whether the number has already been entered. */
        {
            List <int> numList = new List<int>();

            for  ( int i = 1 ; i <= 5 ; ++i )
            {
                Console.WriteLine("Enter Number #" + i);
                string myInput = Console.ReadLine();

                numList.Add(int.Parse(myInput));        /*will go back to the for loop conditions and then replay the entries inside curly brackets*/  
                Console.WriteLine("Thank you, your number has been added to the list");      
            }

            Console.WriteLine("Enter Number to look for");
            string myLookup = Console.ReadLine();
            int myLookupInt = int.Parse(myLookup);
            int isFound = 0; /* 0 is a false branch */

            for  ( int i = 0 ;  i < numList.Count ; ++i )
            {
                if ( numList[i] == myLookupInt )
                {
                    isFound = 1; /* 1 is a true branch */
                    break;
                }
            }

            if ( isFound  == 0 ) /* testing condition */
            {
                Console.WriteLine("NUmber Not Found");
            }
            else 
            {
                Console.WriteLine("Number Found");
            }


            
        }
    }
}
