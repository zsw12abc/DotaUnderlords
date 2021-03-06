using System;

namespace Underlords.Model.Races
{
    public class Brawny : Underlord
    {
        public Brawny()
        {
            Description = "Increase Max Hp";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Update 200 Max HP
                    break;
                case 2:
                    //Update 500 Max HP
                    break;
            }

            throw new NotImplementedException();
        }
    }
}