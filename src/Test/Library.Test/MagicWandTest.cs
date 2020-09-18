using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{


     public class MagicWandTest
    {
        int expectedAttack = 100;
        int caseWrongAttack = 0;
        int expectedDefense = 100;
        int caseWrongDefense = 0;

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void MagicWandCorrectAttack()
        {
            MagicWand wand = new MagicWand(30, 0);
            wand.Attack = 100;
            Assert.AreEqual(expectedAttack, wand.Attack);
        }

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack y su validación estén funcionando correctamente. 
        */
        public void MagicWandIncorrectAttack()
        {
            MagicWand wand = new MagicWand(50, 0);
            wand.Attack = -1;
            Assert.AreEqual(caseWrongAttack, wand.Attack);
        }

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void MagicWandCorrectDefense()
        {
            MagicWand wand = new MagicWand(70, 5);
            wand.Defense = 100;
            Assert.AreEqual(expectedDefense, wand.Defense);
        }

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense y su validación estén funcionando correctamente. 
        */
        public void MagicWandIncorrectDefense()
        {
            MagicWand wand = new MagicWand(50, 0);
            wand.Defense = -1;
            Assert.AreEqual(caseWrongDefense, wand.Defense);
        }

    }
}