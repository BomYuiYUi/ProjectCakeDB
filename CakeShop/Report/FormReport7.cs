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
    public partial class FormReport7 : Form
    {
        public FormReport7()
        {
            InitializeComponent();
        }

        private void FormReport7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetExpenses.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.cakeDBDataSetExpenses.Expenses);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
