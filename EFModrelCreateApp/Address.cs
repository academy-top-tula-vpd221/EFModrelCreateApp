using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModrelCreateApp
{
    //[Table("Cities")]
    [EntityTypeConfiguration(typeof(AddressConfiguration))]
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; } = null!;
        public string? City { get; set; }
        public string? Street { get; set; }



        //int myid;
        //string? mycity;

        //public Address(string? city)
        //{
        //    this.mycity = city;
        //    Console.WriteLine("Address construct");
        //}

        //public override string ToString()
        //{
        //    return $"{myid} - {mycity}";
        //}

        //[Column("GlobalId")]
        //public int Id => myid;
        //[Column("TitleCity")]
        //public string? City => mycity;
    }
}
