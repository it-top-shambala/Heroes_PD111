using Heroes_PD111.Lib;
using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.CliLib;

public static class CliHero
{
    public static void PrintHeroInfo(Hero hero)
    {
        var message = $"[{hero.GetType().Name}]: Name - {hero.Name}, Health - {hero.Health}, Damage - {hero.Damage}";
        CLI.PrintLine(message, ConsoleColor.Magenta);
    }
}
