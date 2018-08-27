using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Car
    {
        public int carID { get; set; }
        public string mark { get; set; }
        public string model { get; set; }
        public string category { get; set; }
        public string price { get; set; }
        public string horsePower { get; set; }
    }
}