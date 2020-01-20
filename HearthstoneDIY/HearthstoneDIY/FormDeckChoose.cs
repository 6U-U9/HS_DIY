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
    public partial class FormDeckChoose : Form
    {
        Account account;
        List<string> deckNames=new List<string>();
        List<Button> decks=new List<Button>();
        List<int> playerDeck_choose=new List<int>();
        int playerchosen=1;
        public FormDeckChoose(Account account)
        {
            this.account = account;
            int decknum = account.decklist.Count;
            for (int i = 0; i < decknum; i++)
            {
                deckNames.Add(account.decklist[i].name);
                decks.Add(new Button());
                decks[i].Text = deckNames[i];
                decks[i].Location = new Point(10+i*60, 30);
                decks[i].Size = new Size(60, 30);
                decks[i].Tag = i;
                decks[i].Click += new System.EventHandler(DeckButton_Click);
                Controls.Add(decks[i]);
            }
            playerDeck_choose.Add(-1);
            playerDeck_choose.Add(-1);
            playerDeck_choose.Add(-1);
            InitializeComponent();
        }
        private void DeckButton_Click(object sender, EventArgs e)
        {
            playerDeck_choose[playerchosen] = (int)((Button)sender).Tag;
            UpdateDeckChosen();
        }
        private void UpdateDeckChosen()
        {
            if (playerDeck_choose[1] != -1)
                label1.Text = "P1 deck: " + deckNames[playerDeck_choose[1]];
            if (playerDeck_choose[2] != -1)
                label2.Text = "P2 deck: " + deckNames[playerDeck_choose[2]];
            Console.WriteLine("Update");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            playerchosen = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerchosen = 1;
        }
    }
}
