using System;
using Underlords.Models.ChessBoard;

namespace Underlords.Models
{
    public class Chess : IChess
    {
        public Chess()
        {
            Name = GetType().Name;
            IsRange = AttackRange > 1;
        }

        public Position Position { get; set; }

        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int HpRegSpeed { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public int ManaRegSpeed { get; set; }
        public int Armor { get; set; }
        public int MagicResistance { get; set; }
        public int MoveSpeed { get; set; }
        public float Evasion { get; set; }
        public double AttackSpeed { get; set; }
        public int MinAttackDamage { get; set; }
        public int MaxAttackDamage { get; set; }
        public int DPS { get; set; }
        public float CriticalRate { get; set; }
        public float CriticalDamage { get; set; }
        public int AttackRange { get; set; }
        public bool IsRange { get; set; }
        public bool IsSilenced { get; set; }
        public bool IsDisarmed { get; set; }
        public bool IsStunned { get; set; }
        public bool IsHexed { get; set; }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public virtual void Attack(Chess target)
        {
            var random = new Random();
            target.CurrentHP -= random.Next(MinAttackDamage, MaxAttackDamage);
        }
    }
}