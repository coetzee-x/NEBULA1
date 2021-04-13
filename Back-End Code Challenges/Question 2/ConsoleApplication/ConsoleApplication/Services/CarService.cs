using ConsoleApplication.Models;
using ConsoleApplication.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplication.Services
{
    public class CarService : ICarService
    {
        public CarModel BuildCar(IEnumerable<PartModel> parts)
        {
            throw new NotImplementedException();
        }
    }
}
