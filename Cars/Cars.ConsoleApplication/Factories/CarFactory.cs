namespace Cars.ConsoleApplication.Factories
{
    using Models;
    using Interfaces;

    public class CarFactory : ICarFactory
    {
        public Car CreateCar(string model, decimal price)
        {
            return new Car()
            {
                Model = model,
                Price = price
            };
        }
    }
}