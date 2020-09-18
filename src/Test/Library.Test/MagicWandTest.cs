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
        public void MagicWandCorrectAttack()
        {
            MagicWand wand = new MagicWand(30, 0);
            wand.Attack = 100;
            Assert.AreEqual(expectedAttack, wand.Attack);
        }

        [Test]
        public void MagicWandIncorrectAttack()
        {
            MagicWand wand = new MagicWand(50, 0);
            wand.Attack = -1;
            Assert.AreEqual(caseWrongAttack, wand.Attack);
        }

        [Test]
        public void MagicWandCorrectDefense()
        {
            MagicWand wand = new MagicWand(70, 5);
            wand.Defense = 100;
            Assert.AreEqual(expectedDefense, wand.Defense);
        }

        [Test]
        public void MagicWandIncorrectDefense()
        {
            MagicWand wand = new MagicWand(50, 0);
            wand.Defense = -1;
            Assert.AreEqual(caseWrongDefense, wand.Defense);
        }

    }
}