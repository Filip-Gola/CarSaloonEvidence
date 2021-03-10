using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdAsync(int carId);
        Task<IEnumerable<Car>> GetCarsAsync();
        Task<IEnumerable<Car>> GetCarsByQuery(QueryParams queryParams);
    }
}