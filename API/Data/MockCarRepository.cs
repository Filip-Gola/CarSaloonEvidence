using System;
using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public class MockCarRepository //: ICarRepository
    {
        public Car GetCarById(int carId)
        {
            return  listOfCars.FirstOrDefault(car => car.CarId == carId);
        }

        public IEnumerable<Car> GetCars()
        {
            return listOfCars.ToList();
        }

        public IEnumerable<Car> GetCarsByManufacturerId(int manufacturerId)
        {
            return listOfCars.Where(car => car.Manufacturer.ManufacturerId == manufacturerId).ToList();
        }

        public IEnumerable<Car> GetCarsByManufacturerIdAndCarTypeId(int manufacturerId, int carTypeId)
        {
            return listOfCars.Where(car => car.Manufacturer.ManufacturerId == manufacturerId &&
                                    car.Type.CarTypeId == carTypeId).ToList();
        }

        public IEnumerable<Car> GetCarsByManufacturerIdAndDateReceived(int manufacturerId, DateTime dateReceived)
        {
            return listOfCars.Where(car => car.Manufacturer.ManufacturerId == manufacturerId &&
                                    car.Recieved >= dateReceived).ToList();
        }

        public IEnumerable<Car> GetCarsByManufacturerIdAndDateReleased(int manufacturerId, DateTime dateReleased)
        {
            return listOfCars.Where(car => car.Manufacturer.ManufacturerId == manufacturerId &&
                                    car.Released >= dateReleased).ToList();
        }

        public IEnumerable<Car> GetCarsByManufacturerName(string manufacturerName)
        {
            return listOfCars.Where(car => car.Manufacturer.Name.ToLower() == manufacturerName.ToLower()).ToList();
        }

        private List<Car> listOfCars = new List<Car> // Mocked data
        {
            new Car
            {
                CarId = 1,
                ModelName = "X6",
                Recieved = new DateTime(2018, 2, 1),
                Released = new DateTime(2016, 2, 1),
                Type = new CarType{CarTypeId = 1, Name = "SUV"},
                Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
            },
            new Car
            {
                CarId = 2,
                ModelName = "X3",
                Recieved = new DateTime(2020, 1, 1),
                Released = new DateTime(2019, 2, 1),
                Type = new CarType{CarTypeId = 1, Name = "SUV"},
                Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
            },
            new Car
            {
                CarId = 3,
                ModelName = "6 Gran Coupe",
                Recieved = new DateTime(2015, 1, 1),
                Released = new DateTime(2014, 2, 1),
                Type = new CarType{CarTypeId = 2, Name = "Coupe"},
                Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
            },
            new Car
            {
                CarId = 4,
                ModelName = "Golf",
                Recieved = new DateTime(2017, 1, 1),
                Released = new DateTime(2015, 2, 1),
                Type = new CarType{CarTypeId = 3, Name = "Hatchback"},
                Manufacturer = new Manufacturer{ManufacturerId = 2, Name = "Volkswagen"}
            },
            new Car
            {
                CarId = 5,
                ModelName = "Passat",
                Recieved = new DateTime(2014, 1, 1),
                Released = new DateTime(2010, 2, 1),
                Type = new CarType{CarTypeId = 4, Name = "Combi"},
                Manufacturer = new Manufacturer{ManufacturerId = 2, Name = "Volkswagen"}
            },
            new Car
            {
                CarId = 6,
                ModelName = "Cayenne",
                Recieved = new DateTime(2020, 1, 1),
                Released = new DateTime(2017, 2, 1),
                Type = new CarType{CarTypeId = 1, Name = "SUV"},
                Manufacturer = new Manufacturer{ManufacturerId = 3, Name = "Porsche"}
            },
        };
    }
}