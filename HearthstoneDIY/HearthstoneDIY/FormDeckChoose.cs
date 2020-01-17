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
        public FormDeckChoose(Account account)
        {
            this.account = account;
            InitializeComponent();
        }
    }
}
