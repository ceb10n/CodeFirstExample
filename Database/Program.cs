using Data.Context;
using Domain.Entities;
using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CodeFirstExampleContext();
            context.Database.Delete();
            context.Database.CreateIfNotExists();

            var brazil = new Country
            {
                Iso = "BR",
                Name = "Brasil"
            };

            var saoPaulo = new State
            {
                Country = brazil,
                CountryIso = brazil.Iso,
                UF = "SP",
                Name = "São Paulo"
            };

            var saoCaetano = new City
            {
                State = saoPaulo,
                StateId = saoPaulo.Id,
                Latitude = "",
                Longitude = "",
                Name = "São Caetano"
            };

            var person = new Person
            {
                Email = "novapessoa@email.com",
                Name = "Novo"
            };

            var teacher = new Teacher
            {
                Name = "Professor",
                Email = "professor@escola.com.br",
                HireDate = DateTime.Now,
                Adress = new Adress
                {
                    City = saoCaetano,
                    Complement = "Apto 222",
                    District = "Perdizes",
                    Street = "Rua abc",
                    Number = "222",
                    ZipCode = "05555552"
                }
            };

            var student = new Student
            {
                Name = "Student",
                Registration = "1234567"
            };

            context.Countries.Add(brazil);
            context.States.Add(saoPaulo);
            context.Cities.Add(saoCaetano);
            context.People.Add(person);
            context.Teachers.Add(teacher);
            context.Students.Add(student);

            context.SaveChanges();
            
            foreach (var p in context.People)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Possui Endereço: " + (p.AdressId.HasValue != false));
                Console.WriteLine();
            }

            foreach (var p in context.Students)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Matrícula: " + p.Registration);
                Console.WriteLine("Possui Endereço: " + (p.AdressId.HasValue != false));
                Console.WriteLine();
            }

            foreach (var p in context.Teachers)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Admitido em: " + p.HireDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Possui Endereço: " + (p.AdressId.HasValue != false));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
