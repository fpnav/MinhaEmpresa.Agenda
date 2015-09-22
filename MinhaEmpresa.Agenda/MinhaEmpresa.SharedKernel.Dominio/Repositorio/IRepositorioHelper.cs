using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEmpresa.SharedKernel.Dominio.Repositorio
{
    /// <summary>
    /// Interface responsável por definir a abertura da sessao do mecanismo de persistência
    /// Atentar que esta interface existe para mantermos um desacoplamento do mecanismo de persistência
    /// Caso necessite-se mudar o motor de persistência então todas as classes que utilizam da abertura de sessão
    /// continuarão a funcionar, pois estamos programando para sua interface, ou seja, para sua abstração.
    /// </summary>
    public interface IRepositorioHelper
    {
        IRepositorioSessao AbrirSessao();
    }
}
