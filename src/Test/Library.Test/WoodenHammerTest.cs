using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class WoodenHammerTest
    {
        int expectedAttack = 100;
        int expectedAttack1 = 0;
        int expectedDefense = 100;
        int expectedDefense1 = 0;
        [Test]
         /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void WoodenHammerCorrectAttack()
        {
            WoodenHammer hammer = new WoodenHammer(15, 15);
            hammer.Attack = 100;
            Assert.AreEqual(expectedAttack, hammer.Attack);
        }

        [Test]
        /*
            Es necesario testear que la implementación del setter del atributo Attack y su validación estén funcionando correctamente. 
        */
        public void WoodenHammerIncorrectAttack()
        {
            WoodenHammer hammer = new WoodenHammer(100, 100);
            hammer.Attack = -1;
            Assert.AreEqual(expectedAttack1, hammer.Attack);
        }
        [Test]
         /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void WoodenHammerCorrectDefense()
        {
            WoodenHammer hammer = new WoodenHammer(15, 15);
            hammer.Defense = 100;
            Assert.AreEqual(expectedDefense, hammer.Defense);
        }
        [Test]
        /*
            Es necesario testear que la implementación del setter del atributo Defense y su validación estén funcionando correctamente. 
        */
        public void WoodenHammerIncorrectDefense()
        {
            WoodenHammer hammer = new WoodenHammer(100, 100);
            hammer.Defense = -1;
            Assert.AreEqual(expectedDefense1, hammer.Defense);
        }
    }
}