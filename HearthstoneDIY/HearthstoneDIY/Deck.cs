using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    public class Deck
    {
        public int cardlimit;
        public string name;
        public HeroCard hero;
        private List<Card> cardlist = new List<Card>();
        public Deck(HeroCard hero,int cardlimit=30)
        {
            this.cardlimit = cardlimit;
            this.hero = hero;
        }
        public void AddCard(Card newcard)
        {
            //Check Total Card Amount in Deck
            if (cardlimit <= cardlist.Count)
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
            Console.WriteLine("Added to Deck");
            //Sort
            //cardlist.Sort(new DeckSortComparer());
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
            var ingame_cardlist = new List<Card>();
            foreach (Card card in cardlist)
            {
                Type cardType = card.GetType();
                MethodInfo methodInfo = cardType.GetMethod("GetCopy");
                //Card newcard = (Card)methodInfo.MakeGenericMethod(new Type[] { card.GetType() }).Invoke(card, null);
                ingame_cardlist.Add((Card)methodInfo.MakeGenericMethod(new Type[] { card.GetType()}).Invoke(card,null)); }
            return ingame_cardlist;
        }
    }
}
