using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{


    public class IronArmorTest
    {
        int expectedAttack = 100;
        int expectedAttack1 = 0;
        int expectedDefense = 100;
        int expectedDefense1 = 0;
        [Test]
        public void IronArmorCorrectAttack()
        {
            IronArmor armor = new IronArmor(15, 15);
            armor.Attack = 100;
            Assert.AreEqual(expectedAttack, armor.Attack);
        }
        [Test]
        public void IronArmorIncorrectAttack()
        {
            IronArmor armor = new IronArmor(100, 100);
            armor.Attack = -1;
            Assert.AreEqual(expectedAttack1, armor.Attack);
        }
        [Test]
        public void IronArmorrCorrectDefense()
        {
            IronArmor armor = new IronArmor(15, 15);
            armor.Defense = 100;
            Assert.AreEqual(expectedDefense, armor.Defense);
        }
        [Test]
        public void IronArmorIncorrectDefense()
        {
            IronArmor armor = new IronArmor(100, 100);
            armor.Defense = -1;
            Assert.AreEqual(expectedDefense1, armor.Defense);
        }

    }
}