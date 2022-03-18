using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }


        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            this.Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Mileage: {Mileage}";
        }

    }
}
