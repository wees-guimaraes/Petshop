using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petshop;
namespace PetshopTest
{
    [TestClass]
    public class TesteUnitario{
        Controller control = new Controller();


        [TestMethod]
        public void createTest(){
          var resultado = control.registrarServico("Teste Serviço", 100);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void listTest(){
            var resultado = control.exibirServicos();
            Assert.AreEqual(true, resultado);
        }

      /*  [TestMethod]
        public void updateTest(){

        }*/

       /* [TestMethod]
        public void deleteTest(){

        }*/

    }
}
