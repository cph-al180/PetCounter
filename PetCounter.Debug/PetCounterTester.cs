using PetCounter.Logic.Factory;
using PetCounter.Logic.Model;
using PetCounter.Logic.Storage;

namespace PetCounter.Debug
{
    public class PetCounterTester
    {
        private static BattlePetMoveStorage battlePetMoveStorage;
        private static BattlePetMoveSetFactory battlePetMoveSetFactory;
        private static BattlePetInfoStorage battlePetStorage;

        static void Main(string[] args)
        {
            Setup();
            BattlePetInfo pet1 = (BattlePetInfo)battlePetStorage.GetItemByID("1");
            BattlePetInfo pet2 = (BattlePetInfo)battlePetStorage.GetItemByID("1");
            BattlePetInfo pet3 = (BattlePetInfo)battlePetStorage.GetItemByID("1");

            PetBattler opponent = new PetBattler(new BattlePet(pet1, 25), new BattlePet(pet2, 25), new BattlePet(pet3, 25));
        }

        private static void Setup()
        {
            BattlePetMoveStorage battlePetMoveStorage = new BattlePetMoveStorage();
            BattlePetMoveSetFactory battlePetMoveSetFactory = new BattlePetMoveSetFactory();
            BattlePetInfoStorage battlePetStorage = new BattlePetInfoStorage(battlePetMoveStorage, battlePetMoveSetFactory);
        }
    }
}
