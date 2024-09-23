using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class SpellTest
    {
        private Spell spell;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el hechizo
            spell = new Spell();
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque sea 70 (valor esperado para el hechizo)
            Assert.That(spell.AttackValue, Is.GreaterThanOrEqualTo(70));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa sea 70 (valor esperado para el hechizo)
            Assert.That(spell.DefenseValue, Is.GreaterThanOrEqualTo(70));
        }
    }
}