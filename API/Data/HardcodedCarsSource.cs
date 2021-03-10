using System;
using System.Collections.Generic;
using System.Linq;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class HardcodedCarsSource : ICarsSource
    {
        public IQueryable<Car> GetCars()
        {
            var cars = new List<Car>
            {
                new Car
                {
                    CarId = 1,
                    ModelName = "X6",
                    Received = new DateTime(2018, 2, 1),
                    Released = new DateTime(2016, 2, 1),
                    Type = new CarType{CarTypeId = 1, Name = "SUV"},
                    Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
                },
                new Car
                {
                    CarId = 2,
                    ModelName = "X3",
                    Received = new DateTime(2020, 1, 1),
                    Released = new DateTime(2019, 2, 1),
                    Type = new CarType{CarTypeId = 1, Name = "SUV"},
                    Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
                },
                new Car
                {
                    CarId = 3,
                    ModelName = "6 Gran Coupe",
                    Received = new DateTime(2015, 1, 1),
                    Released = new DateTime(2014, 2, 1),
                    Type = new CarType{CarTypeId = 2, Name = "Coupe"},
                    Manufacturer = new Manufacturer{ManufacturerId = 1, Name = "BMW"}
                },
                new Car
                {
                    CarId = 4,
                    ModelName = "Golf",
                    Received = new DateTime(2017, 1, 1),
                    Released = new DateTime(2015, 2, 1),
                    Type = new CarType{CarTypeId = 3, Name = "Hatchback"},
                    Manufacturer = new Manufacturer{ManufacturerId = 2, Name = "Volkswagen"}
                },
                new Car
                {
                    CarId = 5,
                    ModelName = "Passat",
                    Received = new DateTime(2014, 1, 1),
                    Released = new DateTime(2010, 2, 1),
                    Type = new CarType{CarTypeId = 4, Name = "Combi"},
                    Manufacturer = new Manufacturer{ManufacturerId = 2, Name = "Volkswagen"}
                },
                new Car
                {
                    CarId = 6,
                    ModelName = "Cayenne",
                    Received = new DateTime(2020, 1, 1),
                    Released = new DateTime(2017, 2, 1),
                    Type = new CarType{CarTypeId = 1, Name = "SUV"},
                    Manufacturer = new Manufacturer{ManufacturerId = 3, Name = "Porsche"}
                }
            };
            
            return cars.AsQueryable();
        }
    }
}