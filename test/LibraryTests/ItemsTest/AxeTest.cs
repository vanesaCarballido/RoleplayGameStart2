using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class AxeTest
    {
        private Axe axe;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el hacha antes de cada prueba
            axe = new Axe();
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque del hacha sea 25
            Assert.That(axe.AttackValue, Is.EqualTo(25));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa del hacha sea 0
            Assert.That(axe.DefenseValue, Is.EqualTo(0));
        }
    }
}