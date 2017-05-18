namespace Cars.Data
{
    using Interfaces;
    using Models;
    using Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private CarsContext context;
        private IRepository<Car> carsRepository;
        private IRepository<User> usersRepository;

        public UnitOfWork()
        {
            this.context = new CarsContext();
            this.carsRepository = new Repository<Car>(this.context.Cars);
            this.usersRepository = new Repository<User>(this.context.Users);
        }

        public IRepository<Car> CarsRepository
        {
            get
            {
                return this.carsRepository;
            }
        }

        public IRepository<User> UsersRepository
        {
            get
            {
                return this.usersRepository;
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}