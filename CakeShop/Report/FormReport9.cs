using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShop.Report
{
    public partial class FormReport9 : Form
    {
        public FormReport9()
        {
            InitializeComponent();
        }

        private void FormReport9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetCake.Cake' table. You can move, or remove it, as needed.
            this.cakeTableAdapter.Fill(this.cakeDBDataSetCake.Cake);

            this.reportViewer1.RefreshReport();
        }
    }
}
