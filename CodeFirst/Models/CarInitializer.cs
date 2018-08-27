using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class CarInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            context.Cars.Add(new Car
            {
                carID = 1,
                mark = "BMW",
                model = "x5",
                category = "light",
                horsePower = "600",
                price = "6000000"
            });
            
            context.Cars.Add(new Car
            {
                carID = 2,
                mark = "Audi",
                model = "q7",
                category = "light",
                horsePower = "500",
                price = "5000000"
            });
            
            base.Seed(context);
        }
    }
}