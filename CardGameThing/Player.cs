using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    public class Player
    {
        public string playerID { get; private set; }
        public string Name { get; set; }
        public int LifePoints;
        public List<Deck> Decks;
        public Deck currentDeck;
        List<Card> currentHand;

        public Player(string name)
        {
            playerID = "";//random id here
            Name = name;
            LifePoints = 0;
            Decks = new List<Deck>();
        }

        public void setLP(int amount)
        {
            LifePoints = amount;
        }

        public int getLP()
        {
            return LifePoints;
        }

        public int addToLP(int amount)
        {
            LifePoints += amount;
            return LifePoints;
        }
        public int subtractFromLP(int amount)
        {
            LifePoints -= amount;
            if(LifePoints < 0)
            {
                LifePoints = 0;
            }
            return LifePoints;
        }
        public void addDeck(Deck d)
        {
            Decks.Add(d);
        }

        public void setCurrentDeck(Deck d)
        {
            currentDeck = d;
        }

        public void DrawStartingHand(bool playerIsFirst)
        {
            currentHand = new List<Card>();
           
            if (playerIsFirst)
            {
                for(int i = 0; i < 4; i++)
                {
                    currentHand.Add(currentDeck.Draw());
                }
            }
        }

        public List<Card> GetCurrentHand()
        {
            return currentHand;
        }
    }
}
