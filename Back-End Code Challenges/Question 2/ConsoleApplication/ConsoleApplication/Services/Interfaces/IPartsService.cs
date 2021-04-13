using ConsoleApplication.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApplication.Services.Interfaces
{
    public interface IPartsService
    {
        IEnumerable<PartModel> GetParts(Enum partType);
    }
}
