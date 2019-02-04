using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    class MonsterCard : Card
    {
        public MonsterCard(string name, int stars, string id, Rarity rarity, string description) : base(name, stars, id, rarity, description)
        {
            Type = AllTypes.Monster;//this comes from the parent class Card
        }
    }
}
