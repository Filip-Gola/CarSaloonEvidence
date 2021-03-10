using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using API.Entities;
using API.Interfaces;
using API.Mappers;
using CsvHelper;

namespace API.Data
{
    public class CsvCarsSource : ICarsSource
    {
        public IQueryable<Car> GetCars()
        {
            List<Car> cars = new List<Car>(){};

            var filePath = "C:\\Users\\filipgol\\Documents\\Learning\\CarSaloonEvidence\\API\\Data\\cars.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<CarMap>();
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    // some error catching should be added in case of 
                    // wrong data format or other exceptions
                    var record = csv.GetRecord<Car>();
                    cars.Add(record);    
                }  
            }
            return cars.AsQueryable();
        }
    }
}