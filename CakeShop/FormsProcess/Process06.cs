using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CakeShop
{
    public partial class Process06 : Form
    {
        SqlConnection CakesConnection;
        public Process06()
        {
            InitializeComponent();
        }
        private void Process06_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetMade.Made' table. You can move, or remove it, as needed.
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            int All = madeStatuscomboBox.SelectedIndex;
            String Status = "ไม่เสร็จ";
            if (All == 0)
            {
                Status = "ไม่เสร็จ";
            }
            else if (All == 1)
            {
                Status = "เสร็จแล้ว";
            }
            var sql = $"Update Made set MadeStatus = '{Status}'where MadeID='{madeIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            command.Dispose();
        }

        private void Process06_FormClosing(object sender, FormClosingEventArgs e)
        {
            CakesConnection.Close();
            CakesConnection.Dispose();
        }

        private void cakesearchbutton_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            string sql = "";
            int All = searchcomboBox.SelectedIndex;

            if (All == 0)
            {
                sql = $"SELECT * FROM Made WHERE MadeID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Made WHERE MadeType ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Made WHERE MadeDate ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Made WHERE MadePrice ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Made WHERE MadeStatus ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Made WHERE MadeStyle ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Made WHERE MadeQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Made WHERE CusID ='{searchtextBox.Text}'";
            }
            else if (All == 8)
            {
                sql = $"SELECT * FROM Made WHERE EmpID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMade.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Made", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMade.DataSource = resultTable;
        }
    }
}
