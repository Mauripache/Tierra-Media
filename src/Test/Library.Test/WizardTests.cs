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


        /*
            Es necesario validar que el nombre que se está asignando sea de manera correcta, 
            para verificar el correcto funcionamiento del setter.
        */   
        public void WizardCorrectName()
        {
            Wizard testingWizard = new Wizard("");
            testingWizard.Name = "validName";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test]   

        /*
            Con este Test se está verificando que la validación de la asignación de nombre sea la esperada;
            en caso de que se intente asignar un string vacío como astributo name al objeto, este último mantendrá
            su name anterior.
        */ 

        public void WizardInorrectName()
        {
            Wizard testingWizard = new Wizard("validName");
            testingWizard.Name = "";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test] 

         /*
            Es necesario validar que al instanciarse un objeto de la clase Wizard, su atributo "Health" sea igual a 80,
            que es la vida que poseen los Wizards de este mundo creado.
        */ 
           public void WizardCorrectHealth()
        {
            Wizard testingWizard = new Wizard("Merlin");
            Assert.AreEqual(expectedHealth, testingWizard.Health);   
        }

        [Test]  

        /*
            Es necesario verificar que la validación de la asignación de la vida de un mago sea la correcta;
            en caso de que se intente asignar un entero menor a 0 a la Health de un objeto de la clase Wizard, este será cambiado a cero.
        */ 
           public void WizardInorrectHealth()
        {
            Wizard testingWizard = new Wizard("Merlin");
            testingWizard.Health = -1;
            Assert.AreEqual(expectedInorrectHealth, testingWizard.Health);   
        }


        [Test]

        /*
        Es necesario validar que el método Heal implementado, recupere la vida inicial del mago.
        */
        public void TestingHealing()
        {
            Wizard testingWizard = new Wizard("Merlin");
            testingWizard.Health = 10;
            testingWizard.Heal();
            Assert.AreEqual(expectedHealth, testingWizard.Health);
        }

        [Test]

        /*
        Es necesario validar que el método GetWizardAttack implementado, asigne como ataque del personaje
        la suma del ataque de su FireSpear, de su MagicWand, y del Spell de su Spellbook.
        */
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

        /*
            Es importante validar que el daño que recibe un mago sea el adecuado. Esto es, que se priorice en primera intancia
            la disminución completa de su escudo (suma de las Defenses que sus items le proveen), y posteriormente su Health.

        */

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

        /*
            Es necesario corroborar que el método ChangeWand implementado efectivamente cumpla la función esperada,
            esto es, reemplazar una MagicWand por una nueva.
        */
        public void TestingChangeWand()
        {
           Wizard wizard1 = new Wizard("Phoenix"); 
           wizard1.MagicWand = new MagicWand(30,30);
           MagicWand newMagicWand = new MagicWand(50,50);
           wizard1.ChangeWand(newMagicWand);
           Assert.AreEqual(newMagicWand, wizard1.MagicWand);

        }

        [Test]

        /*
            Es necesario corroborar que el método ChangeSpear implementado efectivamente cumpla la función esperada,
            esto es, reemplazar una FireSpear por una nueva que sea asignada.
        */
          public void TestingChangeSpear()
        {
           Wizard wizard1 = new Wizard("Phoenix"); 
           wizard1.FireSpear = new FireSpear(30,30);
           FireSpear newFireSpear = new FireSpear(50,50);
           wizard1.ChangeSpear(newFireSpear);
           Assert.AreEqual(newFireSpear, wizard1.FireSpear);

        }

        [Test]

        /*
            Es necesario corroborar que el método RemoveWand implementado efectivamente le quite éste item al mago
        */
        public void TestingRemoveWand()
        {
            Wizard wizard1 = new Wizard("Phoenix"); 
            MagicWand wand = new MagicWand(30,30);
            wizard1.MagicWand = wand;
            wizard1.RemoveWand();
            Assert.AreEqual(wizard1.MagicWand,null);
        }

        [Test]


        /*
            Es necesario corroborar que el método RemoveSpear implementado efectivamente le quite éste item al mago
        */
        public void TestingRemoveSpear()
        {
            Wizard wizard1 = new Wizard("Phoenix"); 
            FireSpear spear = new FireSpear(30,30);
            wizard1.FireSpear = spear;
            wizard1.RemoveSpear();
            Assert.AreEqual(wizard1.FireSpear,null);
        }

    }
}