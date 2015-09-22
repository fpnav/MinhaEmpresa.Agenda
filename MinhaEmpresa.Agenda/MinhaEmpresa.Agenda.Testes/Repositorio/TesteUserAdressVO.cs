using System;
using MinhaEmpresa.Agenda.Dominio.ValueObjects;
using NUnit.Framework;

namespace MinhaEmpresa.Agenda.Testes.Repositorio
{
    [TestFixture]
    public class TesteUserAdressVo : TesteRepositorioBase
    {
        [TestFixtureSetUp]
        public void SetupContext()
        {
        }

        [Test]
        public void PodePersistirUmUsuarioComEnderecoSendoUmValueObject()
        {
            using (var sessao = Helper.AbrirSessao())
            {
                try
                {
                    var usuario = new User("Fabio Navarro");
                    //usuario.Address.City = "asda"; 
                    //NAO POSSO FAZER ISSO, POIS ADDRESS POSSUI sets privados. Tenho q usar o metodo existente 
                    //já definido para este caso, pois ADRRESS é um ValueObject.

                    usuario.CreateNewAddress("Rua1","Rua2","Marilia","CentroOeste","Brasil","17500-000");

                    sessao.IniciaTransacao();

                    var repo = sessao.GetRepositorio<User>();
                    repo.Inclui(usuario);

                    //Assert.Greater(dados.Count(), 0);

                    //Console.WriteLine();
                    //Console.WriteLine(@"ALUNOS:");
                    //Console.WriteLine(@"=====================================");
                    //foreach (var f in dados.Take(10))
                    //    Console.WriteLine(@"{0} - {1}", f.Id, f.Nome);

                    sessao.ComitaTransacao();
                }
                catch (Exception ex)
                {
                    sessao.RollBackTransacao();
                    Assert.Fail(ex.ToString());
                }
            }
        }
    }
}