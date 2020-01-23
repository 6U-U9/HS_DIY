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
    public partial class GameBoard : Form
    {
        public BattleGround battleGround;
        List<Button> cards = new List<Button>();
        public GameBoard(BattleGround battleGround)
        {
            this.battleGround = battleGround;
            InitializeComponent();
            /*for (int i = 0; i < battleGround.player1.hand.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                int j = cards.Count - 1;
                cards[j].Text = "cost: "+ battleGround.player1.hand[i].cost+"\nattack:"+ battleGround.player1.hand[i].attack + "\nhp:" + battleGround.player1.hand[i].hp;
                cards[j].Location = new Point(10 + i * 100, 30);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = battleGround.player1.hand[i];
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }
            for (int i = 0; i < battleGround.player2.hand.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                int j = cards.Count - 1;
                cards[j].Text = "cost: " + battleGround.player2.hand[i].cost + "\nattack:" + battleGround.player2.hand[i].attack + "\nhp:" + battleGround.player2.hand[i].hp;
                cards[j].Location = new Point(10 + i * 100, 500);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = battleGround.player2.hand[i];
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }*/
            Fresh();
        }
        private void CardButton_MouseDown(object sender, EventArgs e)
        {
            Card card = (Card)((Button)sender).Tag;
        }
        private void CardButton_MouseUp(object sender, MouseEventArgs e)
        {
            int x = ((Button)sender).Location.X + e.Location.X;
            int y = ((Button)sender).Location.Y + e.Location.Y;
            Point mousePoint=new Point(x,y);
            Button button=(Button)GetChildAtPoint(mousePoint);
            Card actor = (Card)(((Button)sender).Tag);
            if (button == null)
            { battleGround.onplayPlayer.PlayCard(actor); 
            }
            else
            { if (battleGround.onplayPlayer.board.Contains(actor))
                { Card target =(Card)button.Tag;
                        actor.Attack(target);
                } 
            }
            //if mouse on card,then select it
            //if mouse in hand,then release it
            //if mouse on board,then use it
            //if targeted on anothe card,then use or attack
            Fresh();
        }
        private void Fresh()
        {
            if (battleGround.onplayPlayer == battleGround.player1)
            { button1.BackColor = Color.Cyan; button2.BackColor = Color.Gray; }
            if (battleGround.onplayPlayer == battleGround.player2)
            { button2.BackColor = Color.Cyan; button1.BackColor = Color.Gray; }
            button1.Text = "Player1\n" + "Cost:" + battleGround.player1.crystal + "/" + battleGround.player1.crystalPower;
            button2.Text = "Player2\n" + "Cost:" + battleGround.player2.crystal + "/" + battleGround.player2.crystalPower;
            foreach (Button button in cards)
            { 
                Controls.Remove(button); 
            }
            cards.Clear();
            for (int i = 0; i < battleGround.player1.hand.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                Card card = battleGround.player1.hand[i];
                int j = cards.Count - 1;

                cards[j].Text = "cost: " + card.cost + "\nattack:" + card.attack + "\nhp:" + card.hp;
                cards[j].Location = new Point(10 + i * 100, 30);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = card;
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }
            for (int i = 0; i < battleGround.player1.board.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                Card card = battleGround.player1.board[i];
                int j = cards.Count - 1;
                cards[j].Text = "cost: " + card.cost + "\nattack:" + card.attack + "\nhp:" + card.hp;
                cards[j].Location = new Point(10 + i * 100, 130);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = card;
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }
            for (int i = 0; i < battleGround.player2.hand.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                Card card = battleGround.player2.hand[i];
                int j = cards.Count - 1;
                cards[j].Text = "cost: " + card.cost + "\nattack:" + card.attack + "\nhp:" + card.hp;
                cards[j].Location = new Point(10 + i * 100, 500);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = card;
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }
            for (int i = 0; i < battleGround.player2.board.Count; i++)
            {
                //cards.Add(account.decklist[i].name);
                cards.Add(new Button());
                Card card = battleGround.player2.board[i];

                int j = cards.Count - 1;
                cards[j].Text = "cost: " + card.cost + "\nattack:" + card.attack + "\nhp:" + card.hp;
                cards[j].Location = new Point(10 + i * 100, 400);
                cards[j].Size = new Size(80, 50);
                cards[j].Tag = card;
                cards[j].MouseDown += new System.Windows.Forms.MouseEventHandler(CardButton_MouseDown);
                cards[j].MouseUp += new System.Windows.Forms.MouseEventHandler(CardButton_MouseUp);
                Controls.Add(cards[j]);
            }
        }

        private void buttonTurnEnd_Click(object sender, EventArgs e)
        {
            battleGround.NewTurn();
            Fresh();
        }
    }
}
