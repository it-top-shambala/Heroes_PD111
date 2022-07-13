namespace Heroes_PD111.Lib;

public interface IMage
{
    public int Mana { get; set; }
    
    public void MageAttack(Hero enemy);
}
