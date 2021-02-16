using System;

namespace API.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public DateTime Recieved { get; set; }
        public DateTime Released { get; set; }
        public CarType Type { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}