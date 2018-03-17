using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Model
{
    public class PetBattler
    {
        public BattlePet[] battlePets { get; private set; }

        public PetBattler(BattlePet pet1, BattlePet pet2, BattlePet pet3)
        {
            this.battlePets = new BattlePet[] { pet1, pet2, pet3 };
        }

    }
}
