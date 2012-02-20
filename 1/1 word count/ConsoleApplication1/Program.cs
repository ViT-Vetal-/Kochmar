using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            String s;
            int a = 0;
            int b = 0;
            int c = 0;

            StreamReader f2 = new StreamReader("text.txt");

            while((s = f2.ReadLine()) != null)
            {
                a++;
                string[] words = s.Split(' ');

                for (int i = 0; i < (words.Length); i++)
                {
                    c += words[i].Length;
                }

                b  += words.Length;
            }

            Console.WriteLine("File: text.txt\nLines " + a + "\nWords: " + b + "\nChars: " + c);

            f2.Close();

            Console.ReadLine();
        }
    }
}
