using System;

namespace Underlords.Model.Races
{
    public class Druid : Underlord
    {
        public Druid()
        {
            Description = "Update An Ally Druid Level";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Update a random lowest level ally Druid
                    break;
                case 2:
                    //Update 2 random lowest level ally Druid
                    break;
            }

            throw new NotImplementedException();
        }
    }
}