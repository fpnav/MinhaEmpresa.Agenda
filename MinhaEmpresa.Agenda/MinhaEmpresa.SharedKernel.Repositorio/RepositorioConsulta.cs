using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;
using MinhaEmpresa.SharedKernel.Dominio.Repositorio;
using NHibernate;
using NHibernate.Linq;

namespace MinhaEmpresa.SharedKernel.Repositorio
{

    /// <summary>
    /// Implementação de cada um dos métodos de .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositorioConsulta<T> : IRepositorioConsulta<T> where T : IEntidade
    {
        protected ISession Sessao { get; set; }

        public RepositorioConsulta(ISession sessao)
        {
            Sessao = sessao;
        }

        public T Retorna(object id)
        {
            return Sessao.Get<T>(id);
        }

        public IQueryable<T> Consulta()
        {
            return Sessao.Query<T>();
        }

        public IQueryable<T> Consulta(Expression<Func<T, bool>> @where)
        {
            return Sessao.Query<T>().Where(where);
        }

        public IList<T> Consulta(string comandoHql)
        {
            return Sessao.CreateQuery(comandoHql).List<T>().ToList();
        }

    }

}