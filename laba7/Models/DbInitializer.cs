using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace laba7.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext db)
        {
            if (db.Nationalities.Any())
            {
                return;
            }

            db.Nationalities.Add(new Nationality() { Name = "Russian" });
            db.Nationalities.Add(new Nationality() { Name = "Bellarusian" });
            db.Nationalities.Add(new Nationality() { Name = "Poland" });
            db.Nationalities.Add(new Nationality() { Name = "USA" });

            db.SaveChanges();

            db.Customers.Add(new Customer() {
                FullName = "Vlad Pinchuk",
                Age = 20,
                Gender = "man",
                Job = "programmer",
                Width = 100,
                Weight = 100,
                Passport = "HB3463826",
                NationalityId = 1,
            });
            db.Customers.Add(new Customer()
            {
                FullName = "Pavel Stelmah",
                Age = 20,
                Gender = "man",
                Job = "programmer",
                Width = 120,
                Weight = 120,
                Passport = "HB346234326",
                NationalityId = 2,
            });
            db.Customers.Add(new Customer()
            {
                FullName = "Maria Skorb",
                Age = 45,
                Gender = "woman",
                Job = "programmer",
                Width = 300,
                Weight = 300,
                Passport = "HB344634826",
                NationalityId = 3,
            });
            db.Customers.Add(new Customer()
            {
                FullName = "Kostia Kulinkin",
                Age = 19,
                Gender = "man",
                Job = "programmer",
                Width = 50,
                Weight = 50,
                Passport = "HB3686773",
                NationalityId = 1,
            });
            db.Customers.Add(new Customer()
            {
                FullName = "Alexandr Schesnovich",
                Age = 22,
                Gender = "man",
                Job = "programmer",
                Width = 190,
                Weight = 190,
                Passport = "HB0978976",
                NationalityId = 4,
            });
            db.Customers.Add(new Customer()
            {
                FullName = "Dmitri Los",
                Age = 21,
                Gender = "man",
                Job = "programmer",
                Width = 10,
                Weight = 10,
                Passport = "HB1118976",
                NationalityId = 1,
            });

            db.SaveChanges();

            db.Services.Add(new Service()
            {
                Name = "Rings",
                Price = 10
            });
            db.Services.Add(new Service()
            {
                Name = "Angels",
                Price = 1000
            });
            db.Services.Add(new Service()
            {
                Name = "Roses",
                Price = 99
            });
            db.Services.Add(new Service()
            {
                Name = "Car",
                Price = 400
            });
            db.Services.Add(new Service()
            {
                Name = "Hors",
                Price = 200
            });
            db.Services.Add(new Service()
            {
                Name = "Husband",
                Price = 20000
            });

            db.SaveChanges();
        }
    }
}
