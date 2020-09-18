using NUnit.Framework;
using MiddleEarth;

namespace Test.Library
{
    public class TrollTest
    {
        private Troll troll;

        [SetUp]
        public void Setup()
        {
            this.troll = new Troll("Tom");
            WoodenHammer hammer = new WoodenHammer(150, 0);
            this.troll.Hammer = hammer;
            IronArmor armor = new IronArmor(0, 50);
            this.troll.Armor = armor;
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignEmptyName()
        {
            this.troll.Name = "";
            Assert.AreEqual(this.troll.Name, "Tom");
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeHealth()
        {
            this.troll.Health = -20;
            Assert.AreEqual(this.troll.Health, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewName()
        {
            this.troll.Name = "Bert";
            Assert.AreEqual(this.troll.Name, "Bert");
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewHealth()
        {
            this.troll.Health = 150;
            Assert.AreEqual(this.troll.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeWoodenHammer
            efectivamente cambie el arco por uno nuevo, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeWoodenHammer()
        {
            WoodenHammer newWoodenHammer = new WoodenHammer(300, 0);
            this.troll.Hammer = newWoodenHammer;
            Assert.AreEqual(this.troll.Hammer, newWoodenHammer);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveWoodenHammer
            efectivamente elimine el arco del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveWoodenHammer()
        {
            this.troll.RemoveWeapon();
            Assert.AreEqual(this.troll.Hammer, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeArmor
            efectivamente cambie la armadura por una nueva, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeArmor()
        {
            IronArmor newArmor = new IronArmor(300, 0);
            this.troll.Armor = newArmor;
            Assert.AreEqual(this.troll.Armor, newArmor);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveArmor
            efectivamente elimine la armadura del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveArmor()
        {
            this.troll.RemoveArmor();
            Assert.AreEqual(this.troll.Armor, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método Heal
            efectivamente lleve al personaje de vuelta a la vida máxima.
            Si se hicieran cambios en Heal o en los valores de vida del personaje,
            y este test fallara entonces estaría mal la implementación del metodo Heal.
        */
        public void HealCharacterToFullLife()
        {
            this.troll.Health = 50;
            this.troll.Heal();
            Assert.AreEqual(this.troll.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método GetAttack
            efectivamente devuelva el total de ataque del personaje, en caso
            de que se agregaran mas items o se cambiara la implementación, y este 
            test fallara entonces estaría mal implementado GetAttack.
        */
        public void GetCharacterAttack()
        {
            Assert.AreEqual(this.troll.Hammer.Attack, this.troll.GetAttack());
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura suficiente
            para aguantar el daño recibido se pierde la cantidad justa y no se
            pierde vida.
        */
        public void TakeDamageArmorAbsorbsIt()
        {
            this.troll.ReceiveDamage(25);
            Assert.AreEqual(this.troll.Armor.Defense, 25);
            Assert.AreEqual(this.troll.Health, 150);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanAvailableLife()
        {
            this.troll.ReceiveDamage(200);
            Assert.AreEqual(this.troll.Armor.Defense, 0);
            Assert.AreEqual(this.troll.Health, 0);
        }
        [Test]
        /*
            Este test asegura que si el personaje no tiene armadura,
            el daño recibido se resta directamente de la vida
            del personaje.
        */
        public void TakeDamageNoArmor()
        {
            this.troll.Armor.Defense = 0;
            this.troll.ReceiveDamage(50);
            Assert.AreEqual(this.troll.Health, 100);
        }

    }

}