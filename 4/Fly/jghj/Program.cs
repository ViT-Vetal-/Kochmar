using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace jghj
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] delimetr = new string[] { " -> " };

            StreamReader f1 = new StreamReader("text.txt");
            Hashtable openWith = new Hashtable();

            while ((str = f1.ReadLine()) != null)
            {
                string[] pieces = str.Split(delimetr, StringSplitOptions.None);

                if (pieces[0] != "" && pieces[1] != "")
                {

                    if (!openWith.Contains(pieces[0]))
                    {
                        openWith.Add(pieces[0], pieces[1]);
                    }
                    else
                    {
                        openWith[pieces[0]] += ", " + pieces[1];
                    }

                }
            }

            Console.WriteLine("Where start?");

            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine(de.Key);
            };

            ArrayList myAL = new ArrayList();

            String city = "", start_city = "";

            do
                start_city = Console.ReadLine();
            while (!openWith.Contains(start_city));

            

            myAL.Add(start_city);

            Console.WriteLine("From " + start_city +  "you may go to");
            Console.WriteLine(openWith[start_city]);

            while (start_city != city)
            {
                do
                    city = Console.ReadLine();
                while (!openWith.Contains(city));

                myAL.Add(city);

                Console.WriteLine("From " + city + "you may go to");
                Console.WriteLine(openWith[city]);
            }

            Console.Clear();

            foreach (Object obj in myAL)
            {
                Console.Write(obj + " ");
            };
            
            Console.ReadKey();
        }
    }
}
