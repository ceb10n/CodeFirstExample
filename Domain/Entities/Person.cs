using System;

namespace Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nick { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? Birth { get; set; }
        public DateTime Created { get; set; }
        public string NationalityId { get; set; }
        public Guid? AdressId { get; set; }
        public virtual Country Nationality { get; set; }
        public virtual Adress Adress { get; set; }
    }
}
