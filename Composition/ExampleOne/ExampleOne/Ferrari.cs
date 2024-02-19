namespace ExampleOne
{
    public class Ferrari : Car
    {
        public int TotalSeats { get; set; }
        public string Model { get; set; }

        public void CarInfo()
        {
            Engine engine = new Engine();
            Console.WriteLine($"Car Name: {Name}" +
                              $"\nCar Colour: {Colour}" +
                              $"\nCar Model: {Model}" +
                              $"\nTotal Seats: {TotalSeats}");
            engine.EngineInfo();
        }
    }
}
