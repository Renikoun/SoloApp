using System;
using System.Linq;
using System.Collections.Generic;
namespace SoloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Персонажи
            Character rikkard = new Character(
                "Rikkard Kronell",
                EyeColor.Brown, 
                PlotRole.Protagonist, 
                BattleSpecialty.Unique, 
                MagicColor.SlightlyColored, 
                Race.Human, 
                4
                );
            Character veiland = new Character("Veiland Milten", EyeColor.Blue, PlotRole.Deuteragonist, BattleSpecialty.Knight, MagicColor.SoulColored, Race.Human, 8);
            Character dalara = new Character("Dalara Ala'Irei", EyeColor.Other, PlotRole.Deuteragonist, BattleSpecialty.Unique, MagicColor.SlightlyColored, Race.DemonElf, 7);
            Character kyle = new Character("Kyle", EyeColor.Blind, PlotRole.SideCharacter, BattleSpecialty.Mage, MagicColor.Classic, Race.DemonHuman, 7);
            Character fredericka = new Character("Fredericka Astoni", EyeColor.Green, PlotRole.Deuteragonist, BattleSpecialty.Mage, MagicColor.SoulColored, Race.Human, 5);
            Character jaden = new Character("Jaden", EyeColor.Blue, PlotRole.SideCharacter, BattleSpecialty.Caster, MagicColor.SoulColored, Race.Human, 9);
            Character elsdeft = new Character("Elsdeft", EyeColor.Other, PlotRole.SideCharacter, BattleSpecialty.Caster, MagicColor.MultiColored, Race.Elf, 8);
            Character lira = new Character("Lira", EyeColor.Blue, PlotRole.SideCharacter, BattleSpecialty.Unique, MagicColor.SoulColored, Race.Vampire, 10);
            Character raven = new Character("Raven", EyeColor.Green, PlotRole.SideCharacter, BattleSpecialty.Assassin, MagicColor.Classic, Race.Human, 5);
            Character kord = new Character("Kord Dakkari", EyeColor.Black, PlotRole.SideCharacter, BattleSpecialty.Fencer, MagicColor.Classic, Race.Human, 3);
            Character dogma = new Character("Dogma", EyeColor.Other, PlotRole.SideCharacter, BattleSpecialty.Caster, MagicColor.SoulColored, Race.Elf, 10);
            Character olrik = new Character("Olrik", EyeColor.Yellow, PlotRole.SideCharacter, BattleSpecialty.Mage, MagicColor.SoulColored, Race.Human, 9);
            Character aphyr = new Character("Aphyr Allein", EyeColor.Red, PlotRole.SideCharacter, BattleSpecialty.Assassin, MagicColor.Classic, Race.Vampire, 9);
            Character eri = new Character("Erika Starlight", EyeColor.Blue, PlotRole.SideCharacter, BattleSpecialty.Unique, MagicColor.SlightlyColored, Race.Human, 7);
            Character affyn = new Character("Affyn II", EyeColor.Black, PlotRole.SideCharacter, BattleSpecialty.Knight, MagicColor.MultiColored, Race.Human, 7);
            Character avelius = new Character("Avelius", EyeColor.Yellow, PlotRole.SideCharacter, BattleSpecialty.Unique, MagicColor.SoulColored, Race.Other, 11);
            List<Character> list = new List<Character> {rikkard, veiland, dalara, kyle, fredericka, jaden, elsdeft, lira, raven, kord, dogma, olrik, aphyr, eri, affyn, avelius };
            Console.WriteLine("\nMethod - Print All Characters:\n");
            foreach (Character jj in list)
            {
                jj.PrintChar();
            }
            Console.WriteLine("\nMethod - Print All Humans:\n");
            foreach (Character jj in list)
            {   
                jj.PrintHumans();
            }
            Console.WriteLine("\nMethod - Print All Vampires:\n");
            foreach (Character jj in list)
            {
                jj.PrintVamps();
            }
            Console.ReadKey();
        }
    }
}
