using System;

namespace Underlords.Model.Races
{
    public class DemonHunter : Underlord
    {
        public DemonHunter()
        {
            Description = "Invalidate Opponent's Demon";
            LevelUpdateNumber = 1;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Invalidate opponent's Demon
                    break;
                case 2:
                    //Invalidate opponent's Demon. Demon Get +50% Pure Damage
                    break;
            }

            throw new NotImplementedException();
        }
    }
}