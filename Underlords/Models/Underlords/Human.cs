using System;

namespace Underlords.Model.Races
{
    public class Human : Underlord
    {
        public Human()
        {
            Description = "Silence target";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //20% Chance to Silence Target for 4s
                    break;
                case 2:
                    //44% Chance to Silence Target for 4s
                    break;
                case 3:
                    //66% Chance to Silence Target for 4s
                    break;
            }

            throw new NotImplementedException();
        }
    }
}