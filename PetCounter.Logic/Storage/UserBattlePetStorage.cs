using PetCounter.Logic.Interface;
using PetCounter.Logic.Model;
using System;
using System.Collections.Generic;

namespace PetCounter.Logic.Storage
{
    public class UserBattlePetStorage : IStorage
    {
        public List<BattlePet> battlePetCollection { get; private set; }

        public UserBattlePetStorage()
        {
            battlePetCollection = new List<BattlePet>();
        }

        public void AddPetToCollection(BattlePet battlePet)
        {
            battlePetCollection.Add(battlePet);
        }

        public void AddPetsToCollection(BattlePet[] battlePets)
        {
            foreach(BattlePet battlePet in battlePets)
            {
                battlePetCollection.Add(battlePet);
            }
        }

        public object GetItemByID(string ID)
        {
            foreach (BattlePet battlePet in battlePetCollection)
            {
                if (battlePet.battlePetInfo.battlePetId == ID)
                {
                    return battlePet;
                }
            }
            return null;
        }
    }
}
