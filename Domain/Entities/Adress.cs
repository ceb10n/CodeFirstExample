using System;

namespace Domain.Entities
{
    public class Adress
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string ZipCode { get; set; }
        public Guid? CityId { get; set; }
        public virtual City City { get; set; }
    }
}
