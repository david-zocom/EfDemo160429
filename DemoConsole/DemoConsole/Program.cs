using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoConsole.Models;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to school");
            SchoolContext context = new SchoolContext();
            int count = context.Students.Count();
            Console.WriteLine("There are " + count + " students");
            Console.WriteLine("Program done");
            Console.ReadLine();
        }
    }
}
