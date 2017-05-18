namespace Cars.ConsoleApplication.Factories
{
    using Models;
    using Interfaces;

    public class UserFactory : IUserFactory
    {
        public User CreateUser(string name, int age)
        {
            return new User
            {
                Name =  name,
                Age = age
            };
        }
    }
}