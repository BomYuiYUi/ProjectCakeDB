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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetMember.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cakeDBDataSetMember.Member);

            this.reportViewer1.RefreshReport();
        }
    }
}
