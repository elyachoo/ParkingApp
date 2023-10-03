namespace ParkingApp
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();

            Car car1 = new Car()
            {
                Brand = "Tesla",
                Model = "Model 3",
                Color = "Grey",
                Number = "7VIP583",
                ArrivalTime = DateTime.Now.AddHours(-3),
                DepartureTime = DateTime.Now.AddHours(1)

            };

            Car car2 = new Car()
            {
                Brand = "Dodge",
                Model = "Ram",
                Color = "Black",
                Number = "5RTW387",
                ArrivalTime = DateTime.Now.AddHours(2),
                DepartureTime = DateTime.Now.AddHours(3)
            };

            parking.AddCar(car1);
            parking.AddCar(car2);

            parking.DisplayCars();

            Console.WriteLine($"{car1.Brand} {car1.Number} drove away.");
            parking.RemoveCar(car1);

            parking.DisplayCars();
        }
    }
}