namespace Underlords.Model.Skills
{
    public interface ISkill
    {
        string Name { get; set; }
        string Description { get; set; }
        int CD { get; set; }
        int ManaCost { get; set; }
        int Damage { get; set; }
        int Range { get; set; }
        bool IsRandom { get; set; }
        bool IsMagicDamage { get; set; }
        bool IsPhysicalDamage { get; set; }
        bool IsPureDamage { get; set; }
        void Use(int level);
    }
}