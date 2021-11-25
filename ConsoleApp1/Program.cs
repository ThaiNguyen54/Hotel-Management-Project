using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 4; i++)
            {
                string test = i.ToString()+ ".jpg";
                Console.WriteLine(test);
            }
            Console.ReadLine();
            
        }
    }
}
