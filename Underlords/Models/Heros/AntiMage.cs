using System;
using System.Collections.Generic;
using Underlords.Model.Skills;

namespace Underlords.Model
{
    public class AntiMage : Hero
    {
        public AntiMage(int level)
        {
            MaxHP = 500 * level;
            MaxMana = 0;
            CurrentMana = 0;
            AttackSpeed = 1.2;
            MoveSpeed = 310;
            AttackRange = 1;
            MagicResistance = 10 * level;
            Armor = 5;
            MinAttackDamage = (int) (42 * Math.Pow(2, level - 1));
            MaxAttackDamage = (int) (55 * Math.Pow(2, level - 1));
            Skills = new List<Skill> {new ManaBreak()};
            switch (level)
            {
                case 1:
                    DPS = 42;
                    break;
                case 2:
                    DPS = 83;
                    break;
                case 3:
                    DPS = 167;
                    break;
            }
        }

        public override void Attack()
        {
            base.Attack();
            UseSkill(CurrentLevel);
        }


        public override void UseSkill(int level)
        {
            foreach (var skill in Skills) skill.Use(level);
        }
    }
}