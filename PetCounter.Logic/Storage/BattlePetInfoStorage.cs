using PetCounter.Logic.Factory;
using PetCounter.Logic.Interface;
using PetCounter.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Storage
{
    public class BattlePetInfoStorage : IStorage
    {

        private BattlePetMoveStorage battlePetMoveStorage;
        private BattlePetMoveSetFactory battlePetMoveSetFactory;
        private BattlePetInfo[] battlePets; 

        public BattlePetInfoStorage(BattlePetMoveStorage battlePetMoveStorage, BattlePetMoveSetFactory battlePetMoveSetFactory)
        {
            this.battlePetMoveStorage = battlePetMoveStorage;
            this.battlePetMoveSetFactory = battlePetMoveSetFactory;
            this.battlePets = PopulateBattlePets();
        }

        private BattlePetInfo[] PopulateBattlePets()
        {
            return new BattlePetInfo[]
            {
                new BattlePetInfo("1", "Nexus Whelpling", BattlePetSpecies.Dragonkin, GetBattlePetMoveSet("1", "2", "3", "4", "5", "6")),
                new BattlePetInfo("2", "Anubisath Idol", BattlePetSpecies.Humanoid, GetBattlePetMoveSet("7", "8", "9", "10", "11", "12"))
            };
        }

        public object GetItemByID(string ID)
        {
            foreach (BattlePetInfo battlePet in battlePets)
            {
                if (battlePet.battlePetId == ID)
                {
                    return battlePet;
                }
            }
            return null;
        }

        private BattlePetMoveSet GetBattlePetMoveSet(string move1ID, string move2ID, string move3ID, string move4ID, string move5ID, string move6ID)
        {
            string[] IDs = new string[] { move1ID, move2ID, move3ID, move4ID, move5ID, move6ID };
            BattlePetMove[] moves = new BattlePetMove[IDs.Length];
            int count = 0;
            foreach(string ID in IDs)
            {
                moves[count] = (BattlePetMove)battlePetMoveStorage.GetItemByID(ID);
                count++;
            }
            return battlePetMoveSetFactory.CreateBattlePetMoveSet(moves[0], moves[1], moves[2], moves[3], moves[4], moves[5]);
        }

    }
}
