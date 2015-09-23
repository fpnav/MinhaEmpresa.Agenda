using MinhaEmpresa.Agenda.Dominio.ValueObjects;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using System.Collections.Generic;

namespace MinhaEmpresa.Agenda.Dominio.Entidades
{
    public class User : IAggregateRoot
    {
        public User(string userName)
        {
            UserName = userName;
        }
        public int Id { get; private set; }
        public string UserName { get; private set; }
        
        //public Address Address { get; private set; }
        public IList<Address> Address { get; private set; }
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
        //Just for NHibernate
        public User()
        {   
        }
    }
}
