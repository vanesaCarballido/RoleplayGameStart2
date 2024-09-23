using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class SpellsBookTest
    {
        private SpellsBook spellsBook;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el libro de hechizos con un hechizo
            spellsBook = new SpellsBook
            {
                Spells = new Spell[]
                {
                    new Spell() // Hechizo único
                }
            };
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque sea 70 (un hechizo)
            Assert.That(spellsBook.AttackValue, Is.EqualTo(70));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa sea 70 (un hechizo)
            Assert.That(spellsBook.DefenseValue, Is.EqualTo(70));
        }
    }
}