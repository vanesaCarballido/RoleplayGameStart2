namespace Ucu.Poo.RoleplayGame;

public class Dwarf:ICharacter
{
    private int health = 100;

    public Dwarf(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }

    

    public int AttackValue
    {
        get
        {
            return iitem.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return iitem.DefenseValue + iitem.DefenseValue;
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
