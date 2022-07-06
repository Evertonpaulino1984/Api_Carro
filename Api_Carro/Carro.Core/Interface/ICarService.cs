using Carro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Core.Interface
{
    public interface ICarService
    {
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        string DeleteCar(string carKey);
        Car GetCarByKey(string carKey);
        List<Car> GetCars();
    }
}
