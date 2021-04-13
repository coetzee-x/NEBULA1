using ConsoleApplication.Models;
using ConsoleApplication.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplication.Services
{
    public class RobotService : IRobotService
    {
        public RobotModel BuildRobotCar(IEnumerable<PartModel> parts)
        {
            throw new NotImplementedException();
        }

        public RobotModel BuildRobotCat(IEnumerable<PartModel> parts)
        {
            throw new NotImplementedException();
        }

        public RobotModel BuildRobotDog(IEnumerable<PartModel> parts)
        {
            throw new NotImplementedException();
        }

        public RobotModel BuildRobotDrone(IEnumerable<PartModel> parts)
        {
            throw new NotImplementedException();
        }
    }
}
