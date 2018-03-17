using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Model
{
    public class BattlePet
    {
        public BattlePetInfo battlePetInfo { get; private set; }
        public int battlePetLevel { get; private set; }

        public BattlePet(BattlePetInfo battlePetInfo, int battlePetLevel)
        {
            this.battlePetInfo = battlePetInfo;
            if (battlePetLevel > 25 || battlePetLevel < 0)
                throw new ArgumentOutOfRangeException("Pet level " + battlePetLevel + " is not within the accepted range: 0 to 25");
            else
                this.battlePetLevel = battlePetLevel;
        }
    }
}
