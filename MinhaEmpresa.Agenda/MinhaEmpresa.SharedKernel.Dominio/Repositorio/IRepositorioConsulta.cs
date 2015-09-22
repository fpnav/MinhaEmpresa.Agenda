using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.SharedKernel.Dominio.Repositorio
{
    /// <summary>
    /// Interface que deverá ser implementada pela camada MinhaEmpresa.SharedKernel.Repositorio
    /// Esta permite que as classes "marcadas" que forem de fato uma Entidade poderão utilizá-la 
    /// para fazer as consultas para tal entidade.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositorioConsulta<T> where T : IEntidade
    {
        T Retorna(object id);
        IQueryable<T> Consulta();
        IQueryable<T> Consulta(Expression<Func<T, bool>> where);
        IList<T> Consulta(string comandoHql);
    }
}