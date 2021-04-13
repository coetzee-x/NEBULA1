using ConsoleApplication.Models;
using ConsoleApplication.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplication.Services
{
    public class PartsService : IPartsService
    {
        public IEnumerable<PartModel> GetParts(Enum partType)
        {
            throw new NotImplementedException();
        }
    }
}
