using ConsoleApplication.Models;
using ConsoleApplication.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Factory
    {
        private readonly IRobotService _robotService;
        private readonly IPartsService _partsService;
        private readonly ICarService _carService;

        /// <summary>
        /// In this constructor we can use dependency injection to instantiate the services.
        /// </summary>
        /// <param name="robotService"></param>
        /// <param name="partsService"></param>
        /// <param name="carService"></param>
        public Factory(IRobotService robotService, IPartsService partsService, ICarService carService)
        {
            _robotService = robotService;
            _partsService = partsService;
            _carService = carService;
        }

        /// <summary>
        /// Builds a robot of a specific type.
        /// </summary>
        /// <param name="robotType"></param>
        /// <returns></returns>
        public RobotModel BuildRobot(RobotTypeEnum robotType)
        {
            switch (robotType) 
            {
                case RobotTypeEnum.RoboticDog:
                    return _robotService.BuildRobotDog(GetRobotPartsFor(robotType));
                case RobotTypeEnum.RoboticCat:
                    return _robotService.BuildRobotCat(GetRobotPartsFor(robotType));
                case RobotTypeEnum.RobotocDrone:
                    return _robotService.BuildRobotDrone(GetRobotPartsFor(robotType));
                default:
                    return _robotService.BuildRobotCar(GetRobotPartsFor(robotType));
            }
        }

        /// <summary>
        /// Builds a car of a specific type.
        /// </summary>
        /// <param name="carType"></param>
        /// <returns></returns>
        public CarModel BuildCar(CarTypeEnum carType)
        {
            return _carService.BuildCar(GetCarPartsFor(carType));
        }

        private List<PartModel> GetRobotPartsFor(RobotTypeEnum robotType)
        {
            return _partsService.GetParts(robotType).ToList();
        }

        private List<PartModel> GetCarPartsFor(CarTypeEnum carType)
        {
            return _partsService.GetParts(carType).ToList();
        }
    }
}
