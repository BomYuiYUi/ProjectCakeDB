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
    public partial class FormReport5 : Form
    {
        public FormReport5()
        {
            InitializeComponent();
        }

        private void FormReport5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetPay.Pay' table. You can move, or remove it, as needed.
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);

            this.reportViewer1.RefreshReport();
        }
    }
}
