using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEmpresa.SharedKernel.Dominio.Entidades
{
    /// <summary>
    /// Interface utilizada para identificar todas as Entidades da Aplicação.
    /// Porém, segundo o DDD, nem todas as Entidades devem ser persistidas, para isso usaremos os AggregateRoots
    /// 
    /// </summary>
    public interface IEntidade
    {
    }
}
