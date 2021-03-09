using System.Collections.Generic;
using API.Entities;

namespace API.Interfaces
{
    public interface ICarsSource
    {
        IEnumerable<Car> GetCars();
    }
}