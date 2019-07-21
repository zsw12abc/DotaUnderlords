using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;
using Underlords.Models;

namespace Underlords.Model
{
    public class AntiMage : Hero
    {
        public AntiMage(int currentLevel) : base(currentLevel)
        {
            Cost = 1;
            Armor = 5;
            MaxMana = 0;
            CurrentMana = 0;
            AttackSpeed = 1.2;
            MoveSpeed = 310;
            AttackRange = 1;
            MaxHP = 500 * currentLevel;
            MagicResistance = 10 * currentLevel;
            Skills = new List<Skill> {new ManaBreak(CurrentLevel)};
            Underlords = new List<Underlord> {new DemonHunter(), new Elusive()};
            switch (currentLevel)
            {
                case 1:
                    DPS = 42;
                    MinAttackDamage = 42;
                    MaxAttackDamage = 55;
                    break;
                case 2:
                    DPS = 83;
                    MinAttackDamage = 42;
                    MaxAttackDamage = 55;
                    break;
                case 3:
                    DPS = 167;
                    MinAttackDamage = 42;
                    MaxAttackDamage = 55;
                    break;
            }
        }

        public override void Attack(Chess target)
        {
            base.Attack(target);
            ReleaseSkill(target);
        }

        public override void ReleaseSkill(Chess target)
        {
            new ManaBreak(CurrentLevel).BurnMana(target);
        }
    }
}