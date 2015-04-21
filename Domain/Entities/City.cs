using System;

namespace Domain.Entities
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string County { get; set; }
        public Guid StateId { get; set; }
        public virtual State State { get; set; }
    }
}
