using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilforhandlerParProgrammering
{
    public class Customer
    {
        public string Name { get; set; }
        public Car OwnedCar { get; set; }

        public Customer(string name, Car ownedCar)
        {
            Name = name;
            OwnedCar = ownedCar;
        }
    }
}
