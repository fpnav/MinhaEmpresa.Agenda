using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.Agenda.Dominio.ValueObjects
{
    public class User : IAggregateRoot
    {
        public User(string userName)
        {
            UserName = userName;
        }

        public int Id { get; private set; }

        public string UserName { get; private set; }

        public Address Address { get; private set; }

        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
        }

        public void CreateNewAddress(string street1, string street2, string city, string region, string country, string postalCode)
        {
            Address = new Address(
              street1, street2,
              city, region,
              country, postalCode);
        }

        //Just for NHibernate
        public User()
        {
            
        }
    }
}
