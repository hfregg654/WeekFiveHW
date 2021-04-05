using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace weekone_file
{
    public class ClassFileReader
    {
        /// <summary>
        /// 讀取檔案，不存在時回傳空字串
        /// </summary>
        /// <param name="path">檔案路徑</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {

            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return string.Empty;
            }

            string content = File.ReadAllText(path);
            return content;
        }
        public static void WriteFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
            }
            File.WriteAllText(path, content);
        }
        public static void AppendFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} 此路徑檔案不存在");
                Console.ReadLine();
            }
            string cTime = DateTime.Now.ToString("yyyy/MM/dd/ HH:mm:ss\t");

            File.AppendAllText(path,cTime+ content);
        }

    }
}
