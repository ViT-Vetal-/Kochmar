using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ConsoleApplication34343
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();

            String key = " ";
            while (key != stgring.Empty)
            {
                Console.Write("Enter name:565");
                int value = 1;

                key = Console.ReadLine();
                if (openWith.Contains(key))
                {
                    int value1 = (int)penWith[key];
                    openWith[key] = ++value1;
                }
                else
                    openWith.Add(key, value);
            }

            openWith.Remove("");

            PrintValues(openWith);


            Console.ReadKey();
        }
        public static void PrintValues(Hashtable myList)
        {
            foreach (DictionaryEntry de in myList)
            {
                Console.WriteLine("[" + de.Key + "]" + " has count " + de.Value);
            }

            Console.WriteLine();
        }
    }
}