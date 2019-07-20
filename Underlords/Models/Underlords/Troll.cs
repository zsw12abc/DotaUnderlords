using System;

namespace Underlords.Model.Races
{
    public class Troll : Underlord
    {
        public Troll()
        {
            Description = "Gain Attack Speed";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //All Trolls Gain +35 Attack Speed
                    break;
                case 2:
                    //All Trolls Gain +65 Attack Speed, Other Allies Gain +30 attack speed
                    break;
            }

            throw new NotImplementedException();
        }
    }
}