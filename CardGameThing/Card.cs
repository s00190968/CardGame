using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    public abstract class Card
    {
        public enum AllTypes{ Monster, Trap, Spell };
        public AllTypes Type { get; set; }
        public string Name{ get; set; }
        public int Stars { get; set; }
        public string ID { get; set; }
        public enum Rarity { Normal, Rare, SuperRare, UltraRare };
        Rarity rarity { get; set; }
        public string Description { get; set; }

        public Card(string name, int stars, string id, Rarity rarity, string description)
        {
            this.rarity = rarity;
            Name = name;
            Stars = stars;
            ID = id;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format($"{Name}, {ID}");
        }
    }
}
