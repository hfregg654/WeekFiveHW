using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary_week_one;


namespace Week_one
{
    class Program
    {
        static void InFo()
        {
            Console.WriteLine("Hi");
        }
        /*static int Add(int a, int b)
        {
            int c = 0;
            c = a + b;
            return c;
        }*/






        static void Main(string[] args)
        {
            //Console.WriteLine("Hellow World");

            /*int a = 90;
            int b = 80;
            int c = a + b;
            Console.WriteLine(c.ToString("0000"));

            string AAA = "HIHI";
            Console.WriteLine(c+AAA);

            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"{a}+{b}={c}");
            Console.Write(a+b+"\t"+c);
            Console.Write(a + b + "\t" + c);*/

            int a=0;
            int b=0;
            MyMath math = new MyMath();
            try
            {
                do
                {
                    Console.WriteLine("數字1");
                    string n1 = Console.ReadLine();
                    if (int.TryParse(n1, out int s1) == true)
                    {
                        a = Convert.ToInt32(n1);
                        Console.WriteLine("數字2");
                        string n2 = Console.ReadLine();
                        if (int.TryParse(n2, out int s2) == true)
                            b = Convert.ToInt32(n2);
                        else
                        {
                            Console.WriteLine("\n錯誤請重新輸入");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n錯誤請重新輸入");
                        continue;
                    }
                    Console.WriteLine($"總合為{math.ADD(a, b)}\n");
                } while (true);

            }
            catch (Exception)
            {

                throw;
            }
            //Console.Read();
        }
    }
}
