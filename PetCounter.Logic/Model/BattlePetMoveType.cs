using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Model
{
    public enum BattlePetMoveType
    {
        DirectDamage,
        MultiTurnMove,
        Utility,
        DamageOverTime,
        DamageIncreaseDebuff,
        EnemyDamageDecreaseDebuff,
        Weather
    }
}
