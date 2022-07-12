namespace Heroes_PD111.Lib;

public abstract class Hero
{
    protected int Health;
    protected int Damage;
    protected string Name;

    protected Hero(string name)
    {
        Name = name;
    }
}
