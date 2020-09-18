using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class GoldenArmorTest
    {
        private GoldenArmor armor;

        [SetUp]
        public void Setup()
        {
            this.armor = new GoldenArmor(0, 50);        
        }
        [Test]
        /*
            Se le asigna un valor para checkear que la implementacion
            del setter no este fallando.
        */
        public void AssignGoldenArmorAttackPositive()
        {
            this.armor.Attack = 50;
            Assert.AreEqual(this.armor.Attack, 50);
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido.
        */
        public void AssignGoldenArmorAttackNegative()
        {
            this.armor.Attack = -20;
            Assert.AreEqual(this.armor.Attack, 0);
        }
        [Test]
        /*
            Se le asigna un valor valido para checkear que la
            implementacion del setter no este fallando.
        */
        public void AssignGoldenArmorDefensePositive()
        {
            this.armor.Defense = 100;
            Assert.AreEqual(this.armor.Defense, 100);
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido.
        */
        public void AssignGoldenArmorDefenseNegative()
        {
            this.armor.Defense = -20;
            Assert.AreEqual(this.armor.Defense, 0);
        }
    }


}