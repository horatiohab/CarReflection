using System;
using System.Globalization;

namespace CarReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lotusSeven = new Car("Lotus", "Seven", "450TK3", 1957, 19995.95);

            Console.WriteLine(lotusSeven.GetValue().ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(lotusSeven.GetYear());
            Console.WriteLine(lotusSeven);
            Console.ReadLine();
        }
    }
}
