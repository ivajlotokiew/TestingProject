namespace Cars.ConsoleApplication.Repositories
{
    using Interfaces;
    using Models;
    using Data;

    public class CarRepository : ICarRepository
    {
        private CarsContext context;

        public CarRepository(CarsContext context)
        {
            this.context = context;
        }

        public void Add(Car car)
        {
            this.context.Cars.Add(car);
            this.context.SaveChanges();
        }

        public void Remove(Car car)
        {
            this.context.Cars.Remove(car);
            this.context.SaveChanges();
        }
    }
}