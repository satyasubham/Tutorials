using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorials.ClassLibrary1;

namespace Tutorials.ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CPGSEntities1 db = new CPGSEntities1();

            var studentList = db.Mcastudents.ToList();

            Console.WriteLine("All Students");
            foreach (var item in studentList)
            {

                Console.WriteLine(String.Format("First Name : {0}\t Last Name : {1}\t Full Name : {2}\t Mark1 :{3}\t Mark2 :{4}\t Mark3 :{5}\t Avg :{6}\t Res :{7}",
                    item.FirstName, item.LastName, item.FullName, item.Mark1, item.Mark2, item.Mark3, item.Avg, item.Res));


            }

            Console.WriteLine("Student Starts with 'S'");
            foreach (var item in studentList)
            {
                if (item.FirstName.ToUpper().StartsWith("S"))
                {

                    Console.WriteLine(String.Format("First Name : {0}\t Last Name : {1}\t Full Name : {2}\t Mark1 :{3}\t Mark2 :{4}\t Mark3 :{5}\t Avg :{6}\t Res :{7}",
                     item.FirstName, item.LastName, item.FullName, item.Mark1, item.Mark2, item.Mark3, item.Avg, item.Res));


                }
            }

            var sList = db.Mcastudents
                .Where(x => x.FirstName.ToUpper().StartsWith("S"))
                .ToList();

            foreach (var item in sList)
            {


                Console.WriteLine(String.Format("First Name : {0}\t Last Name : {1}\t Full Name : {2}\t Mark1 :{3}\t Mark2 :{4}\t Mark3 :{5}\t Avg :{6}\t Res :{7}",
                     item.FirstName, item.LastName, item.FullName, item.Mark1, item.Mark2, item.Mark3, item.Avg, item.Res));
            }

            Console.ReadLine();

        }
    }
}
