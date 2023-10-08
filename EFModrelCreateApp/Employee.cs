using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModrelCreateApp
{

    //[Index("Name", "Age", IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public Company? Company { get; set; }
        //[MinLength(3)]
        //[MaxLength(10)]
        public string? Password { set; get; }

        //[NotMapped]
        //public string FirstName { get; set; } = null!;
        //public string LastName { get; set; } = null!;

        public Employee()
        {
            Console.WriteLine("Employee create");
        }
    }
}
