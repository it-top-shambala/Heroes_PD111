using Xunit;

namespace Heroes_PD111.Lib.Test;

public class HumanMageTest
{
    [Fact]
    public void Create_HumanMage_Health_Test()
    {
        var expectedHealth = 100;
        
        var hero = new HumanMage("");
        var actualHealth = hero.Health;
        
        Assert.Equal(expectedHealth, actualHealth);
    }
    
    [Fact]
    public void Create_HumanMage_Damage_Test()
    {
        var expectedDamage = 100;
        
        var hero = new HumanMage("");
        var actualDamage = hero.Damage;
        
        Assert.Equal(expectedDamage, actualDamage);
    }
    
    [Fact]
    public void HumanMage_MageAttack_Test()
    {
        var enemy = new HumanMage("");
        var hero = new HumanMage("");
        
        hero.MageAttack(enemy);

        var expected = 0;
        var actual = enemy.Health;
        
        Assert.Equal(expected, actual);
    }
}
