using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class ShieldTest
    {
        private Shield shield;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el escudo antes de cada prueba
            shield = new Shield();
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa del escudo sea 14
            Assert.That(shield.DefenseValue, Is.EqualTo(14));
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque del escudo sea 0
            Assert.That(shield.AttackValue, Is.EqualTo(0));
        }
    }
}