using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class JsonCarsSource : ICarsSource
    {
        public IQueryable<Car> GetCars()
        {
            var filePath = "C:\\Users\\filipgol\\Documents\\Learning\\CarSaloonEvidence\\API\\Data\\cars.json";

            var jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive =  true
            };

            var cars = JsonSerializer.Deserialize<List<Car>>(jsonString, options);
            
            return cars.AsQueryable();
        }
    }
}