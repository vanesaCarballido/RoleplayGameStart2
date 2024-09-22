using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class StaffTest
    {
        private Staff staff;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el bastón
            staff = new Staff();
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos que el valor de ataque sea 100 (valor esperado para el bastón)
            Assert.That(staff.AttackValue, Is.GreaterThanOrEqualTo(100));
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos que el valor de defensa sea 100 (valor esperado para el bastón)
            Assert.That(staff.DefenseValue, Is.GreaterThanOrEqualTo(100));
        }
    }
}