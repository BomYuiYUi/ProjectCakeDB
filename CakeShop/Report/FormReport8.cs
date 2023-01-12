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
    public partial class FormReport8 : Form
    {
        public FormReport8()
        {
            InitializeComponent();
        }

        private void FormReport8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetEmployee.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.cakeDBDataSetEmployee.Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
