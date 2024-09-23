using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary
{
    [TestFixture]
    public class KnightTest
    {
        private Knight knight;

        [SetUp]
        public void Setup()
        {
            // Inicializamos el caballero con sus ítems
            knight = new Knight("Arthur")
            {
                Sword = new Sword(),      // Ataque = 20
                Shield = new Shield(),    // Defensa = 14
                Armor = new Armor()       // Defensa = 25
            };
        }

        [Test]
        public void TestAttackValue()
        {
            // Verificamos el valor de ataque
            Assert.That(knight.AttackValue, Is.EqualTo(20)); // Sword = 20
        }

        [Test]
        public void TestDefenseValue()
        {
            // Verificamos el valor de defensa
            Assert.That(knight.DefenseValue, Is.EqualTo(39)); // Armor + Shield = 25 + 14
        }

        [Test]
        public void TestHealthInitialValue()
        {
            // Salud inicial debe ser 100
            Assert.That(knight.Health, Is.EqualTo(100));
        }

        [Test]
        public void TestReceiveAttack()
        {
            // Ataque menor que defensa, salud no cambia
            knight.ReceiveAttack(30);
            Assert.That(knight.Health, Is.EqualTo(100)); // Defensa = 39
        }

        [Test]
        public void TestReceiveAttackWithDamage()
        {
            // Ataque mayor que defensa, salud baja
            knight.ReceiveAttack(50); // 50 - 39 = 11 daño
            Assert.That(knight.Health, Is.EqualTo(89)); // Salud 100 - 11 = 89
        }

        [Test]
        public void TestCure()
        {
            // Se cura después de recibir daño
            knight.ReceiveAttack(50);
            knight.Cure();
            Assert.That(knight.Health, Is.EqualTo(100)); // Salud restaurada
        }
    }
}