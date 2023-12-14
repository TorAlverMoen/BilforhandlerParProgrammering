namespace BilforhandlerParProgrammering
{
    internal class Program
    {
        static CarDealership dealership = new();

        static void Main(string[] args)
        {
            dealership.AddCar(new Car("Toyota Yaris", "2010", "888555", "1000"));
            dealership.AddCar(new Car("BMW i3", "2016", "505050", "500"));

            Menu();
            dealership.ShowCars();
        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Show cars");
                Console.WriteLine("2. Add new car");
                Console.WriteLine("3. Sell car");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        dealership.ShowCars();
                        dealership.FindMilage();
                        break;
                    case "2":
                        dealership.AddNewCar();
                        break;
                    case "3":
                        dealership.ShowCars();
                        dealership.SellCar();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }


    }
}
