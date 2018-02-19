using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class HelloModel
    {
        public static List<Car> GetCars()  //static method.
        {
            //List Collection of(named) "cars".  "Static method"
            List<Car> cars = new List<Car> {
                new Car { Id = 1, Make = "BMW", Model = "528i" },  //object initializer.
                new Car { Id = 2, Make = "Hyundai", Model = "Elantra" },  //object initializer.
                new Car { Id = 3, Make = "Toyota", Model = "4Runner" }  //object initializer.
                };
            return cars; //Returns collection of "cars" to the caller.
        }

    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}