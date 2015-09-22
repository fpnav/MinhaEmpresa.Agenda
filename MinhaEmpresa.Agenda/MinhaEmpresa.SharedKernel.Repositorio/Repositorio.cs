using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using MinhaEmpresa.SharedKernel.Dominio.Repositorio;
using NHibernate;

namespace MinhaEmpresa.SharedKernel.Repositorio
{
    public class Repositorio<T> : RepositorioConsulta<T>, IRepositorio<T> where T : IAggregateRoot
    {
        public Repositorio(ISession sessao)
            : base(sessao)
        {
        }

        public void Inclui(T entidade)
        {
            Sessao.Save(entidade);
        }

        public void Altera(T entidade)
        {
            Sessao.Update(entidade);
        }

        public void Salva(T entidade)
        {
            Sessao.SaveOrUpdate(entidade);
        }

        public void Exclui(T entidade)
        {
            Sessao.Delete(entidade);
        }
    }
}
