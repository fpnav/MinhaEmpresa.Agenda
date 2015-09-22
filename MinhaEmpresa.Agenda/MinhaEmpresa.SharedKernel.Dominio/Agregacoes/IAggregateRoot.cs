using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.SharedKernel.Dominio.Agregacoes
{
    /// <summary>
    /// Entidade que nos permite "marcar/definir" como um AggregateRoot determinada Entidade.
    /// Por exemplo: somente algumas entidade é que poderão ser persistidas e para estas as fazemos implementar esta Interface
    /// </summary>
    public interface IAggregateRoot : IEntidade
    {
         
    }
}