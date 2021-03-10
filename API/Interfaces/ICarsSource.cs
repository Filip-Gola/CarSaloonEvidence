using System.Linq;
using API.Entities;

namespace API.Interfaces
{
    public interface ICarsSource
    {
        IQueryable<Car> GetCars();
    }
}