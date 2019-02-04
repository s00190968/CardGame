using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    public class TrapCard : Card
    {
        public TrapCard(string name, int stars, string id, Rarity rarity, string description) : base(name, stars, id, rarity, description)
        {
            Type = AllTypes.Trap;//this comes from the parent class Card
        }
    }
}
