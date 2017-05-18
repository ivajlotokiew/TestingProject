namespace Cars.ConsoleApplication.Interfaces
{
    using Cars.Models;

    public interface ICarRepository
    {
        void Add(Car car);

        void Remove(Car car);
    }
}
