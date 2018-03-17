using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Model
{
    public class BattlePetMove
    {
        public string moveName;
        public string moveID;
        public int minimumDamage;
        public int maximumDamage;
        public BattlePetSpecies damageType;
        public int moveCooldown;
        public BattlePetMoveType battlePetMoveType;
        public int moveAccuracy;

        public BattlePetMove() { }

        public BattlePetMove(string moveName, string moveID, int minimumDamage, int maximumDamage, BattlePetSpecies damageType, int moveCooldown, BattlePetMoveType battlePetMoveType, int moveAccuracy)
        {
            this.moveName = moveName;
            this.moveID = moveID;
            this.minimumDamage = minimumDamage;
            this.maximumDamage = maximumDamage;
            this.damageType = damageType;
            this.moveCooldown = moveCooldown;
            this.battlePetMoveType = battlePetMoveType;
            this.moveAccuracy = moveAccuracy;
        }
    }
}
