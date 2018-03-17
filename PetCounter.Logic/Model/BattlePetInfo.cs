using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Model
{
    public class BattlePetInfo
    {
        public string battlePetId;
        public string battlePetName;
        public BattlePetSpecies battlePetSpecies;
        public BattlePetMoveSet battlePetMoveSet;
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BattlePetInfo() { }

        /// <summary>
        /// BattlePet constructor not containing level.
        /// </summary>
        /// <param name="battlePetId">BattlePet id</param>
        /// <param name="battlePetname">BattlePet name</param>
        /// <param name="battlePetspecies">BattlePet species</param>
        /// <param name="battlePetmoves">BattlePet move set</param>
        public BattlePetInfo(string battlePetId, string battlePetName, BattlePetSpecies battlePetSpecies, BattlePetMoveSet battlePetMoveSet)
        {
            this.battlePetId = battlePetId;
            this.battlePetName = battlePetName;
            this.battlePetSpecies = battlePetSpecies;
            this.battlePetMoveSet = battlePetMoveSet;
        }

    }
}
