using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba7.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Job { get; set; }

        public int Width { get; set; }

        public int Weight { get; set; }

        public string Passport { get; set; }

        public int NationalityId { get; set; }

        public Nationality Nationality { get; set; }
    }
}