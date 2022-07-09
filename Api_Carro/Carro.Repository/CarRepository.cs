using Carro.Domain;
using Carro.Repository.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly IMongoCollection<Car> _collectionCar;

        public CarRepository()
        {
            var client = new MongoClient("@Mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionCar = database.GetCollection<Car>("Car");
        }
        public Car CreateCar(Car car)
        {
            _collectionCar.InsertOne(car);

            return car;
        }

        public string DeleteCar(string carKey)
        {
            _collectionCar.DeleteOne(carKey);

            return carKey;
        }

        public Car GetCarByKey(string carKey)
        {
            var car = _collectionCar.Find(p => p.Key == carKey).FirstOrDefault();

            return car;
        }

        public List<Car> GetCars()
        {
            var cars = _collectionCar.Find(b => b.IsActive).ToList();

            return cars;
        }

        public Car UpdateCar(Car car)
        {
            _collectionCar.ReplaceOneAsync(c => c.Key == car.Key, car);

            return car;
        }
    }
}
