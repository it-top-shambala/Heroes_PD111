using Heroes_PD111.Lib.Human;
using Xunit;

namespace Heroes_PD111.Lib.Test;

public class HumanWarriorTest
{
    [Fact]
    public void Create_HumanWarrior_Health_Test()
    {
        var expectedHealth = 100;
        
        var hero = new HumanWarrior("");
        var actualHealth = hero.Health;
        
        Assert.Equal(expectedHealth, actualHealth);
    }
    
    [Fact]
    public void Create_HumanWarrior_Damage_Test()
    {
        var expectedDamage = 100;
        
        var hero = new HumanWarrior("");
        var actualDamage = hero.Damage;
        
        Assert.Equal(expectedDamage, actualDamage);
    }
    
    [Fact]
    public void HumanMage_WarriorAttack_Test()
    {
        var enemy = new HumanWarrior("");
        var hero = new HumanWarrior("");
        
        hero.WarriorAttack(enemy);

        var expected = 0;
        var actual = enemy.Health;
        
        Assert.Equal(expected, actual);
    }
}
