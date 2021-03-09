using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using API.Entities;
using API.Interfaces;
using API.Mappers;

namespace API.Data
{
    public class JsonCarsSource : ICarsSource
    {
        public IEnumerable<Car> GetCars()
        {
            var filePath = "C:\\Users\\filipgol\\Documents\\Learning\\CarSaloonEvidence\\API\\Data\\cars.json";

            var jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive =  true
            };

            var cars = JsonSerializer.Deserialize<List<Car>>(jsonString, options);
            
            return cars;
        }
    }
}