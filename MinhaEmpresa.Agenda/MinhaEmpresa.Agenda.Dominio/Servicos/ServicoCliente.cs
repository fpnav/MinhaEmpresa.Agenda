using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.Agenda.Dominio.Entidades;

namespace MinhaEmpresa.Agenda.Dominio.Servicos
{
    //Simulando um Servico de Domínio Complexo
    //que faz uma consulta por exemplo em mais de 1 entidade e centraliza as regras de negocio
    public class ServicoCliente
    {
        public ServicoCliente()
        {
            
        }

        public bool VerificaSeClienteVipEEmailNaoNulo(Cliente cliente)
        {
            //Simula uma regra de negócio complexa
            if (cliente.ClienteVip() && !string.IsNullOrEmpty(cliente.Email))
            {
                return true;
            }
            return false;
        }
    }
}
