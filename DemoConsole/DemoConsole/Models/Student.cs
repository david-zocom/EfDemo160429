using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address AlternativeAddress { get; set; }

    }
}
