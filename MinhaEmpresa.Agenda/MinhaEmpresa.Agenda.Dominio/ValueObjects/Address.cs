using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEmpresa.Agenda.Dominio.ValueObjects
{
    public class Address
    {
        public Address(string street1, string street2, string city, string region, string country, string postalCode)
        {
            Street1 = street1;
            Street2 = street2;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
        }

        public string Street1 { get; private set; }
        public string Street2 { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }

    }

    
}
