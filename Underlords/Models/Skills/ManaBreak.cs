using Underlords.Models;

namespace Underlords.Model.Skills
{
    public class ManaBreak : Skill
    {
        public ManaBreak(int skillLevel) : base(skillLevel)
        {
            Description = "Burn 30 * level mana, deal with half mana damage";
            IsPassive = true;
            Range = 1;
            IsRandom = false;
            IsMagicDamage = false;
            IsPhysicalDamage = true;
            IsPureDamage = false;
            IsActive = true;
        }

        public void BurnMana(Chess target)
        {
            if (target.CurrentMana >= 30 * SkillLevel)
            {
                target.CurrentMana = target.CurrentMana - 30 * SkillLevel;
                target.CurrentHP = target.CurrentHP - 30 * SkillLevel / 2;
            }
            else
            {
                target.CurrentHP = target.CurrentHP - target.CurrentMana / 2;
                target.CurrentMana = 0;
            }
        }
    }
}