using System;

namespace Underlords.Model.Races
{
    public class Knight : Underlord
    {
        public Knight()
        {
            Description = "Reduce physical and magic damage with Knight nearby";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Reduce 15% physical and magic damage, and extra 15% with another Knight nearby
                    break;
                case 2:
                    //Reduce 20% physical and magic damage, and extra 20% with another Knight nearby
                    break;
                case 3:
                    //Reduce 25% physical and magic damage, and extra 25% with another Knight nearby
                    break;
            }

            throw new NotImplementedException();
        }
    }
}