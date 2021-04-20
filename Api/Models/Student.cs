using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Api.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}