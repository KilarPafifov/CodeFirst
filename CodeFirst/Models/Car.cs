using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Car
    {
        [Key]
        public int carID { get; set; }
        public string mark { get; set; }
        public string model { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public double horsePower { get; set; }
    }
}