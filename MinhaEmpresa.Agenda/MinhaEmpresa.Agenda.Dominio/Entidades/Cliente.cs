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
        public bool ClienteVip()
        {
            return Ativo && DateTime.Now.Year - DataCadastro.Year >= 3;
        }

    }
}