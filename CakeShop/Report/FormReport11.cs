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
    public partial class FormReport11 : Form
    {
        public FormReport11()
        {
            InitializeComponent();
        }

        private void FormReport11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetOrderPay.OrderPay' table. You can move, or remove it, as needed.
            this.orderPayTableAdapter.Fill(this.cakeDBDataSetOrderPay.OrderPay);

            this.reportViewer1.RefreshReport();
        }
    }
}
