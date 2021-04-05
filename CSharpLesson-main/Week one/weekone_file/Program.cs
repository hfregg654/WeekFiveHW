using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace weekone_file
{
    class Program
    { 
        static void Main(string[] args)
        {
            //string path = "D:\\日本事務\\課程程式\\Week one\\weekone_file\\";
            //string path = "~\\weekone_file\\";
            string filename = "..\\weekonefile.txt";

            // string content = ClassFileReader.ReadFile(path + filename);//讀檔
            string content = "寫入";
            //ClassFileReader.WriteFile(path + filename, content);//蓋檔
            ClassFileReader.AppendFile(/*path+*/filename, content);//寫檔
            
            //ClassFolderReader.ListAllFileName(path);//讀資料夾

            //ClassFolderReader.CreateFolder(path + "Temp");//創資料夾
            //ClassFolderReader.DeleteFolder(path + "Temp");//刪資料夾
            


            /*Path.Combine(path);
            Path.GetDirectoryName(path);
            Path.GetFileNameWithoutExtension(path);*/

            Console.WriteLine(File.ReadAllText(/*path +*/ filename));
            Console.Read();

        }

       
    }
}
