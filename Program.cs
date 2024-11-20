using System.Drawing;

namespace PoleProstokata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Prostokat prostokat = new Prostokat();

                prostokat.ReadData();
                prostokat.ProcessData();
                prostokat.ShowResults();

                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                Console.ReadKey();
            }
        }
    }
}
