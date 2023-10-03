namespace ParkingApp
{
    class Parking
    {
        public List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
            Console.WriteLine("Car parked");
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
            car.DepartureTime = DateTime.Now;
        }
        public void DisplayCars()
        {
            Console.WriteLine("Cars in the parking:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color: {car.Color}, Number: {car.Number}, Arrival Time: {car.ArrivalTime}, Departure Time: {car.DepartureTime}");
            }
        }
    }
}