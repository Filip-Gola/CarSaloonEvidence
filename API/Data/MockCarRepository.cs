using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class MockCarRepository //: ICarRepository
    {
        private readonly ICarsSource _carsSource;
        public MockCarRepository(ICarsSource carsSource)
        {
            _carsSource = carsSource;

        }
        public Car GetCarById(int carId)
        {
            return _carsSource.GetCars().FirstOrDefault(car => car.CarId == carId);
        }

        public IEnumerable<Car> GetCars()
        {
            return _carsSource.GetCars();
        }
        
        public  IEnumerable<Car> GetCarsByQuery(QueryParams queryParams)
        {
            var query = _carsSource.GetCars();

            if (!String.IsNullOrWhiteSpace(queryParams.ModelName))
            {
                query = query.Where(x => x.ModelName.ToLower() == queryParams.ModelName.ToLower());
            }

            if (!String.IsNullOrWhiteSpace(queryParams.ManufacturerName))
            {
                query = query.Where(x => x.Manufacturer.Name.ToLower() == queryParams.ManufacturerName.ToLower());
            }

            if (!String.IsNullOrWhiteSpace(queryParams.CarTypeName))
            {
                query = query.Where(x => x.Type.Name.ToLower() == queryParams.CarTypeName.ToLower());
            }

            if (queryParams.Received != null)
            {
                query = query.Where(x => x.Received >= queryParams.Received);
            }

            if (queryParams.Released != null)
            {
                query = query.Where(x => x.Released >= queryParams.Released);
            }

            return query.ToList();
        }
    }
}