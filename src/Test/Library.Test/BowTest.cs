using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class BowTest
    {
        private Bow bow;

        [SetUp]
        public void Setup()
        {
            this.bow = new Bow(0, 50);        
        }
        [Test]
        public void AssignPositiveAttack()
        {
            this.bow.Attack = 50;
            Assert.AreEqual(this.bow.Attack, 50);
        }
        [Test]
        public void AssignNegativeAttack()
        {
            this.bow.Attack = -50;
            Assert.AreEqual(this.bow.Attack, 0);
        }
        [Test]
        public void AssignPositiveDefense()
        {
            this.bow.Defense = 123;
            Assert.AreEqual(this.bow.Defense, 123);
        }
        [Test]
        public void AssignNegativeDefense()
        {
            this.bow.Defense = -50;
            Assert.AreEqual(this.bow.Defense, 0);
        }
    }


}