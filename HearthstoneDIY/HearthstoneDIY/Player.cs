using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    //己方半场的控制
    public class Player:Card
    {
        public List<Card> startDeck=new List<Card>();
        public List<Card> deck = new List<Card>();
        public List<Card> hand = new List<Card>();
        public List<Card> board = new List<Card>();
        public List<Card> heroPowers = new List<Card>();
        public List<Card> weapons = new List<Card>();
        public int crystal;
        public int crystalPower;//max
        public int crystalOverloaded;
        public int crystalLimit;
        public int crystalGrowSpeed;

        public Player(Deck deck,int crystal=0, int crystalLimit = 10,int crystalGrowSpeed=1)
        {
            this.deck = deck.GetDeck();
            this.startDeck = deck.GetDeck();
            this.crystal = crystal;
            this.crystalLimit = crystalLimit;
            this.crystalGrowSpeed = crystalGrowSpeed;
            //this.deck.Shuffle();
        }
        public bool HasEnoughResource(int resource, int cost)
        {
            if (resource >= cost)
                return true;
            Console.WriteLine("You Have No Enough Resource");
            return false;
        }
        public void SpendResource(ref int resource, int cost)
        {
            resource -= cost;
        }
        public void PlayCard(Card card)
        {
            if (card.IsAbleToPlay()&&hand.Contains(card))
            { SpendResource(ref card.GetResourceNeed(), card.cost); card.PlayedFromHand(); }
        }
        public void Draw()
        {
            Card card = GetTopCardFrom(deck);
            deck.Remove(card); 
            hand.Add(card);

        }
        public Card GetTopCardFrom(List<Card> cards)
        {
            Card card = cards[0];
            return card;
        }
        public override void NewTurnStarted()
        {
            Draw();
            CrystalNaturalGrow();
            RefreshCrystal();
            base.NewTurnStarted();
        }
        public virtual void CrystalNaturalGrow()
        {
            crystalPower += crystalGrowSpeed;
            if (crystalPower >= crystalLimit)
                crystalPower = crystalLimit;
        }
        public virtual void RefreshCrystal()
        {
            crystal = crystalPower-crystalOverloaded;
        }

    }
}
