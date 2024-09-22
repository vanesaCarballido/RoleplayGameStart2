using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary
{
    [TestFixture]
    public class WizardTest
    {
        private Wizard wizard;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el mago con su bastón y libro de hechizos
            wizard = new Wizard("Merlin")
            {
                Staff = new Staff(), // Ataque = 100, Defensa = 100
                SpellsBook = new SpellsBook
                {
                    Spells = new Spell[] // Inicializamos con un hechizo
                    {
                        new Spell() // Ataque = 70, Defensa = 70
                    }
                }
            };
        }

        [Test]
        public void TestAttackValue()
        {
            // Valor de ataque es la suma del staff y el hechizo
            Assert.That(wizard.AttackValue, Is.EqualTo(170)); // 100 + 70
        }

        [Test]
        public void TestDefenseValue()
        {
            // Valor de defensa es la suma del staff y el hechizo
            Assert.That(wizard.DefenseValue, Is.EqualTo(170)); // 100 + 70
        }

        [Test]
        public void TestHealthInitialValue()
        {
            // Salud inicial debe ser 100
            Assert.That(wizard.Health, Is.EqualTo(100));
        }

        [Test]
        public void TestReceiveAttack()
        {
            // Ataque menor que defensa, salud no cambia
            wizard.ReceiveAttack(200);
            Assert.That(wizard.Health, Is.EqualTo(100)); // Defensa = 170
        }

        [Test]
        public void TestReceiveAttackWithDamage()
        {
            // Ataque mayor que defensa, salud baja
            wizard.ReceiveAttack(300); // 300 - 170 = 130 daño
            Assert.That(wizard.Health, Is.EqualTo(0)); // Salud reducida a 0
        }

        [Test]
        public void TestCure()
        {
            // Se cura después de recibir daño
            wizard.ReceiveAttack(300);
            wizard.Cure();
            Assert.That(wizard.Health, Is.EqualTo(100)); // Salud restaurada
        }
    }
}
