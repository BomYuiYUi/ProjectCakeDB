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
    public partial class Process09 : Form
    {
        SqlConnection CakesConnection;
        public Process09()
        {
            InitializeComponent();
        }

        private void Process09_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetMember.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cakeDBDataSetMember.Member);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = memberBDDateTimePicker.Value.Day.ToString();
            string Month = memberBDDateTimePicker.Value.Month.ToString();
            string Year = memberBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"INSERT INTO Member(MemberID,MemberName,MemberLast,MemberBD,MemberSex,MemberTel,MemberAddress,MemberMoo,MemberSubDisrict,MemberDisrict,MemberProvince,MemberPostal) " +
                $"VALUES('{memberIDTextBox.Text}','{memberNameTextBox.Text}','{memberLastTextBox.Text}','{All}','{memberSexTextBox.Text}','{memberTelTextBox.Text}','{memberAddressTextBox.Text}','{memberMooTextBox.Text}','{memberSubDisrictTextBox.Text}','{memberDisrictTextBox.Text}','{memberProvinceTextBox.Text}','{memberPostalTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.cakeDBDataSetMember.Member);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Member where MemberID = '{memberIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.cakeDBDataSetMember.Member);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = memberBDDateTimePicker.Value.Day.ToString();
            string Month = memberBDDateTimePicker.Value.Month.ToString();
            string Year = memberBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"Update Member set MemberName = '{memberNameTextBox.Text}',MemberLast = '{memberLastTextBox.Text}',MemberBD = '{All}',MemberSex = '{memberSexTextBox.Text}'" +
                $",MemberTel = '{memberTelTextBox.Text}',MemberAddress = '{memberAddressTextBox.Text}',MemberMoo = '{memberMooTextBox.Text}',MemberSubDisrict = '{memberSubDisrictTextBox.Text}',MemberDisrict='{memberDisrictTextBox.Text}',MemberProvince='{memberProvinceTextBox.Text}',MemberPostal='{memberPostalTextBox.Text}' where MemberID='{memberIDTextBox.Text}' ";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.cakeDBDataSetMember.Member);
            command.Dispose();
        }

        private void Process09_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM Member WHERE MemberID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Member WHERE MemberName ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Member WHERE MemberLast ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Member WHERE MemberBD ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Member WHERE MemberSex ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Member WHERE MemberTel ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Member WHERE MemberAddress ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Member WHERE MemberMoo ='{searchtextBox.Text}'";
            }
            else if (All == 8)
            {
                sql = $"SELECT * FROM Member WHERE MemberSubDisrict ='{searchtextBox.Text}'";
            }
            else if (All == 9)
            {
                sql = $"SELECT * FROM Member WHERE MemberDisrict ='{searchtextBox.Text}'";
            }
            else if (All == 10)
            {
                sql = $"SELECT * FROM Member WHERE MemberProvince ='{searchtextBox.Text}'";
            }
            else if (All == 11)
            {
                sql = $"SELECT * FROM Member WHERE MemberPostal ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMember.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Member", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMember.DataSource = resultTable;
        }
    }
}
