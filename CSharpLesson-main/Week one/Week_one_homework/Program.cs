using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using weekone_file;

namespace Week_one_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string FilePath = "";
                if (args.Length != 0)
                {
                    foreach (var item in args)
                    {
                        FilePath = item;
                        Console.WriteLine($"\t檔案位置{item}");
                    }
                    string content = "寫入\n";
                    ClassFileReader.AppendFile(FilePath, content);
                    Console.WriteLine(ClassFileReader.ReadFile(FilePath));
                }
                else
                    Console.WriteLine("必須有參數，參數為檔案絕對位置");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"錯誤訊息{ex}，請聯繫開發人員");
                throw;
            }
            Console.Read();
        }
    }
}
