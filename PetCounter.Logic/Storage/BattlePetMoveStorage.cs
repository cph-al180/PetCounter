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
            new BattlePetMove("Arcane Storm", "6", 21, 21, BattlePetSpecies.Magic, 3, BattlePetMoveType.Weather, 100),
            new BattlePetMove("Crush", "7", 22, 22, BattlePetSpecies.Humanoid, 0, BattlePetMoveType.DirectDamage, 100),
            new BattlePetMove("Sandstorm", "8", 25, 25, BattlePetSpecies.Flying, 5, BattlePetMoveType.Weather, 100),
            new BattlePetMove("Deflection", "9", 0, 0, BattlePetSpecies.Humanoid, 3, BattlePetMoveType.Defense, 100),
            new BattlePetMove("Demolish", "10", 40, 40, BattlePetSpecies.Mechanical, 3, BattlePetMoveType.DirectDamage, 50),
            new BattlePetMove("Stoneskin", "11", 0, 0, BattlePetSpecies.Magic, 0, BattlePetMoveType.Defense, 100),
            new BattlePetMove("Rupture", "12", 30, 30, BattlePetSpecies.Elemental, 4, BattlePetMoveType.DirectDamage, 100),
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
