using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    public class Deck
    {
        public int cardnum;
        public string name;
        public HeroCard hero;
        private List<Card> cardlist = new List<Card>();
        public Deck(HeroCard hero,int cardnum=30)
        {
            this.cardnum = cardnum;
            this.hero = hero;
        }
        public void AddCard(Card newcard)
        {
            //Check Total Card Amount in Deck
            if (cardnum >= cardlist.Count)
            { Console.WriteLine("Deck Full"); return; }

            //Check This Card Amount in Deck
            int cardcount = 0;
            foreach (Card card in cardlist)
            {
                if (card.GetType() == newcard.GetType())
                    cardcount++;
                if (cardcount >= newcard.Get_bringLimit())
                {
                    Console.WriteLine("Cannot Bring Too Many Same Card"); return;
                }
            }
            
            //Add Card
            cardlist.Add(newcard);
            newcard.AddToDeck(this);

            //Sort
            cardlist.Sort();
        }
        public void DelCard(Card delcard)
        {
            foreach (Card card in cardlist)
            {
                if (card.GetType() == delcard.GetType())
                {
                    cardlist.Remove(card);
                    delcard.RemoveFromDeck(this);
                    return;
                }
            }
            Console.WriteLine("No Same Card in Deck");
            return;
        }
        public List<Card> GetDeck()
        {
            return cardlist;
        }
    }
}
