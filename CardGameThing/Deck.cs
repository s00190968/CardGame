using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    class Deck
    {
        private int maxNum { get; } = 60;
        public int minNumber { get; } = 40;
        public string Name { get; set; }
        public bool isEmpty { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name)
        {
            Name = name;
            isEmpty = false;
            Cards = new List<Card>();
        }

        public void AddCard(Card cardToAdd)
        {
            Cards.Add(cardToAdd);
        }

        public void RemoveCard(Card cardToRemove)
        {
            Cards.Remove(cardToRemove);
        }

        public void Suffle()
        {
            Random rand = new Random();
            int place;
            Card temp;
            for(int i = 0; i<Cards.Count; i++)
            {
                place = rand.Next(0, Cards.Count + 1);
                temp = Cards[i];
                Cards[i] = Cards[place];
                Cards[place] = temp;
            }
        }
        public Card Draw()
        {
            Card drawnCard = Cards[Cards.Count];
            RemoveCard(drawnCard);
            return drawnCard;
        }

        public int getCurrentAmount()
        {
            return Cards.Count();
        }

    }
}
