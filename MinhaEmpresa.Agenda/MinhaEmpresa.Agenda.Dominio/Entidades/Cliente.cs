using System;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.Agenda.Dominio.Entidades
{
    public class Cliente : Entidade<string>, IAggregateRoot
    {
        public int Id { get; set; }

        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string Email { get; set; }
        public virtual bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        //Comportamento que depois será abstraido com Services
        public bool ClienteVip()
        {
            return Ativo && DateTime.Now.Year - DataCadastro.Year >= 3;
        }

    }
}