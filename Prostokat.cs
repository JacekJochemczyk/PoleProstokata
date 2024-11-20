using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleProstokata
{
    public class Prostokat
    {
        private double a; 
        private double b; 
        private double surfaceArea;

        public void ReadData()
        {
            Console.Write("Podaj długość boku a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość boku b: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void ProcessData()
        {
            surfaceArea = a * b;
        }

        public void ShowResults()
        {
            Console.WriteLine("Wyniki:");
            Console.WriteLine($"Bok a: {a:F2}");
            Console.WriteLine($"Bok b: {b:F2}");
            Console.WriteLine($"Pole prostokąta: {surfaceArea:F2}");
        }
    }
}
