using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class SwordTest
    {
        private Sword sword;

        [SetUp]
        public void Setup()
        {
            sword = new Sword(); // Inicializamos la espada
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque sea 20
            Assert.That(sword.AttackValue, Is.EqualTo(20));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa sea 0
            Assert.That(sword.DefenseValue, Is.EqualTo(0));
        }
    }
}