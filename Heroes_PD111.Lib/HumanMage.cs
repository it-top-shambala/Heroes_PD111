namespace Heroes_PD111.Lib;

public class HumanMage : Human, IMage
{
    public int Mana { get; set; }
    
    public HumanMage(string name) : base(name)
    {
        Mana = 50;
    }

    public void MageAttack(Hero enemy)
    {
        enemy.GetDamage(Damage + Mana);
    }
}
