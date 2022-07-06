using Carro.Core.Interface;
using Carro.Domain;
using Carro.Repository.Interface;
using System;

namespace Carro.Core
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car CreateCar(Car car)
        {
            throw new NotImplementedException();
        }

        public string DeleteCar(string carKey)
        {
            throw new NotImplementedException();
        }

        public Car GetCarByKey(string carKey)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public Car UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
