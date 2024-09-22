using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class ArcherTest
    {
        private Archer archer;

        [SetUp]
        public void Setup()
        {
            archer = new Archer("Pepito");
            archer.Bow = new Bow();  // AttackValue = 15
            archer.Helmet = new Helmet();  // DefenseValue = 18
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.That(archer.AttackValue, Is.EqualTo(15));  // Verifica el valor de ataque
        }

        [Test]
        public void TestDefenseValue()
        {
            Assert.That(archer.DefenseValue, Is.EqualTo(18));  // Verifica el valor de defensa
        }

        [Test]
        public void TestReceiveAttack()
        {
            int attackPower = 30;
            int expectedHealthAfterAttack = 88;  // 100 - (30 - 18)

            archer.ReceiveAttack(attackPower);  // Recibe ataque

            Assert.That(archer.Health, Is.EqualTo(expectedHealthAfterAttack));  // Verifica la salud
        }

        [Test]
        public void TestCure()
        {
            archer.ReceiveAttack(50);
            archer.Cure();
            Assert.That(archer.Health, Is.EqualTo(100));  // Verifica curación
        }
    }
}