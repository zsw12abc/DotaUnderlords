using System;
using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Models;

namespace Underlords.Model
{
    public class Razor : Hero
    {
        public Razor(int currentLevel) : base(currentLevel)
        {
            Cost = 1;
            Underlords = new List<Underlord> {new Primordial(), new Mage()};
        }


        public override void ReleaseSkill(Chess target)
        {
            throw new NotImplementedException();
        }
    }
}