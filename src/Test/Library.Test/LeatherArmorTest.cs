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
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignPositiveAttack()
        {
            this.leatherArmor.Attack = 50;
            Assert.AreEqual(this.leatherArmor.Attack, 50);
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeAttack()
        {
            this.leatherArmor.Attack = -50;
            Assert.AreEqual(this.leatherArmor.Attack, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignPositiveDefense()
        {
            this.leatherArmor.Defense = 123;
            Assert.AreEqual(this.leatherArmor.Defense, 123);
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeDefense()
        {
            this.leatherArmor.Defense = -50;
            Assert.AreEqual(this.leatherArmor.Defense, 0);
        }
    }


}