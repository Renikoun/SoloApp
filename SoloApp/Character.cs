using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloApp
{
    //Класс
    class Character
    {
        private string CharName { get; set; }
        private EyeColor EyesColor { get; set; }
        private PlotRole Role { get; set; }
        private BattleSpecialty Spec { get; set; }
        private MagicColor MagicColor { get; set; }
        private Race Race { get; set; }
        private byte PowerLevel { get; set; }
        //Конструктор
        public Character(string name, EyeColor eyesColor, PlotRole role, BattleSpecialty battleSpec, MagicColor magicColor, Race race, byte powerN)
        {
            CharName = name;
            EyesColor = eyesColor;
            Role = role;
            Spec = battleSpec;
            MagicColor = magicColor;
            Race = race;
            PowerLevel = powerN;
        }
        //Принтануть всех персонажей
        public void PrintChar()
        {
            Console.WriteLine($"{CharName}, {EyesColor}, {Role}, {Spec}, {MagicColor}, {Race}, {PowerLevel}");
        }
        //Принтануть только хуманов
        public void PrintHumans()
        {
            if (Race == Race.Human)
           Console.WriteLine($"{CharName}, {EyesColor}, {Role}, {Spec}, {MagicColor}, {Race}, {PowerLevel}");
        }
        //Принтануть только вампиров
        public void PrintVamps()
        {
            if (Race == Race.Vampire)
                Console.WriteLine($"{CharName}, {EyesColor}, {Role}, {Spec}, {MagicColor}, {Race}, {PowerLevel}");
        }
    }
//Енумы
enum EyeColor
{
    Black,
    Brown,
    Blue,
    Yellow,
    Red,
    Blind,
    Green,
    Other
}
enum PlotRole
{
    Protagonist,
    Deuteragonist,
    SideCharacter
}
enum BattleSpecialty
{
    Fencer,
    Knight,
    Mage,
    Caster,
    Assassin,
    Unique
}
enum MagicColor
{
        Classic,
        MultiColored,
        SlightlyColored,
        SoulColored
}
enum Race
    {
        Human,
        Elf,
        Demon,
        DemonElf,
        DemonHuman,
        HumanElf,
        Vampire,
        Other
    }
}
