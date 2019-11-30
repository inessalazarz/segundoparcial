using System;
using Ines;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyTest
{
    [TestClass]         
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodNombre()
        {
            //organizar
            string n1 = "Lizzie";
            double y = 1.00;
            Company obj = new Company(n1,y);
            string valoresperado = "";
            //sdgsgsg
            //actuar
            string valorrespuesta = obj.Name;
            //afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);
            
        }
        [TestMethod]
        public void TestMethodSpend()
        {
            //organizar
            var obj1 = new Company("Ines",1);
            double valoresperado = 1;

            //actuar
            string valorrespuesta = obj1.Spend();
            //afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);

        }
        
        


    }

}
