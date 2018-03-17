using PetCounter.Logic.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCounter.Logic.Util
{
    public static class ObjectToJson
    {
        public static string BattlePetToJson(BattlePetInfo battlePet)
        {
            return JsonConvert.SerializeObject(battlePet, Formatting.Indented);
        }
    }
}
