using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            McaStudent s = new McaStudent();
            Console.WriteLine(s.University.Name);
            Console.WriteLine(s.CourseName);

            Console.ReadLine();
        }
    }
}
