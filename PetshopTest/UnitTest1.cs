using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petshop;
namespace PetshopTest {
    [TestClass]
    public class TesteUnitario {
        Controller control = new Controller();
        int ultimoId;

        [TestInitialize]
        public void prepararTests() {
            control.limpaBanco();
        }

        [TestMethod]
        public void createTest_valorAceitavel() { // Teste com Create 01
            var resultadoInsert = control.registrarServico("Primeiro serviço", 200.0);
            Assert.AreEqual(true, resultadoInsert);
        }

        [TestMethod]
        public void createTest_valorNegativo() { // Teste com Create 02
            var resultadoInsert = control.registrarServico("Segundo serviço", -10.0);
            Assert.AreEqual(true, resultadoInsert);
        }

        [TestMethod]
        public void createTest_valorLimiteUltrapassado() { // Teste com Create 03
            var resultadoInsert = control.registrarServico("Terceiro serviço", 600.0);
            Assert.AreEqual(true, resultadoInsert);
        }

        [TestMethod]
        public void listTest() {
            var resultado = control.exibirServicos();
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void updateTest_valorAceitavel() { // Teste com Update 01
            control.registrarServico("Teste", 100.0);
            ultimoId = control.retornaUltimoId();
            var resultado = control.editarServico("Teste", "Editando para um valor aceitável", 50.0, ultimoId);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void updateTest_valorLimiteUltrapassado() { // Teste com Update 02
            control.registrarServico("Teste", 100.0);
            ultimoId = control.retornaUltimoId();
            var resultado = control.editarServico("Teste", "Editando para um valor que ultrapasse o valor limite",
                650.0, ultimoId);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void updateTest_valorLimiteNegativo() { // Teste com Update 03
            control.registrarServico("Teste", 100.0);
            ultimoId = control.retornaUltimoId();
            var resultado = control.editarServico("Teste", "Editando para um valor negativo", -3.0, ultimoId);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deleteTest() {
            control.registrarServico("Teste a Deletar", 90.0);
            ultimoId = control.retornaUltimoId();
            var resultadoDelete = control.deletarServico(ultimoId);
            Assert.AreEqual(true, resultadoDelete);
        }

    }
}