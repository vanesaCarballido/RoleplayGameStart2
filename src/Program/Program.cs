using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new Spell[]{ new Spell() };

Wizard gandalf = new Wizard("Gandalf");
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;

Dwarf gimli = new Dwarf("Gimli");
gimli.iitem = new Axe();
gimli.iitem = new Helmet();
gimli.iitem = new Shield();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");