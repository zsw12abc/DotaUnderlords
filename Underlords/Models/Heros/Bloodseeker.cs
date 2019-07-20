using System;
using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;

namespace Underlords.Model
{
    public class Bloodseeker : Hero
    {
        public Bloodseeker(int currentLevel) : base(currentLevel)
        {
            Cost = 1;
            MaxMana = 0;
            MaxHP = 500 * currentLevel;
            AttackSpeed = 170;
            MoveSpeed = 850;
            AttackRange = 1;
            MagicResistance = 20;
            Armor = 5;
            Underlords = new List<Underlord> {new Human(), new Assassin()};
            Skills = new List<Skill> {new Bloodrage()};
            switch (currentLevel)
            {
                case 1:
                    DPS = 29;
                    MinAttackDamage = 40;
                    MaxAttackDamage = 60;

                    break;
                case 2:
                    DPS = 65;
                    MinAttackDamage = 100;
                    MaxAttackDamage = 120;
                    break;
                case 3:
                    DPS = 103;
                    MinAttackDamage = 160;
                    MaxAttackDamage = 190;
                    break;
            }
        }

        public override void UseSkill(int level)
        {
            throw new NotImplementedException();
        }
    }
}