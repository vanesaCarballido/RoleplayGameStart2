namespace Ucu.Poo.RoleplayGame;

public class Knight:ICharacter
{

    private int health = 100;
    private Sword sword;
    private Shield shield;
    private Armor armor;
    public Knight(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }

    public Sword Sword
    {
        get { return sword; }
        set
        {
            if (sword == null)
                sword = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee la espada");
            }
        }
    }
    public Shield Shield
    {
        get { return shield; }
        set
        {
            if (shield == null)
                shield = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el escudo");
            }
        }
    }

    public Armor Armor
    {
        get { return armor; }
        set
        {
            if (armor == null)
                armor = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee armadura");
            }
        }
    }

    public int AttackValue
    {
        get
        {
            return Sword.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Armor.DefenseValue + Shield.DefenseValue;
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