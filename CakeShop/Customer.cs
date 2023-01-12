using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShop
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            using (Process02 P2 = new Process02())
            {
                P2.ShowDialog();
            }
        }
    }
}
