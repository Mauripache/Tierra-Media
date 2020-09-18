using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
     public class WizardTests
    {
        string expectedName = "validName";
        int expectedHealth = 80;
        int expectedInorrectHealth = 0;

        

        [Test]       
        public void WizardCorrectName()
        {
            Wizard testingWizard = new Wizard("");
            testingWizard.Name = "validName";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test]       
        public void WizardInorrectName()
        {
            Wizard testingWizard = new Wizard("validName");
            testingWizard.Name = "";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test] 
           public void WizardCorrectHealth()
        {
            Wizard testingWizard = new Wizard("Merlin");
            Assert.AreEqual(expectedHealth, testingWizard.Health);   
        }

        [Test]  
           public void WizardInorrectHealth()
        {
            Wizard testingWizard = new Wizard("Merlin");
            testingWizard.Health = -1;
            Assert.AreEqual(expectedInorrectHealth, testingWizard.Health);   
        }


        [Test]
        public void TestingHealing()
        {
            Wizard testingWizard = new Wizard("Merlin");
            testingWizard.Health = 10;
            testingWizard.Heal();
            Assert.AreEqual(expectedHealth, testingWizard.Health);
        }

        [Test]
        public void TestingGetWizardAttack()
        {
            Wizard wizard1 = new Wizard("Phoenix");
            Spell firstSpell = new Spell(70,"Fireball");
            wizard1.FireSpear = new FireSpear(50,0);
            wizard1.SpellBook = new Spellbook(firstSpell);
            wizard1.MagicWand = new MagicWand(30,30);
            int expectedAttack = 150;
            Assert.AreEqual(expectedAttack, wizard1.GetWizardAttack());
        }

        [Test]
        public void TestingReceiveDamage()
        {
            Wizard wizard1 = new Wizard("Phoenix");
            Spell firstSpell = new Spell(70,"Fireball");
            wizard1.FireSpear = new FireSpear(50,0);
            wizard1.SpellBook = new Spellbook(firstSpell);
            wizard1.MagicWand = new MagicWand(30,30);
            int expectedLife = 20;
            wizard1.ReceiveDamage(90);
            Assert.AreEqual(expectedLife, wizard1.Health);

        }
        [Test]
        public void TestingChangeWand()
        {
           Wizard wizard1 = new Wizard("Phoenix"); 
           wizard1.MagicWand = new MagicWand(30,30);
           MagicWand newMagicWand = new MagicWand(50,50);
           wizard1.ChangeWand(newMagicWand);
           Assert.AreEqual(newMagicWand, wizard1.MagicWand);

        }

        [Test]
          public void TestingChangeSpear()
        {
           Wizard wizard1 = new Wizard("Phoenix"); 
           wizard1.FireSpear = new FireSpear(30,30);
           FireSpear newFireSpear = new FireSpear(50,50);
           wizard1.ChangeSpear(newFireSpear);
           Assert.AreEqual(newFireSpear, wizard1.FireSpear);

        }

        [Test]
        public void TestingRemoveWand()
        {
            Wizard wizard1 = new Wizard("Phoenix"); 
            MagicWand wand = new MagicWand(30,30);
            wizard1.MagicWand = wand;
            wizard1.RemoveWand(wand);
            Assert.AreEqual(wizard1.MagicWand,null);
        }

    }
}