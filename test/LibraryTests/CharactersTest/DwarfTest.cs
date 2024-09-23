using System.ComponentModel;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class DwarfTest
    {
        private Dwarf dwarf;

        [SetUp]
        public void Setup()
        {
            dwarf = new Dwarf("Gimli");
            dwarf.Axe = new Axe(); // AttackValue = 25
            dwarf.Helmet = new Helmet(); //DefenseValue = 18
            dwarf.Shield = new Shield(); //DefenseValue = 14
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.That(dwarf.AttackValue, Is.EqualTo(25));  // Verifica valor de ataque
        }

        [Test]
        public void TestDefenseValue()
        {
            Assert.That(dwarf.DefenseValue, Is.EqualTo(32));  // Verifica valor de defensa
        }

        [Test]
        public void TestReceiveAttack()
        {
            int attackPower = 40;
            int expectedHealthAfterAttack = 92;  // 100 - (30 - 10)

            dwarf.ReceiveAttack(attackPower);  // Dwarf recibe ataque

            Assert.That(dwarf.Health, Is.EqualTo(expectedHealthAfterAttack));  // Verifica la salud después del ataque
        }

        [Test]
        public void TestCure()
        {
            dwarf.ReceiveAttack(50);  // Reduce la salud
            dwarf.Cure();  // Cura la salud
            Assert.That(dwarf.Health, Is.EqualTo(100));  // Verifica curación
        }
    }
}