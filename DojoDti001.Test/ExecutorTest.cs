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
        public void TesteParaALetraA()
        {
            var retorno = executor.Teste("A");

            Assert.AreEqual("A", retorno);

        }

        [TestMethod]
        public void TesteParaALetraB()
        {
            var retorno = executor.Teste("B");

            Assert.AreEqual("A\nB B\nA", retorno);
        }

        [TestMethod]
        public void TesteParaALetraE()
        {
            var retorno = executor.Teste("E");

            Assert.AreEqual("A\nB B\nC  C\nD   D\nE    E\nD   D\nC  C\nB B\nA", retorno);
        }
    }
}
