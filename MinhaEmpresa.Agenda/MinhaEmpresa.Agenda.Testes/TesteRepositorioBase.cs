using MinhaEmpresa.SharedKernel.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.SharedKernel.Repositorio;

namespace MinhaEmpresa.Agenda.Testes
{
    public class TesteRepositorioBase
    {
        protected IRepositorioHelper Helper;

        public TesteRepositorioBase()
        {
            Helper = new RepositorioHelper();
        }
    }
}
