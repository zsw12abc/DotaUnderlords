using System;

namespace Underlords.Model.Races
{
    public class WarlockAlliance : Underlord
    {
        public WarlockAlliance()
        {
            Description = "After using skill, Link with lowest percentage HP ally and get skill regeneration for 3s";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //After using skill, Link with lowest percentage HP ally and get + 50% skill regeneration for 3s
                    break;
                case 2:
                    //After using skill, Link with lowest percentage HP ally and get + 80% skill regeneration for 3s
                    break;
                case 3:
                    //After using skill, Link with lowest percentage HP ally and get + 130% skill regeneration for 3s
                    break;
            }

            throw new NotImplementedException();
        }
    }
}