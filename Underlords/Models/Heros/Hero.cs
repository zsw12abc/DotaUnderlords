using System.Collections.Generic;
using Underlords.Model.Jobs;
using Underlords.Model.Races;
using Underlords.Model.Skills;

namespace Underlords.Model
{
    public class Hero
    {
        public string Name { get; set; }
        public int level { get; set; }

        public int Cost { get; set; }

        public int HP { get; set; }
        public int HpRegSpeed { get; set; }
        public int MP { get; set; }
        public int MpRegSpeed { get; set; }
        
        public int Armor { get; set; }
        public int magicResistance { get; set; }

        public int moveSpeed { get; set; }

        public float attackSpeed { get; set; }
        public int attackDamage { get; set; }
        public int attackRange { get; set; }
        public bool isRange { get; set; }

        public Skill Skill { get; set; }
        public List<Job> Jobs { get; set; }
        public Race Race { get; set; }
    }
}