namespace Cars.ConsoleApplication
{
    using Data;
    using Factories;
    using Interfaces;
    using IO;
    using Repositories;

    public class StartUp
    {
        static void Main()
        {
            var context = new CarsContext();
            ICarRepository carRepository = new CarRepository(context);
            IUserRepository userRepository = new UserRepository(context);
            ICarFactory carFactory = new CarFactory();
            IUserFactory userFactory = new UserFactory();
            IWrite writer = new Write();
            IRead reader = new Read();

            IEngine engine = new Engine(carRepository, userRepository, writer, reader, carFactory, userFactory);

            engine.Run();
        }
    }
}