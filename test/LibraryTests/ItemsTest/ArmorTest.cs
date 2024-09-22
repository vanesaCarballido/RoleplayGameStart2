using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class ArmorTest
    {
        private Armor armor;

        [SetUp]
        public void Setup()
        {
            // Inicializamos la armadura antes de cada prueba
            armor = new Armor();
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa de la armadura sea 25
            Assert.That(armor.DefenseValue, Is.EqualTo(25));
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que la armadura no tenga valor de ataque (debería ser 0)
            Assert.That(armor.AttackValue, Is.EqualTo(0));
        }
    }
}