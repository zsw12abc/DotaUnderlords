namespace Underlords.Model.Skills
{
    public abstract class Skill : ISkill
    {
        public Skill()
        {
            Name = GetType().Name;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int CD { get; set; }
        public int ManaCost { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public bool IsRandom { get; set; }
        public bool IsMagicDamage { get; set; }
        public bool IsPhysicalDamage { get; set; }
        public bool IsPureDamage { get; set; }
        public abstract void Use(int level);
    }
}