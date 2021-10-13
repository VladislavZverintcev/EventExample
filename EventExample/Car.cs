using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Car
    {
        public event Action DoorsOpened;
        public event EventHandler<CarEventArgs> DoorsClosed;

        public string Mark { get; set; }
        public string Number { get; set; }
        public string Owner { get; set; }
        public Car(string _mark, string _number, string _owner)
        {
            Mark = _mark;
            Number = _number;
            Owner = _owner;
        }
        public void OpenDoors()
        {
            DoorsOpened?.Invoke();
        }
        public void CloseDoors()
        {
            var eArgs = new CarEventArgs(Number, Owner);
            DoorsClosed?.Invoke(this, eArgs);
        }
    }
    public class CarEventArgs : EventArgs
    {
        public CarEventArgs(string _number, string _owner)
        {
            Number = _number;
            Owner = _owner;
        }
        public string Number { get; set; }
        public string Owner { get; set; }
    }
}
