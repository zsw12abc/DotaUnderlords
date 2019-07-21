using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;
using Underlords.Models;

namespace Underlords.Model
{
    public abstract class Hero : Chess
    {
        protected Hero(int currentLevel)
        {
            CurrentLevel = currentLevel;
            HpRegSpeed = 0;
            MaxLevel = 3;
        }

        public List<Skill> Skills { get; set; }
        public int CurrentLevel { get; set; }
        public int MaxLevel { get; }
        public int Cost { get; set; }
        public List<Underlord> Underlords { get; set; }

        public abstract void ReleaseSkill(Chess target);
    }
}