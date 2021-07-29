using System;
using CarReflection;
using Xunit;

namespace CarReflection.Tests
{
    public class BasicCarTests
    {
        [Fact]
        public void GetValueTest()
        {
            double value = 19995.95;

            Car lotusSeven = new Car("Lotus", "Seven", "450TK3", 1957, value);
            Assert.Equal(value, lotusSeven.GetValue());
        }

        [Fact]
        public void GetYearTest()
        {
            int year = 1957;

            Car lotusSeven = new Car("Lotus", "Seven", "450TK3", year, 19995.95);
            Assert.Equal(year, lotusSeven.GetYear());
        }

        [Fact]
        public void ToStringTest()
        {
            Car lotusSeven = new Car("Lotus", "Seven", "450TK3", 1957, 19995.95);
            Assert.Contains($"The 1957 Lotus Seven, with the registraion of 450TK3, currently costs £19,995.95", lotusSeven.ToString());
        }
    }
}