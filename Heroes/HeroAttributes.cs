﻿namespace ConsoleRPG.Heroes
{
    public class HeroAttributes
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;

        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
    }
}