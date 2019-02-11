using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameThing
{
    class Duel
    {
        public int numberOfPlayers { get; set; }
        public string duelID{ get; private set; }
        public int turnsPassed { get; set; }
        public string winnerID { get; private set; }
        public List<Player> players;
        public int firstPlayer;
        public int CurrentPlayer { get; set; }

        Random rand;

        public Duel(List<Player>p, string duelid)
        {
            players = p;
            numberOfPlayers = players.Count;
            duelID = duelid;
            turnsPassed = 0;
            rand = new Random();
        }

        public void startDuel()
        {
            firstPlayer = rand.Next(0, players.Count-1);

        }

        public void playerdrawsACard()
        {

        }

        public void DrawPhase(Player player)
        {
            player.
        }



    }
}
