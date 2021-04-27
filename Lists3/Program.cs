using System;
using System.Collections.Generic;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> nameList = new List<string>();

            string newName = "";
            string stopword ="STOP";
            int i = 0;

            /*while ( newName.ToUpper() != stopword.ToUpper())
            {

                Console.WriteLine("Insert a name: " + i++);
                newName =Console.ReadLine();
                nameList.Add(newName);

            }*/



            while (true)
            {
                Console.WriteLine("Insert a name: " + i++);
                newName =Console.ReadLine();

                if ( newName.ToUpper() == stopword.ToUpper() )
                {
                    break;
                }
                else
                {
                    nameList.Add(newName);
                }

            }

            for ( i = nameList.Count-1 ; i >= 0 ; --i )
            {
                Console.WriteLine(nameList[i]);
            }

            //Console.WriteLine("Thank you, Current number of names in the list is" + " " + nameList.Count);
        }
    }
}
