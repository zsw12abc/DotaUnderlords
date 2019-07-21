using Underlords.Models;

namespace Underlords.Model.Skills
{
    public class Bloodrage : Skill
    {
        public Bloodrage(int skillLevel) : base(skillLevel)
        {
            Description =
                "Take 7% of Max HP every seconds, and every % HP lost, gain 5% attack speed, regains 35% of Max Hp after skill enemy";
            IsPassive = true;
            Damage = 0;
            IsRandom = false;
            IsMagicDamage = false;
            IsPhysicalDamage = false;
        }

        public void Rage(Chess target)
        {
            target.AttackSpeed = (1 - target.CurrentHP / target.MaxHP) * 5 * 100 + target.AttackSpeed;
        }
    }
}