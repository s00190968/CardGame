using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    public class SpellCard:Card
    {
        public SpellCard(string name, int stars, string id, Rarity rarity, string description) : base(name, stars, id, rarity, description)
        {
            Type = AllTypes.Spell;//this comes from the parent class Card
        }
    }
}
