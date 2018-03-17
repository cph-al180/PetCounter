using PetCounter.Logic.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Combat
{
    public class BattlePetSuggestionController
    {
        public BattlePetCollectionStatistics GetOpponentStatistics(PetBattler opponent)
        {
            BattlePetSpecies[] opponentMoveTypes = new BattlePetSpecies[(opponent.battlePets.Length * opponent.battlePets[0].battlePetInfo.battlePetMoveSet.moves.Length)];
            BattlePetSpecies[] opponentSpecies = new BattlePetSpecies[opponent.battlePets.Length];
            BattlePetCollectionStatistics opponentStatistics = new BattlePetCollectionStatistics();

            int battlePetMoveIndex = 0;

            for(int i = 0; i < opponent.battlePets.Length; i++)
            {
                opponentSpecies[i] = opponent.battlePets[i].battlePetInfo.battlePetSpecies;

                for(int j = 0; j < opponent.battlePets[i].battlePetInfo.battlePetMoveSet.moves.Length; j++)
                {
                    opponentMoveTypes[battlePetMoveIndex] = opponent.battlePets[i].battlePetInfo.battlePetMoveSet.moves[j].damageType;
                    battlePetMoveIndex++;
                }
            }

            opponentStatistics.speciesOfBattlePets = opponentSpecies;
            opponentStatistics.speciesOfBattlePetMoves = opponentMoveTypes;
            return opponentStatistics;
        }
    }
}
