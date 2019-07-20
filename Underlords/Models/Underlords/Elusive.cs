using System;

namespace Underlords.Model.Races
{
    public class Elusive : Underlord
    {
        public Elusive()
        {
            Description = "Get Evasion";
            LevelUpdateNumber = 3;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Get 20% Evasion
                    break;
                case 2:
                    //Get 45% Evasion
                    break;
                case 3:
                    //Get 75% Evasion
                    break;
            }

            throw new NotImplementedException();
        }
    }
}