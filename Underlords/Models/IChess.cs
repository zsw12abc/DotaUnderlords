namespace Underlords.Models
{
    public interface IChess
    {
        string Name { get; set; }
        int MaxHP { get; set; }
        int CurrentHP { get; set; }
        int HpRegSpeed { get; set; }
        int MaxMana { get; set; }
        int CurrentMana { get; set; }
        int ManaRegSpeed { get; set; }
        int Armor { get; set; }
        int MagicResistance { get; set; }
        int MoveSpeed { get; set; }
        float Evasion { get; set; }
        double AttackSpeed { get; set; }
        int MinAttackDamage { get; set; }
        int MaxAttackDamage { get; set; }
        int DPS { get; set; }
        float CriticalRate { get; set; }
        float CriticalDamage { get; set; }
        int AttackRange { get; set; }
        bool IsRange { get; set; }
        bool IsSilenced { get; set; }
        bool IsDisarmed { get; set; }
        bool IsStunned { get; set; }
        bool IsHexed { get; set; }
        void Move();
        void Attack();
    }
}