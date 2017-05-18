namespace Cars.ConsoleApplication.Repositories
{
    using Models;
    using Interfaces;
    using Data;

    public class UserRepository : IUserRepository
    {
        private CarsContext context;

        public UserRepository(CarsContext context)
        {
            this.context = context;
        }

        public void Add(User user)
        {
            this.context.Users.Add(user);
            this.context.SaveChanges();
        }

        public void Remove(User user)
        {
            this.context.Users.Remove(user);
            this.context.SaveChanges();
        }
    }
}