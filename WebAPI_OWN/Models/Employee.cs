using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_OWN.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}