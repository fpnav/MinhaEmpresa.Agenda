using MinhaEmpresa.Agenda.Dominio.ValueObjects;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using System.Collections.Generic;

namespace MinhaEmpresa.Agenda.Dominio.Entidades
{
    public class User : IAggregateRoot
    {
        
        public int Id { get; private set; }
        public virtual string UserName { get; private set; }
        public virtual IList<Address> Address { get; private set; }
        
        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
        }
        public void CreateNewAddress(IList<Address> enderecos)
        {
            Address = new List<Address>();
            foreach (var endereco in enderecos)
            {
                Address.Add(endereco);
            }

        }

        public User(string userName)
        {
            UserName = userName;
        }
        //Just for NHibernate
        public User()
        {
        }
    }
}