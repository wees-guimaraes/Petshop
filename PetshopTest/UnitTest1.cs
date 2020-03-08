using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petshop;
namespace PetshopTest
{
    [TestClass]
    public class TesteUnitario{
        Controller control = new Controller();
        int ultimoId;

        [TestInitialize]
        public void prepararTests() {
            control.limpaBanco();
        }

        [TestMethod]
        public void createTest(){
          var resultadoInsert = control.registrarServico("Serviço Inserido", 200.0);
            Assert.AreEqual(true, resultadoInsert);
        }

        [TestMethod]
        public void listTest(){
            var resultado = control.exibirServicos();
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void updateTest(){
            control.registrarServico("Teste", 100.0);
            ultimoId = control.retornaUltimoId();
            var resultado = control.editarServico("Teste", "Teste Editado", 50.0, ultimoId);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deleteTest(){
            control.registrarServico("Teste a Deletar", 90.0);
            ultimoId = control.retornaUltimoId();
            var resultadoDelete = control.deletarServico(ultimoId);
            Assert.AreEqual(true, resultadoDelete);
        }

    }
}
