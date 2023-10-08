using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModrelCreateApp
{
    //[NotMapped]
    public class Company
    {
        public int Id { get; set; }
        //[Required]
        public string? Title { get; set; } = null!;
        //[DefaultValue(true)]
        public bool Activity { get; set; } = true;

        //public Company()
        //{
        //    Console.WriteLine("Company create");
        //}


        //public int Field
        //{
        //    set => field = value;
        //    get => field;
        //}
    }
}
