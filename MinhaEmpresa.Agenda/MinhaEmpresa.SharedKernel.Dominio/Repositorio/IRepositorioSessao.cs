using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using MinhaEmpresa.SharedKernel.Dominio.Entidades;

namespace MinhaEmpresa.SharedKernel.Dominio.Repositorio
{
    public interface IRepositorioSessao : IDisposable
    {
        IRepositorioConsulta<T> GetRepositorioConsulta<T>() where T : IEntidade;
        IRepositorio<T> GetRepositorio<T>() where T : IAggregateRoot;
        void IniciaTransacao();
        void ComitaTransacao();
        void RollBackTransacao();
    }
}
