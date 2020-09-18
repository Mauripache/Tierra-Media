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
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignPositiveAttack()
        {
            this.bow.Attack = 50;
            Assert.AreEqual(this.bow.Attack, 50);
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeAttack()
        {
            this.bow.Attack = -50;
            Assert.AreEqual(this.bow.Attack, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignPositiveDefense()
        {
            this.bow.Defense = 123;
            Assert.AreEqual(this.bow.Defense, 123);
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeDefense()
        {
            this.bow.Defense = -50;
            Assert.AreEqual(this.bow.Defense, 0);
        }
    }


}