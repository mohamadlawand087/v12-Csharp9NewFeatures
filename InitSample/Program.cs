using System;

namespace InitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c1 = new Car()
            {
                Brand = "Mercedes",
                Color = "Black"
            };

            var c2 = new Car()
            {
                Brand = "BMW",
                Color = "White"
            };
           
            // c1.Color = "Grey";

            //c1.Color = "Red";

            Console.WriteLine($"Brand: {c1.Brand} - Color: {c1.Color}");
            Console.WriteLine($"Brand: {c2.Brand} - Color: {c2.Color}");
        }
    }

    public class Car
    {
        public string Brand { get; init; }
        public string Color { get; init; }

        // public Car(string brand, string color)
        // {
        //     Brand = brand;
        //     Color = color;
        // }
    }
}
