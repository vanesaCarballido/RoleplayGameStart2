namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    int Health { get; set; }
    string Name { get; set; }
    int AttackValue { get; }
    List<IItem> ListOfItems { get; } 
    void ReceiveAttack(int power);
    int DefenseValue { get; }
    void Cure();
    


}