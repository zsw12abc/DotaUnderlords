namespace Underlords.Model.Skills
{
    public abstract class Skill
    {
        public Skill(int skillLevel)
        {
            Name = GetType().Name;
            SkillLevel = skillLevel;
            if (IsPassive)
            {
                CD = 0;
                ManaCost = 0;
            }
        }

        public int SkillLevel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CD { get; set; }
        public int ManaCost { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public bool IsPassive { get; set; }
        public bool IsRandom { get; set; }
        public bool IsMagicDamage { get; set; }
        public bool IsPhysicalDamage { get; set; }
        public bool IsPureDamage { get; set; }
        public bool IsActive { get; set; } = true;
    }
}