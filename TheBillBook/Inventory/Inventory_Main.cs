using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBillBook.Inventory
{
    public partial class Inventory_Main : Form
    {
        public Inventory_Main()
        {
            InitializeComponent();
        }

        private void unitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventory.Unit Inventory = new TheBillBook.Inventory.Unit();
            Inventory.TopLevel = false;
            Inventory.AutoScroll = true;
            this.Inventory_Screen.Controls.Add(Inventory);
            Inventory.Show();
        }
    }
}
