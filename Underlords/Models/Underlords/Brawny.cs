using System;

namespace Underlords.Model.Races
{
    public class Brawny : Underlord
    {
        public Brawny()
        {
            Name = GetType().Name;
            Description = "Increase Max Hp";
            LevelUpdateNumber = 2;
        }

        protected override object GetEffect(int level)
        {
            switch (level)
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