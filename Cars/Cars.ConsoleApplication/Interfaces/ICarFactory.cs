namespace Cars.ConsoleApplication.Interfaces
{
    using Models;

    public interface ICarFactory
    {
        Car CreateCar(string model, decimal price);
    }
}