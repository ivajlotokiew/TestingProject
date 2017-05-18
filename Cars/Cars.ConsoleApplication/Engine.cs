namespace Cars.ConsoleApplication
{
    using Interfaces;

    public class Engine : IEngine
    {
        private ICarRepository carRepository;
        private IUserRepository userRepository;
        private IWrite writer;
        private IRead reader;
        private ICarFactory carFactory;
        private IUserFactory userFactory;

        public Engine(
            ICarRepository carRepository,
            IUserRepository userRepository,
            IWrite writer,
            IRead reader,
            ICarFactory carFactory,
            IUserFactory userFactory)
        {
            this.carRepository = carRepository;
            this.userRepository = userRepository;
            this.writer = writer;
            this.reader = reader;
            this.carFactory = carFactory;
            this.userFactory = userFactory;
        }

        public void Run()
        {
            while (true)
            {
                string[] line = reader.ReadLine().Split();
                string command = line[0];

                switch (command)
                {
                    case "AddCar":
                        this.AddCarMethod(line);
                        break;
                    case "AddUser":
                        this.AddUserMethod(line);
                        break;
                    case "End":
                        return;
                    default:
                        break;
                }
            }
        }

        private void AddUserMethod(string[] line)
        {
            string name = line[1];
            int age = int.Parse(line[2]);

            var user = this.userFactory.CreateUser(name, age);
            this.userRepository.Add(user);
        }

        private void AddCarMethod(string[] line)
        {
            string model = line[1];
            decimal price = decimal.Parse(line[2]);

            var car = this.carFactory.CreateCar(model, price);
            this.carRepository.Add(car);
        }
    }
}