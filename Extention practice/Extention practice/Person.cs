using Extention_practice.Helpers.BaseExtentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_practice
{
    public class Person
    {
        public int Id { get; set; }
        public string Email { get; set; }


        public  Person(string email)
        {
            string Email = email;
            Console.WriteLine(Email.CheckStr("@"));
        }
    }
}
