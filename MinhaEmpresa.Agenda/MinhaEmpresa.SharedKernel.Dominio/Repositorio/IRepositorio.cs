using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEmpresa.SharedKernel.Dominio.Repositorio
{
    /// <summary>
    /// Interface que herda de IRepositorioConsulta, pois além das consultas também possibilita persistência.
    /// Segundo o DDD nem toda Entidade pode ser diretamente persistida. Somente os AggregateRoots é que podem ser 
    /// persistidos e esta interface é uma forma de garantirmos essa regra/segurança.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositorio<T> : IRepositorioConsulta<T> where T : IAggregateRoot
    {
        void Inclui(T entidade);
        void Altera(T entidade);
        void Salva(T entidade);
        void Exclui(T entidade);
    }
}
