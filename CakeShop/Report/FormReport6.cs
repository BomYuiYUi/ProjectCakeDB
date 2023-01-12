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
    public partial class FormReport6 : Form
    {
        public FormReport6()
        {
            InitializeComponent();
        }

        private void FormReport6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetIncome.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.cakeDBDataSetIncome.Income);

            this.reportViewer1.RefreshReport();
        }
    }
}
