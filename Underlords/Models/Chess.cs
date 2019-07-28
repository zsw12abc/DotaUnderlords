using System;
using Underlords.Models.ChessBoard;

namespace Underlords.Models
{
    public class Chess : IChess
    {
        public Chess()
        {
            Name = GetType().Name;
            CurrentMana = 0;
            IsRange = AttackRange > 1;
            CurrentHP = MaxHP;
        }

        public Position Position { get; set; }

        public string Name { get; set; }
        public double MaxHP { get; set; }
        public double CurrentHP { get; set; }
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
        public bool IsDead { get; set; }
        public bool IsEnemy { get; set; } = false;
        public Chess KilledBy { get; set; }
        public Chess Target { get; set; }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public virtual void Attack(Chess target)
        {
            var random = new Random();
            var attackDamage = random.Next(MinAttackDamage, MaxAttackDamage);
            if (target.CurrentHP <= attackDamage)
                Kill(target);
            else
                target.CurrentHP -= attackDamage;
        }

        public virtual void Kill(Chess target)
        {
            target.IsDead = true;
            target.KilledBy = target;
        }

        public void initialize()
        {
            CurrentHP = MaxHP;
            IsRange = AttackRange > 1;
        }
    }
}