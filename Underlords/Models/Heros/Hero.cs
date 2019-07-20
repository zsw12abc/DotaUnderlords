using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;
using Underlords.Models;

namespace Underlords.Model
{
    public abstract class Hero : Chess
    {
        public List<Skill> Skills { get; set; }
        public int CurrentLevel { get; set; }
        public int MaxLevel { get; set; } = 3;
        public int Cost { get; set; }
        public List<Underlord> Underlords { get; set; }

        public abstract void UseSkill(int level);
    }
}