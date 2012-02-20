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

            Program a;
            a = new Program();

            a.test(0, 9);
            a.test(10, 19);
            a.test(20, 29);
            a.test(30, 39);
            a.test(40, 49);
            a.test(50, 59);
            a.test(60, 69);
            a.test(70, 79);
            a.test(80, 89);
            a.test(90, 99);
            a.test(100, 100);

            Console.ReadLine();
        }

        void test(int a, int b)
        {
            String s;
            String str = "";

            int scores = 0;
            
            StreamReader f2 = new StreamReader("text.txt");

            while ((s = f2.ReadLine()) != null)
            {

                scores = int.Parse(s);

                if (scores >= a && scores <= b)
                    str += "*";
            }

            f2.Close();

            Console.WriteLine(a + "-" + b + str);
        }



    }
}