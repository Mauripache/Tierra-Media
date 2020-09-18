using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{


     public class FireSpearTest
    {
        int expectedAttack = 100;
        int caseWrongAttack = 0;
        int expectedDefense = 100;
        int caseWrongDefense = 0;

        [Test]
        public void FireSpearCorrectAttack()
        {
            FireSpear spear = new FireSpear(30, 0);
            spear.Attack = 100;
            Assert.AreEqual(expectedAttack, spear.Attack);
        }

        [Test]
        public void FireSpearIncorrectAttack()
        {
            FireSpear spear = new FireSpear(50, 0);
            spear.Attack = -1;
            Assert.AreEqual(caseWrongAttack, spear.Attack);
        }

        [Test]
        public void FireSpearCorrectDefense()
        {
            FireSpear spear = new FireSpear(70, 5);
            spear.Defense = 100;
            Assert.AreEqual(expectedDefense, spear.Defense);
        }

        [Test]
        public void FireSpearIncorrectDefense()
        {
            FireSpear spear = new FireSpear(50, 0);
            spear.Defense = -1;
            Assert.AreEqual(caseWrongDefense, spear.Defense);
        }

    }
}

