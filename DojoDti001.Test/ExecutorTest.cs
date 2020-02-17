using DojoDti001.Servico;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoDti001.Test
{
    [TestClass]
    public class ExecutorTeste
    {
        private Executor executor;

        [TestInitialize]
        public void InicializarTeste()
        {
            executor = new Executor(); 
        }

        [TestMethod]
        public void TesteBasicoDeSoma()
        {

            var retorno = executor.Teste();

            Assert.AreEqual(0, retorno);

        }
    }
}
