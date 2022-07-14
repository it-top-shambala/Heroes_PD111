namespace Heroes_PD111.Lib.Base;

public abstract class Hero
{
    protected int _health;
    public int Health
    {
        get => _health;
        set => _health = value <= 0 ? 0 : value;
    }
    
    protected int _damage;
    public int Damage { get => _damage; }

    protected string _name;
    public string Name { get => _name; }

    protected Hero(string name)
    {
        _name = name;
    }

    public void GetDamage(int damage)
    {
        Health -= damage;
    }
}
