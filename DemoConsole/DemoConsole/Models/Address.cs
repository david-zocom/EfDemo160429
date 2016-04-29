using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    [ComplexType]
    public class Address
    {
        public Address() { }

        public string Email { get; set; }
        public string StreetAddress { get; set; }

    }
}
