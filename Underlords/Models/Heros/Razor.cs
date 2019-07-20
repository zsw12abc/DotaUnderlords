using System;
using System.Collections.Generic;
using Underlords.Model.Races;

namespace Underlords.Model
{
    public class Razor : Hero
    {
        public Razor()
        {
            Cost = 1;
            Underlords = new List<Underlord> {new Primordial(), new Mage()};
        }

        public override void UseSkill(int level)
        {
            throw new NotImplementedException();
        }
    }
}