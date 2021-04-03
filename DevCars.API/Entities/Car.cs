using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Entities
{
    public class Car
    {
        protected Car() { }
        public Car(string vinCode, string brand, string model, int year, decimal price, string color, DateTime productonDate)
        {
            VinCode = vinCode;
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            ProductonDate = productonDate;

            Status = CarsStatusEnum.Available;
            RegistredAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string VinCode { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public decimal Price { get; private set; }
        public string Color { get; private set; }
        public DateTime ProductonDate { get; private set; }
        public CarsStatusEnum Status { get; private set; }
        public DateTime RegistredAt { get; private set; }

        public void Update(string color, decimal price)
        {
            Color = color;
            Price = price;
        }

        public void SetAsSuspended()
        {
            Status = CarsStatusEnum.Suspended;
        }
    }
}
