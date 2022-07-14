namespace Heroes_PD111.Lib.Base;

public interface IMage
{
    public int Mana { get; set; }
    
    public void MageAttack(Hero enemy);
}
