using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdAsync(int carId);
        Task<IEnumerable<Car>> GetCarsAsync();
        Task<IEnumerable<Car>> GetCarsByManufacturerIdAsync(int manufacturerId);
        Task<IEnumerable<Car>> GetCarsByManufacturerNameAsync(string manufacturerName);
        Task<IEnumerable<Car>> GetCarsByManufacturerIdAndCarTypeIdAsync(int manufacturerId, int carTypeId);
        Task<IEnumerable<Car>> GetCarsByManufacturerIdAndDateReceivedAsync(int manufacturerId, DateTime dateReceived);
        Task<IEnumerable<Car>> GetCarsByManufacturerIdAndDateReleasedAsync(int manufacturerId, DateTime dateReleased);
    }
}