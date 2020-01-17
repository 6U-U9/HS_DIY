﻿using System;
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
            NewCard1 newCard1 = new NewCard1();
            NewCard2 newCard2 = new NewCard2();
            Console.WriteLine(newCard1.Equals(newCard2));
            Console.WriteLine(newCard1.GetType());
        }
    }
}