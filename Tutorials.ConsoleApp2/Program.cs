using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CPGSEntities db = new CPGSEntities();
            var sList = new List<Mcastudent>();
            var isNewEntry = false;

            do
            {
                Console.WriteLine("Enter Student Details: ");

                Mcastudent s = new Mcastudent();

                Console.WriteLine("Enter First Name: ");
                s.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name: ");
                s.LastName = Console.ReadLine();

                s.FullName = string.Concat(s.FirstName, s.LastName);

                Console.WriteLine("Enter your 1st subject mark :");
                int n1 = Convert.ToInt32(Console.ReadLine());
                s.Mark1 = n1;

                Console.WriteLine("Enter your 2nd subject mark :");
                int n2 = Convert.ToInt32(Console.ReadLine());
                s.Mark2 = n2;

                Console.WriteLine("Enter your 3rd subject mark :");
                int n3 = Convert.ToInt32(Console.ReadLine());
                s.Mark3 = n3;

                s.Avg = (n1 + n2 + n3) / 3;

                if (s.Avg < 33)
                {
                    s.Res = "FAIL";
                }
                else
                {
                    s.Res = "PASS";
                }

                sList.Add(s);

                db.Mcastudents.Add(s);

                Console.WriteLine("Do you want to add a new Student(y/n) :");
                var ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                    isNewEntry = true;
                else
                    isNewEntry = false;


            }
            while (isNewEntry == true);


            db.SaveChanges();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Student Details");




            var studentList = db.Mcastudents.ToList();

            //Console.WriteLine("All Students");
            foreach (var item in studentList)
            {

                Console.WriteLine(String.Format("First Name : {0}\t Last Name : {1}\t Full Name : {2}\t Mark1 :{3}\t Mark2 :{4}\t Mark3 :{5}\t Avg :{6}\t Res :{7}",
                    item.FirstName, item.LastName, item.FullName, item.Mark1, item.Mark2, item.Mark3, item.Avg, item.Res));
            }

            Console.ReadLine();
        }
    }
}
