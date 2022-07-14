using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Orc;

public class OrcMage : Orc, IMage
{
    public int Mana { get; set; }
    
    public OrcMage(string name) : base(name)
    {
        Mana = 50;
    }

    public void MageAttack(Hero enemy)
    {
        enemy.GetDamage(Damage + Mana);
    }
}
