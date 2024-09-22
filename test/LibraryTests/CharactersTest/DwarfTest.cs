using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class DwarfTest
    {
        private Dwarf dwarf;
        private MockItem mockItem;

        [SetUp]
        public void Setup()
        {
            dwarf = new Dwarf("Gimli");
            mockItem = new MockItem(attackValue: 15, defenseValue: 10);  // Configura item simulado
            dwarf.iitem = mockItem;
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.That(dwarf.AttackValue, Is.EqualTo(15));  // Verifica valor de ataque
        }

        [Test]
        public void TestDefenseValue()
        {
            int expectedDefense = mockItem.DefenseValue * 2;  // Defensa = 2 * valor del item
            Assert.That(dwarf.DefenseValue, Is.EqualTo(expectedDefense));  // Verifica valor de defensa
        }

        [Test]
        public void TestReceiveAttack()
        {
            int attackPower = 30;
            int expectedHealthAfterAttack = 90;  // 100 - (30 - 10)

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

    public class MockItem : IItem
    {
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

        public MockItem(int attackValue, int defenseValue)
        {
            AttackValue = attackValue;
            DefenseValue = defenseValue;  // Configura valores de ataque y defensa del item
        }
    }
}