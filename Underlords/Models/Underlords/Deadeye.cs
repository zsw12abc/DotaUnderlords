using System;

namespace Underlords.Model.Races
{
    public class Deadeye : Underlord
    {
        public Deadeye()
        {
            Description = "Focus on lowest-health enemy";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Focus on Lowest-health enemy
                    break;
            }

            throw new NotImplementedException();
        }
    }
}