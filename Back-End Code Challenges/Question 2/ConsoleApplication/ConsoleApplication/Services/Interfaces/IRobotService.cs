using ConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Services.Interfaces
{
    public interface IRobotService
    {
        RobotModel BuildRobotDog(IEnumerable<PartModel> parts);
        RobotModel BuildRobotCat(IEnumerable<PartModel> parts);
        RobotModel BuildRobotDrone(IEnumerable<PartModel> parts);
        RobotModel BuildRobotCar(IEnumerable<PartModel> parts);
    }
}
