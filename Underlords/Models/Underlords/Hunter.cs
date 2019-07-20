using System;

namespace Underlords.Model.Races
{
    public class Hunter : Underlord
    {
        public Hunter()
        {
            Description = "Quick Attack";
            LevelUpdateNumber = 3;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //20% Quick Attack
                    break;
                case 2:
                    //35% Quick Attack
                    break;
            }

            throw new NotImplementedException();
        }
    }
}