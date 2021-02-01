using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp4
{
    public interface IStudent:IPerson
    {
        string CourseName { get; set; }
        IUniversity University { get; set; }
    }
}
