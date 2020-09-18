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
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignEmptyName()
        {
            this.elf.Name = "";
            Assert.AreEqual(this.elf.Name, "Legolas");
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeHealth()
        {
            this.elf.Health = -20;
            Assert.AreEqual(this.elf.Health, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewName()
        {
            this.elf.Name = "Not Legolas";
            Assert.AreEqual(this.elf.Name, "Not Legolas");
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewHealth()
        {
            this.elf.Health = 150;
            Assert.AreEqual(this.elf.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeBow
            efectivamente cambie el arco por uno nuevo, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeBow()
        {
            Bow newBow = new Bow(300, 0);
            this.elf.Bow = newBow;
            Assert.AreEqual(this.elf.Bow, newBow);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveBow
            efectivamente elimine el arco del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveBow()
        {
            this.elf.RemoveWeapon();
            Assert.AreEqual(this.elf.Bow, null);
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
            LeatherArmor newArmor = new LeatherArmor(300, 0);
            this.elf.Armor = newArmor;
            Assert.AreEqual(this.elf.Armor, newArmor);
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
            this.elf.RemoveArmor();
            Assert.AreEqual(this.elf.Armor, null);
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
            this.elf.Health = 50;
            this.elf.Heal();
            Assert.AreEqual(this.elf.Health, 100);
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
            Assert.AreEqual(this.elf.Bow.Attack, this.elf.GetAttack());
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura suficiente
            para aguantar el daño recibido se pierde la cantidad justa y no se
            pierde vida.
        */
        public void TakeDamageArmorAbsorbsIt()
        {
            this.elf.ReceiveDamage(25);
            Assert.AreEqual(this.elf.Armor.Defense, 25);
            Assert.AreEqual(this.elf.Health, 100);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanAvailableLife()
        {
            this.elf.ReceiveDamage(200);
            Assert.AreEqual(this.elf.Armor.Defense, 0);
            Assert.AreEqual(this.elf.Health, 0);
        }
        [Test]
        /*
            Este test asegura que si el personaje no tiene armadura,
            el daño recibido se resta directamente de la vida
            del personaje.
        */
        public void TakeDamageNoArmor()
        {
            this.elf.Armor.Defense = 0;
            this.elf.ReceiveDamage(50);
            Assert.AreEqual(this.elf.Health, 50);
        }

    }

}