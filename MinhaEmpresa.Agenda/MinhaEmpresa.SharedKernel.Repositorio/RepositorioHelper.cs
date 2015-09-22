using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.SharedKernel.Dominio.Repositorio;

namespace MinhaEmpresa.SharedKernel.Repositorio
{
    public class RepositorioHelper: IRepositorioHelper
    {
        public IRepositorioSessao AbrirSessao()
        {
            return new RepositorioSessao(NHibernateHelper.OpenSession());
        }
    }
}
