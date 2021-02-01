using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp4
{
    public class McaStudent : Student
    {
        public McaStudent()
        {
            CourseName = "MCA";
            University = new University()

            {
                Name = "OUAT",
                Address = "BBSR"
               
            };
        }

    }

}
