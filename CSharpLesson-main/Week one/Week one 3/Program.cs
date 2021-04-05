using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Week_one_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //使用args
            /*foreach (var item in args)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.Read();*/

            //利用Config
            //string sourcePath = ConfigurationManager.AppSettings["SourceFilePath"];
            //string targetPath = ConfigurationManager.AppSettings["TargetFilePath"];
            //Console.WriteLine("  " + sourcePath);
            //Console.WriteLine("  " + targetPath);


            //計算時間差
            //DateTime startTime = DateTime.Now;
            //Console.WriteLine("Program start.");
            //SleepAWhile(2);
            //DateTime endTime = DateTime.Now;
            //TimeSpan ts = endTime - startTime;
            //Console.WriteLine($"執行時間{ts}秒");

            //只能看毫秒 start開啟,stop暫停,reset重置時間
            Random rnd = new Random();//取亂數
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Start.");
            sw.Start();
            SleepAWhile(rnd.Next(2,5)*2);
            sw.Stop();
            sw.Reset();
            sw.Start();
            Console.WriteLine("Second");
            SleepAWhile(rnd.Next(2,5)*2);
            sw.Stop();
            Console.WriteLine($"花費時間:{sw.ElapsedMilliseconds}毫秒");



            Console.Read();
        }


        //暫停程式數秒
        //<param name="second"></param>
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000;

            System.Threading.Thread.Sleep(ms);
        }
    }
}
