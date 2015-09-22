using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MinhaEmpresa.SharedKernel.Testes
{
    [TestFixture]
    public class TesteHelloWorld
    {
        [TestFixtureSetUp]
        public void SetupContext()
        {
            // Preparação do teste
        }

        [Test]
        public void TestHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Assert.AreEqual(1 + 1, 2);
        }

    }
}
