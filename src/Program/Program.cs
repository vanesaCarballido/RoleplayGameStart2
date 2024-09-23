using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
Spell spell = new Spell();
book.Spells = new Spell[]{ spell };

Wizard gandalf = new Wizard("Gandalf");
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;
gandalf.Staff = new Staff();

Dwarf gimli = new Dwarf("Gimli");
gimli.Axe = new Axe();
gimli.Helmet = new Helmet();
gimli.Shield = new Shield();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");