using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilforhandlerParProgrammering
{
    public class CarDealership
    {
        public List<Car> cars = new();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void AddNewCar()
        {
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Year model: ");
            string year = Console.ReadLine();
            Console.Write("Registration number: ");
            string regNo = Console.ReadLine();
            Console.Write("Mileage: ");
            string milage = Console.ReadLine();
            AddCar(new Car(model, year, regNo, milage));
        }

        public List<Car> FindCars(Func<Car, bool> predicate)
        {
            return cars.Where(predicate).ToList();
        }

        public void FindMilage()
        {
            Console.Write("Enter mileage: ");
            int maxMilage = int.Parse(Console.ReadLine());
            List<Car> carByMilage = FindCars(car  => int.Parse(car.Mileage) <= maxMilage);

            Console.WriteLine($"\nCars with mileage less than or equal to {maxMilage}");
            foreach ( Car car in carByMilage )
            {
                Console.WriteLine($"{car.Brand} - {car.Mileage}");
            }
        }

        public void ShowCars()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"\n[{i + 1}]");
                Console.WriteLine($"Brand:        {cars[i].Brand}");
                Console.WriteLine($"Year:         {cars[i].YearModel}");
                Console.WriteLine($"Registration: {cars[i].RegistrationNumber}");
                Console.WriteLine($"Mileage:      {cars[i].Mileage}");
            }
        }

        public void UpdateCarList(Car car, Customer customer)
        {
            cars.Remove(car);
            customer.OwnedCar = car;
            Console.WriteLine($"Congrats, {customer.Name}! You now own {car.Brand}!");
        }

        public void SellCar()
        {
            Console.WriteLine("\nWhich car: ");
            int indexInput = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("What is the customers name?: ");
            string customerName = Console.ReadLine();
            UpdateCarList(cars[indexInput], new Customer(customerName, cars[indexInput]));
        }
    }
}
