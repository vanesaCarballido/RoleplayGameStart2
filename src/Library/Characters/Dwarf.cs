namespace Ucu.Poo.RoleplayGame;

public class Dwarf:ICharacter
{
    private int health = 100;
    private Axe axe;
    private Helmet helmet;
    private Shield shield;

    public Dwarf(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public Axe Axe
    {
        get { return axe; }
        set
        {
            if (axe == null)
                axe = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el hacha");
            }
        }
    }
    public Helmet Helmet
    {
        get { return helmet; }
        set
        {
            if (helmet == null)
                helmet = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el casco");
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

    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Shield.DefenseValue + Helmet.DefenseValue;
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