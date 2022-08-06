// Uncompleted :(


using System.Xml.Linq;

namespace DotNetCollections
{
    public class Task
    {
        private static void ListCars()
        {
            var cars = new List<Engine>
         {
             { new Engine() { Name = "Truck", Power = 550, Volume = 2, Type = "PX-9", SerialNumber = "PJ12345U123456P"}},
             { new Engine() { Name = "Passenger car", Power = 200, Volume = 3, Type = "VEE", SerialNumber = "4MG12345"}},
             { new Engine() { Name = "Bus", Power = 380, Volume = 4, Type = "CNG", SerialNumber = "1200cc"}},
             { new Engine() { Name = "Scooter", Power = 100, Volume = 1, Type = "CVT", SerialNumber = "157QMJ"}},
             { new Chassis() { Name = "Truck", Wheels = 100, Number = 1, PermissibleLoad = "CVT" }},
             { new Chassis() { Name = "Passenger car", Wheels = 100, Number = 1, PermissibleLoad = "CVT"}},
             { new Chassis() { Name = "Bus",Wheels = 100, Number = 1, PermissibleLoad = "CVT" }},
             { new Chassis() { Name = "Scooter", Wheels = 100, Number = 1, PermissibleLoad = "CVT"}},
             { new Transmission() { Name = "Truck", Gears= 100, Type= 1, Manufacturer= "CVT"}},
             { new Transmission() { Name = "Passenger car", Gears= 100, Type= 1, Manufacturer= "CVT"}},
             { new Transmission() { Name = "Bus", Gears= 100, Type= 1, Manufacturer= "CVT"}},
             { new Transmission() { Name = "Scooter",Gears= 100, Type= 1, Manufacturer= "CVT"}},
         };

            // Sort the cars by color alphabetically, and then by speed
            // in descending order.
            cars.Sort();

            // View all of the cars.
            foreach (Engine thisCar in cars)
            {
                Console.Write(thisCar.Volume.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();
            }
        }
        public class Engine : IComparable<Engine>
        {
            public string Name { get; set; }
            public double Power { get; set; }
            public double Volume { get; set; }
            public string Type { get; set; }
            public string SerialNumber { get; set; }

            public int CompareTo(Engine other)
            {
                int compare;
                compare = String.Compare(this.Type, other.Type, true);

                if (compare == 0)
                {
                    compare = this.Volume.CompareTo(other.Volume);
                    compare = -compare;
                }
                return compare;
            }
        }
        public class Chassis : IComparable<Chassis>
        {
            public string Name { get; set; }
            public double Wheels { get; set; }
            public double Number { get; set; }
            public string PermissibleLoad { get; set; }
        }
        public class Transmission : IComparable<Transmission>
        {
            public string Name { get; set; }
            public double Gears { get; set; }
            public double Type { get; set; }
            public string Manufacturer { get; set; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string str =
            @"<?xml version=""1.0""?>  
            <!-- comment at the root level -->  
            <Root>  
                <Child>Content</Child>  
            </Root>";
            XDocument doc = XDocument.Parse(str);
            Console.WriteLine(doc);
        }
    }
}
