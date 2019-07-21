using System;
using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;
using Underlords.Models;
using Underlords.Models.Items;

namespace Underlords.Model
{
    public abstract class Hero : Chess
    {
        protected Hero(int currentLevel)
        {
            CurrentLevel = currentLevel;
            HpRegSpeed = 0;
            MaxLevel = 3;
        }

        public List<Skill> Skills { get; set; }
        public int CurrentLevel { get; set; }
        public int MaxLevel { get; }
        public int Cost { get; set; }
        public List<Underlord> Underlords { get; set; }
        public Item Item { get; set; } = null;

        public override void Attack(Chess target)
        {
            var random = new Random();
            var attackDamage = random.Next(MinAttackDamage, MaxAttackDamage);
            if (target.CurrentHP <= attackDamage)
            {
                Kill(target);
                CurrentMana = CurrentMana + attackDamage > MaxMana
                    ? MaxMana
                    : CurrentMana + attackDamage;
            }
            else
            {
                target.CurrentHP -= attackDamage;
                if (target.GetType() == typeof(Hero))
                    target.CurrentMana = target.CurrentMana + attackDamage / 2 > target.MaxMana
                        ? MaxMana
                        : target.CurrentMana + attackDamage / 2;

                CurrentMana = CurrentMana + attackDamage > MaxMana
                    ? MaxMana
                    : CurrentMana + attackDamage;
            }
        }

        public abstract void ReleaseSkill(Chess target);
    }
}