using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HearthstoneDIY
{
    public partial class FormStart : Form
    {
        Account account = new Account();
        
        public FormStart()
        {
            InitializeComponent();
            //Log in

            //test account
            MinionCard card1 = new NewCard1();
            card1.cost = 2; card1.attack = 3; card1.hp = 4; card1.name = "card1";
            MinionCard card2 = new NewCard2();
            card2.cost = 3; card2.attack = 5; card2.hp = 6; card2.name = "card2";
            MinionCard card3 = new NewCard3();
            card3.cost = 4; card3.attack = 2; card3.hp = 8; card3.name = "card3";
            MinionCard card4 = new NewCard4();
            card4.cost = 5; card4.attack = 6; card4.hp = 10; card4.name = "card4";
            Deck deck1 = new Deck(new HeroCard());
            deck1.name = "deck1";
            deck1.AddCard(card1);
            deck1.AddCard(card2);
            deck1.AddCard(card3);
            deck1.AddCard(card4);
            deck1.AddCard(card1);
            deck1.AddCard(card4);
            deck1.AddCard(card1);
            deck1.AddCard(card4);
            deck1.AddCard(card1);
            Deck deck2 = new Deck(new HeroCard());
            deck2.name = "deck2";
            deck2.AddCard(card4);
            deck2.AddCard(card3);
            deck2.AddCard(card2);
            deck2.AddCard(card1);
            deck2.AddCard(card1);
            deck2.AddCard(card2);
            deck2.AddCard(card1);
            deck2.AddCard(card2);
            deck2.AddCard(card1);
            account.decklist.Add(deck1);
            account.decklist.Add(deck2);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            var newform = new FormDeckChoose(account);
            this.Hide();
            newform.ShowDialog();
            //Application.ExitThread();
            this.Show();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Card newCard1 = (Card)new NewCard1();
            Card newCard2 = new NewCard2();
            //Console.WriteLine(newCard1.Equals(newCard2));
            //Console.WriteLine(newCard1.GetType());
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("mouseDown");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            int x= ((Button)sender).Location.X + e.Location.X;
            int y = ((Button)sender).Location.Y + e.Location.Y;
            Point p = new Point(x,y); 
            Console.WriteLine("x:" + p.X + "  y:" + p.Y);
            var c=this.GetChildAtPoint(p);
            if(c!=null)
            Console.WriteLine(c.ToString());
            //Console.WriteLine("mouseUp");
        }
    }
}
