using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBillBook
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu_inventory_Click(object sender, EventArgs e)
        {
            Inventory.Inventory_Main Inventory = new TheBillBook.Inventory.Inventory_Main();
            Inventory.TopLevel = false;
            Inventory.AutoScroll = true;
            this.screenpanel.Controls.Add(Inventory);
            Inventory.Show();
        }
    }
}
