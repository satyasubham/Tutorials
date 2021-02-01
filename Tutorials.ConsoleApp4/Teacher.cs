using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp4
{
    public class Teacher :IPerson
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }

        string DepartmentName { get; set; }
    }
}
