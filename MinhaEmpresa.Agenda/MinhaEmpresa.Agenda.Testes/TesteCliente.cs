using MinhaEmpresa.Agenda.Dominio.Entidades;
using NUnit.Framework;

namespace MinhaEmpresa.Agenda.Testes
{
    [TestFixture]
    public class TesteCliente
    {
        public Cliente Cliente { get; set; }
        [TestFixtureSetUp]
        public void SetupContext()
        {
            // Preparação do teste
            Cliente = new Cliente();
            Cliente.Ativo = false;
            Cliente.Nome = "Joao";
        }

        [Test]
        public void TesteSeUmClienteEstaAtivo()
        {
            Assert.AreEqual(true, Cliente.Ativo);
        }

        [Test]
        public void TesteSeUmClienteEVip()
        {

        }
    }
}
