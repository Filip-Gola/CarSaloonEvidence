using API.Entities;
using CsvHelper.Configuration;

namespace API.Mappers
{
    public class CarMap : ClassMap<Car>
    {
        public CarMap()
        {
            Map(m => m.CarId).Name("carId");
            Map(m => m.ModelName).Name("modelName");
            Map(m => m.Received).Name("received");
            Map(m => m.Released).Name("released");
            Map(m => m.Type.CarTypeId).Name("type/carTypeId");
            Map(m => m.Type.Name).Name("type/name");
            Map(m => m.Manufacturer.ManufacturerId).Name("manufacturer/manufacturerId");
            Map(m => m.Manufacturer.Name).Name("manufacturer/name");
        }
    }
}