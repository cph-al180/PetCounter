using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCounter.Logic.Model;

namespace PetCounter.Logic.Factory
{
    public class BattlePetMoveSetFactory
    {
        public BattlePetMoveSet CreateBattlePetMoveSet(
            BattlePetMove move1, 
            BattlePetMove move2, 
            BattlePetMove move3, 
            BattlePetMove move4, 
            BattlePetMove move5, 
            BattlePetMove move6)
        {
            BattlePetMoveSet battlePetMoveSet = new BattlePetMoveSet();
            battlePetMoveSet.moves = new BattlePetMove[] { move1, move2, move3, move4, move5, move6 };
            return battlePetMoveSet;
        }
    }
}
