using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class BowTest
    {
        private Bow bow;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el arco antes de cada prueba
            bow = new Bow();
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque del arco sea 15
            Assert.That(bow.AttackValue, Is.EqualTo(15));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa del arco sea 0
            Assert.That(bow.DefenseValue, Is.EqualTo(0));
        }
    }
}