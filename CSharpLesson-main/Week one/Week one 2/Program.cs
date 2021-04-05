using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_one_2
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.WriteLine("Debug");
            Console.Read();
#endif


#if RELEASE
            Console.WriteLine("Release");
            
#endif
        }
    }
}
