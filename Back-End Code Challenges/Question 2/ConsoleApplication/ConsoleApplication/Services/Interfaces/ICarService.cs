using ConsoleApplication.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication.Services.Interfaces
{
    public interface ICarService
    {
        CarModel BuildCar(IEnumerable<PartModel> parts);
    }
}
