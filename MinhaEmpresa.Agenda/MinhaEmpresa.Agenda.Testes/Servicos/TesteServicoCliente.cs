using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinhaEmpresa.Agenda.Dominio.Entidades;
using MinhaEmpresa.Agenda.Dominio.Servicos;

namespace MinhaEmpresa.Agenda.Testes.Servicos
{
    [TestClass]
    public class TesteServicoCliente : TesteRepositorioBase
    {
        [TestInitialize]
        public void SetupTest()
        {
            using (var sessao = Helper.AbrirSessao())
            {
                sessao.IniciaTransacao();
                var repositorio = sessao.GetRepositorio<Cliente>();
                repositorio.Inclui(
                    new Cliente
                        {
                            Id = 1,
                            Ativo = true,
                            Email = "teste@univem.edu.br",
                            DataCadastro = DateTime.Now,
                            Nome = "Asdrubal",
                            Sobrenome = "de Freitas"
                        }
                    );
                sessao.ComitaTransacao();
            }
        }


        [TestMethod]
        public void PodeUtilizarServicoCliente()
        {
            using (var sessao = Helper.AbrirSessao())
            {
                var repositorio = sessao.GetRepositorioConsulta<Cliente>();
                var teste = repositorio.Retorna(1);

                var testeServico = new ServicoCliente();
                var valida = testeServico.VerificaSeClienteVipEEmailNaoNulo(teste);

                Assert.AreEqual(valida, true);
            }
        }

    }
}
