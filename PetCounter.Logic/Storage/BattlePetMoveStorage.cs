using PetCounter.Logic.Interface;
using PetCounter.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Storage
{
    public class BattlePetMoveStorage : IStorage
    {
        public BattlePetMove[] battlePetMoves =
{
            new BattlePetMove("Tail Sweep", "1", 18, 25, BattlePetSpecies.Dragonkin, 0, BattlePetMoveType.DirectDamage, 100),
            new BattlePetMove("Sear Magic", "2", 0, 0, BattlePetSpecies.Magic, 2, BattlePetMoveType.Utility, 100),
            new BattlePetMove("Wild Magic", "3", 18, 25, BattlePetSpecies.Magic, 0, BattlePetMoveType.DamageIncreaseDebuff, 100),
            new BattlePetMove("Frost Breath", "4", 20, 20, BattlePetSpecies.Dragonkin, 0, BattlePetMoveType.DirectDamage, 100),
            new BattlePetMove("Mana Surge", "5", 25, 25, BattlePetSpecies.Magic, 3, BattlePetMoveType.MultiTurnMove, 100),
            new BattlePetMove("Arcane Storm", "6", 21, 21, BattlePetSpecies.Magic, 3, BattlePetMoveType.Weather, 100)
        };

        public object GetItemByID(string ID)
        {
            foreach (BattlePetMove battlePetMove in battlePetMoves)
            {
                if (battlePetMove.moveID == ID)
                {
                    return battlePetMove;
                }
            }
            return null;
        }
    }
}
