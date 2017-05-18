namespace Cars.Tests.Repositories
{
    using ConsoleApplication.Interfaces;
    using ConsoleApplication.Repositories;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System.Linq;

    [TestClass]
    public class UnitTest1
    {
        private CarsContext context;
        private ICarRepository carRepository;

        [TestInitialize]
        public void TestInitializa()
        {
            this.context = new CarsContext();
            this.carRepository = new CarRepository(this.context);
        }

        [TestMethod]
        public void AddMethod_AddedCarInDB_ShouldIncreaseCount()
        {
            //Arrange
            var someCar = new Car
            {
                Model = "Mazda",
                Price = 222.00M
            };

            //Act
            var carsCount = this.context.Cars.Count();
            this.carRepository.Add(someCar);

            //Assert
            Assert.AreEqual(++carsCount, this.context.Cars.Count());
        }
    }
}