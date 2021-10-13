using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "7EK77H.24", "Vlad");
            car.DoorsOpened += OnDoorsOpened;
            //Or Lambda
            //car.DoorsOpened += (arguments if have) => { some logic };
            
            car.DoorsClosed += (object sender, CarEventArgs e) => 
            { if (sender is Car) { Console.WriteLine($"Doors in {((Car)sender).Mark} " +
                $"has been closed!"); } };
            
            car.OpenDoors();
            car.CloseDoors();
            Console.ReadLine();
            
        }

        static void OnDoorsOpened()
        {
            Console.WriteLine("Doors has been opened!");
        }
    }
}
