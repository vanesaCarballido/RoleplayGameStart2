using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class HelmetTest
    {
        private Helmet helmet;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el casco antes de cada prueba
            helmet = new Helmet();
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa del casco sea 18
            Assert.That(helmet.DefenseValue, Is.EqualTo(18));
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque del casco sea 0
            Assert.That(helmet.AttackValue, Is.EqualTo(0));
        }
    }
}