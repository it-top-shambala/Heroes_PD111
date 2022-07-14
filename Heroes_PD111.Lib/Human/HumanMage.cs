using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Human;

public class HumanMage : Human, IMage
{
    public int Mana { get; set; }
    
    public HumanMage(string name) : base(name)
    {
        Mana = 50;
    }

    public void MageAttack(Hero enemy)
    {
        enemy.GetDamage(Damage + Mana); //TODO переименовать GetDamage()
    }
}
