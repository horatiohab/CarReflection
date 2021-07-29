using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReflection
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int Year { get; set; }
        public double CurrentValue { get; set; }

        public Car(string make, string model, string registration, int year, double currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            CurrentValue = currentValue;
        }

        public double GetValue()
        {
            return CurrentValue;
        }

        public int GetYear()
        {
            return Year;
        }

        public override string ToString()
        {
            return $"The {GetYear()} {Make} {Model}, with the registraion of {Registration}, currently costs {GetValue().ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
