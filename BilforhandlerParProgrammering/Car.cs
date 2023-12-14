using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilforhandlerParProgrammering
{
    public class Car
    {
        public string Brand {  get; set; }
        public string YearModel { get; set; }
        public string RegistrationNumber { get; set; }
        public string Mileage {  get; set; }

        public Car(string brand, string yearModel, string registrationNumber, string mileage)
        {
            Brand = brand;
            YearModel = yearModel;
            RegistrationNumber = registrationNumber;
            Mileage = mileage;
        }

    }
}
