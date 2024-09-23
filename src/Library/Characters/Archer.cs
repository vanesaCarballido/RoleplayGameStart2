namespace Ucu.Poo.RoleplayGame;

public class Archer:ICharacter
{
    private int health = 100;
    private Bow bow;
    private Helmet helmet;
    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public Bow Bow 
    {
        get { return bow; }
        set
        {
            if (bow == null)
                bow = value;
            else
            {
                Console.WriteLine($"{this.Name} ya posee el arco");
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

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
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