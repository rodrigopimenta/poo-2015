using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace poo_paint
{
    [TestClass]
    public class TesteRetangulo
    {
        [TestMethod]
        public void TestaImprime()
        {
            Retangulo r1 = new Retangulo(10, 20, 50, 60);
            Assert.AreEqual("retangulo[x:10,y:20,l:50,a:60]", r1.Imprime());
            Retangulo r2 = new Retangulo(5, 5, 10, 200);
            Assert.AreEqual("retangulo[x:5,y:5,l:10,a:200]", r2.Imprime());
        }
    }
}
