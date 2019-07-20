using System;

namespace Underlords.Model.Races
{
    public class BloodBound : Underlord
    {
        public BloodBound()
        {
            Name = GetType().Name;
            Description = "Get Bounce Damage after other BloodBound died";
            LevelUpdateNumber = 2;
        }

        protected override object GetEffect(int level)
        {
            switch (level)
            {
                case 1:
                    //Get +100% Attack Damage
                    break;
            }

            throw new NotImplementedException();
        }
    }
}