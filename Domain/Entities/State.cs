using System;

namespace Domain.Entities
{
    public class State
    {
        public Guid Id { get; set; }
        public string UF { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public virtual Country Country { get; set; }
    }
}
