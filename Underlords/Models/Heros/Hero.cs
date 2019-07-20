using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Model.Skills;
using Underlords.Models;

namespace Underlords.Model
{
    public class Hero : Chess
    {
        public Skill Skill { get; set; }
        public int CurrentLevel { get; set; }
        public int MaxLevel { get; set; } = 3;
        public int Cost { get; set; }
        public List<Underlord> Underlord { get; set; }
    }
}