using Underlords.Models.ChessBoard;

namespace Underlords.Models
{
    public class Chess
    {
        public string Name { get; set; }

        public int HP { get; set; }
        public int HpRegSpeed { get; set; }
        public int Mana { get; set; }
        public int ManaRegSpeed { get; set; }

        public int Armor { get; set; }
        public int MagicResistance { get; set; }

        public int MoveSpeed { get; set; }
        public Position Position { get; set; }

        public float DodgeRate { get; set; }

        public float AttackSpeed { get; set; }
        public int AttackDamage { get; set; }
        public float CriticalRate { get; set; }
        public float CriticalDamage { get; set; }
        public int AttackRange { get; set; }
        public bool IsRange { get; set; }


        public bool IsSilenced { get; set; }
        public bool IsDisarmed { get; set; }
        public bool IsStunned { get; set; }
        public bool IsHexed { get; set; }
    }
}