using System;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.Agenda.Dominio.Entidades
{
    public class Cliente : Entidade<string>
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        //Comportamento que depois será abstraido com Services
        public bool ClienteVip(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 3;
        }
    }
}