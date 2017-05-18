namespace Cars.ConsoleApplication.Interfaces
{
    using Models;

    public interface IUserRepository
    {
        void Add(User user);

        void Remove(User user);
    }
}