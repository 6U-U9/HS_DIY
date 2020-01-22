using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    public class BattleGround
    {
        //public Game game;
        public Player player1, player2,onplayPlayer;
        public int turns;

        public BattleGround(Deck player1,Deck player2)
        {
            this.player1 = new Player(player1);
            this.player2 = new Player(player2);
            InitGame();
            NewTurn();
        }

        public void InitGame()
        {
            foreach (Card card in player1.deck)
            { card.player = player1; }
            foreach (Card card in player2.deck)
            { card.player = player2; }
            for (int i = 0; i < 3; i++)
            { player1.Draw(); player2.Draw(); }
            player2.Draw();
            onplayPlayer = player2;
            //player2.hand.Add(Coin)
        }
        public void NewTurn()
        {
            if (onplayPlayer == player1)
                onplayPlayer = player2;
            else if (onplayPlayer == player2)
                onplayPlayer = player1;
            onplayPlayer.NewTurnStarted();
            Console.WriteLine("Next Turn");
            //player2.hand.Add(Coin)
        }
    }
}
