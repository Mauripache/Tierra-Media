using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class AxeTest
    {
        private Axe axe;

        [SetUp]
        public void Setup()
        {
            this.axe = new Axe(0, 50);        
        }
        [Test]
        /*
            Se le asigna un valor para checkear que la implementacion
            del setter no este fallando.
        */
        public void AssignAxeAttackPositive()
        {
            this.axe.Attack = 50;
            Assert.AreEqual(this.axe.Attack, 50);
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido.
        */
        public void AssignAxeAttackNegative()
        {
            this.axe.Attack = -20;
            Assert.AreEqual(this.axe.Attack, 0);
        }
        [Test]
        /*
            Se le asigna un valor valido para checkear que la
            implementacion del setter no este fallando.
        */
        public void AssignAxeDefensePositive()
        {
            this.axe.Defense = 100;
            Assert.AreEqual(this.axe.Defense, 100);
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido.
        */
        public void AssignAxeDefenseNegative()
        {
            this.axe.Defense = -20;
            Assert.AreEqual(this.axe.Defense, 0);
        }
    }


}