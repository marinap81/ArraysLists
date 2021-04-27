using System;
using System.Collections.Generic;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            for (int i = 0 ; i < 5 ; i++ ) /*5 repetitions*/

            {
                Console.WriteLine("Enter a number");
                string input1 = Console.ReadLine();

                numList.Add(int.Parse(input1));
                Console.WriteLine("Thank you, it's been added to the list");
                
            }

            Console.WriteLine("The total count is" + " " + numList.Count);

            Console.WriteLine("Enter a number to search for");
            string lookup = Console.ReadLine();

            int lookupSearch = int.Parse(lookup);
            int cntFound = 0;
    

            for  ( int i = 0 ;  i < numList.Count ; ++i )
            {
                if ( numList[i] == lookupSearch ) /*[i] is shorthand of the above for statement, loops through until exit condition met before going onto ++cntFound*/
                {
                    ++cntFound; /*seperate and only actioned once if condition is true,it will perform calc of 0 plus lookupsearch numb selected by user
                     it feeds into the next if statement*/
                }
            }

            if ( cntFound  > 0 ) 
            {
                Console.WriteLine("Number Found "  + cntFound.ToString() + " times!"); 
            }
            else 
            {
                Console.WriteLine("Number Not Found");
            }
    
        }
    }
}
