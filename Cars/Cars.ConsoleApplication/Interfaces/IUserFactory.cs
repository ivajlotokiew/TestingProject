namespace Cars.ConsoleApplication.Interfaces
{
    using Models;

    public interface IUserFactory
    {
        User CreateUser(string name, int age);
    }
}