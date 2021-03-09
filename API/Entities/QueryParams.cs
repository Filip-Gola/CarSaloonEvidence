using System;

namespace API.Entities
{
    public class QueryParams
    {
        public string ModelName { get; set; }
        public DateTime? Received { get; set; }
        public DateTime? Released { get; set; }
        public string CarTypeName { get; set; }
        public string ManufacturerName { get; set; }

    }
}