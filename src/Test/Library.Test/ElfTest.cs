using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class ElfTest
    {
        private Elf elf;

        [SetUp]
        public void Setup()
        {
            this.elf = new Elf("Legolas");
            Bow bow = new Bow(150, 0);
            this.elf.Bow = bow;
            LeatherArmor armor = new LeatherArmor(0, 50);
            this.elf.Armor = armor;
        }
        [Test]
        public void AssignEmptyName()
        {
            this.elf.Name = "";
            Assert.AreEqual(this.elf.Name, "Legolas");
        }
        [Test]
        public void AssignNegativeHealth()
        {
            this.elf.Health = -20;
            Assert.AreEqual(this.elf.Health, 0);
        }
        [Test]
        public void AssignNewName()
        {
            this.elf.Name = "Not Legolas";
            Assert.AreEqual(this.elf.Name, "Not Legolas");
        }
        [Test]
        public void AssignNewHealth()
        {
            this.elf.Health = 150;
            Assert.AreEqual(this.elf.Health, 150);
        }
        [Test]
        public void ChangeBow()
        {
            Bow newBow = new Bow(300, 0);
            this.elf.Bow = newBow;
            Assert.AreEqual(this.elf.Bow, newBow);
        }
        [Test]
        public void RemoveBow()
        {
            this.elf.RemoveWeapon();
            Assert.AreEqual(this.elf.Bow, null);
        }
        [Test]
        public void ChangeArmor()
        {
            LeatherArmor newArmor = new LeatherArmor(300, 0);
            this.elf.Armor = newArmor;
            Assert.AreEqual(this.elf.Armor, newArmor);
        }
        [Test]
        public void RemoveArmor()
        {
            this.elf.RemoveArmor();
            Assert.AreEqual(this.elf.Armor, null);
        }
        [Test]
        public void HealCharacterToFullLife()
        {
            this.elf.Health = 50;
            this.elf.Heal();
            Assert.AreEqual(this.elf.Health, 100);
        }
        [Test]
        public void GetCharacterAttack()
        {
            Assert.AreEqual(this.elf.Bow.Attack, this.elf.GetAttack());
        }
        [Test]
        public void TakeDamageArmorAbsorbsIt()
        {
            this.elf.ReceiveDamage(25);
            Assert.AreEqual(this.elf.Armor.Defense, 25);
            Assert.AreEqual(this.elf.Health, 100);
        }
        [Test]
        public void TakeDamageMoreThanAvailableLife()
        {
            this.elf.ReceiveDamage(200);
            Assert.AreEqual(this.elf.Armor.Defense, 0);
            Assert.AreEqual(this.elf.Health, 0);
        }
        [Test]
        public void TakeDamageNoArmor()
        {
            this.elf.Armor.Defense = 0;
            this.elf.ReceiveDamage(50);
            Assert.AreEqual(this.elf.Health, 50);
        }

    }

}