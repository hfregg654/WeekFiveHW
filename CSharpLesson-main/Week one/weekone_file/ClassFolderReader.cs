using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace weekone_file
{
    class ClassFolderReader
    {
        public static void ListAllFileName(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
            }
            string[] folderitemname = Directory.GetFileSystemEntries(path);
            foreach (var item in folderitemname)
            {
                Console.WriteLine(item);
            }
        }
        public static void CreateFolder(string path)
        {
            if (Directory.Exists(path))
                return;

            Directory.CreateDirectory(path);
        }
        public static void DeleteFolder(string path)
        {
            if (!Directory.Exists(path))
                return;

            Directory.Delete(path);

        }
    } 
}

