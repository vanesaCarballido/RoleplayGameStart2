namespace Ucu.Poo.RoleplayGame;

public class Wizard:ICharacter
{
    private int health =100;
    private SpellsBook spellsBook;
    private Staff staff;
    public Wizard(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }

    public SpellsBook SpellsBook 
    {
        get { return spellsBook; }
        set
        {
            if (spellsBook == null)
                spellsBook = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el libro de hechizos");
            }
        }
    }

    public Staff Staff
    {
        get { return staff; }
        set
        {
            if (staff == null)
                staff = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el bastón");
            }
        }
    }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}