using PetCounter.Logic.Combat;
using PetCounter.Logic.Factory;
using PetCounter.Logic.Model;
using PetCounter.Logic.Storage;
using PetCounter.Logic.Util;
using System;

namespace PetCounter.Debug
{
    public class PetCounterTester
    {
        private static BattlePetMoveStorage battlePetMoveStorage;
        private static BattlePetMoveSetFactory battlePetMoveSetFactory;
        private static BattlePetInfoStorage battlePetStorage;
        private static BattlePetSuggestionController battlePetSuggestionController;

        static void Main(string[] args)
        {
            Setup();
            BattlePetInfo pet1 = (BattlePetInfo)battlePetStorage.GetItemByID("1");
            BattlePetInfo pet2 = (BattlePetInfo)battlePetStorage.GetItemByID("1");
            BattlePetInfo pet3 = (BattlePetInfo)battlePetStorage.GetItemByID("1");

            PetBattler opponent = new PetBattler(new BattlePet(pet1, 25), new BattlePet(pet2, 25), new BattlePet(pet3, 25));

            BattlePetCollectionStatistics stats = battlePetSuggestionController.GetOpponentStatistics(opponent);

            Console.WriteLine(ObjectToJson.BattlePetCollectionStatistics(stats));

            Console.ReadLine();
        }

        private static void Setup()
        {
            battlePetMoveStorage = new BattlePetMoveStorage();
            battlePetMoveSetFactory = new BattlePetMoveSetFactory();
            battlePetStorage = new BattlePetInfoStorage(battlePetMoveStorage, battlePetMoveSetFactory);
            battlePetSuggestionController = new BattlePetSuggestionController();
        }
    }
}
