using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class LeatherArmorTest
    {
        private LeatherArmor leatherArmor;

        [SetUp]
        public void Setup()
        {
            this.leatherArmor = new LeatherArmor(0, 50);        
        }
        [Test]
        public void AssignPositiveAttack()
        {
            this.leatherArmor.Attack = 50;
            Assert.AreEqual(this.leatherArmor.Attack, 50);
        }
        [Test]
        public void AssignNegativeAttack()
        {
            this.leatherArmor.Attack = -50;
            Assert.AreEqual(this.leatherArmor.Attack, 0);
        }
        [Test]
        public void AssignPositiveDefense()
        {
            this.leatherArmor.Defense = 123;
            Assert.AreEqual(this.leatherArmor.Defense, 123);
        }
        [Test]
        public void AssignNegativeDefense()
        {
            this.leatherArmor.Defense = -50;
            Assert.AreEqual(this.leatherArmor.Defense, 0);
        }
    }


}