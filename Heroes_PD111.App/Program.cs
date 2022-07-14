using Heroes_PD111.CliLib;
using Heroes_PD111.Lib;
using Heroes_PD111.Lib.Human;

var hero = new HumanMage("Mage");
var enemy = new HumanMage("Enemy");

CLI.PrintInfo("Добро пожаловать ...");

CliHero.PrintHeroInfo(hero);
CliHero.PrintHeroInfo(enemy);

hero.MageAttack(enemy);

CliHero.PrintHeroInfo(hero);
CliHero.PrintHeroInfo(enemy);
