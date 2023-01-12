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
    public partial class Process16 : Form
    {
        SqlConnection CakesConnection;

        String Position = "";
        public Process16()
        {
            InitializeComponent();
        }

        private void Process16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetEmployee.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.cakeDBDataSetEmployee.Employee);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = empBDDateTimePicker.Value.Day.ToString();
            string Month = empBDDateTimePicker.Value.Month.ToString();
            string Year = empBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            String PositionID = "";
            int P = PositionIDcomboBox.SelectedIndex;
            if (P == 0)
            {
                PositionID = "P01";
            }
            else if (P == 1)
            {
                PositionID = "P02";
            }
            else if (P == 2)
            {
                PositionID = "P03";
            }
            else if (P == 3)
            {
                PositionID = "P04";

            }
            else if (P == 4)
            {
                PositionID = "P05";

            }
            else if (P == 5)
            {
                PositionID = "P06";
 
            }
            var sql = $"INSERT INTO Employee(EmpID,EmpName,EmpLast,EmpPositionID,EmpPosition,EmpBD,EmpSex,EmpTel,EmpAddress,EmpMoo,EmpSubDisrict,EmpDisrict,EmpProvince,EmpPostal,EmpPass) " +
                $"VALUES('{empIDTextBox.Text}','{empNameTextBox.Text}','{empLastTextBox.Text}','{PositionID}','{empPositionTextBox.Text}','{All}','{empSexTextBox.Text}','{empTelTextBox.Text}','{empAddressTextBox.Text}','{empMooTextBox.Text}','{empSubDisrictTextBox.Text}','{empDisrictTextBox.Text}','{empProvinceTextBox.Text}','{empPostalTextBox.Text}','{empPassTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.cakeDBDataSetEmployee.Employee);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Employee where EmpID = '{empIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.cakeDBDataSetEmployee.Employee);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = empBDDateTimePicker.Value.Day.ToString();
            string Month = empBDDateTimePicker.Value.Month.ToString();
            string Year = empBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            String PositionID = "";
            int P = PositionIDcomboBox.SelectedIndex;
            if (P == 0)
            {
                PositionID = "P01";
            }
            else if (P == 1)
            {
                PositionID = "P02";
            }
            else if (P == 2)
            {
                PositionID = "P03";
            }
            else if (P == 3)
            {
                PositionID = "P04";

            }
            else if (P == 4)
            {
                PositionID = "P05";

            }
            else if (P == 5)
            {
                PositionID = "P06";

            }
            var sql = $"Update Employee set EmpName = '{empNameTextBox.Text}',EmpLast = '{empLastTextBox.Text}',EmpPositionID = '{PositionID}',EmpPosition = '{empPositionTextBox.Text}'" +
                $",EmpBD = '{All}',EmpSex = '{empSexTextBox.Text}',EmpTel = '{empTelTextBox.Text}',EmpAddress = '{empAddressTextBox.Text}',EmpMoo='{empMooTextBox.Text}',EmpSubDisrict='{empSubDisrictTextBox.Text}',EmpDisrict='{empDisrictTextBox.Text}',EmpProvince='{empProvinceTextBox.Text}',EmpPostal='{empPostalTextBox.Text}',EmpPass='{empPassTextBox.Text}' where EmpID='{empIDTextBox.Text}' ";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.cakeDBDataSetEmployee.Employee);
            command.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int P = PositionIDcomboBox.SelectedIndex;
            if (P == 0)
            {
                Position = "พนักงานขายหน้าร้าน";
                empPositionTextBox.Text = Position;
            }
            else if (P == 1)
            {
                Position = "พ่อครัว";
                empPositionTextBox.Text = Position;
            }
            else if (P == 2)
            {
                Position = "พนักงานจัดซื้อ";
                empPositionTextBox.Text = Position;
            }
            else if (P == 3)
            {
                Position = "พนักงานบัญชี";
                empPositionTextBox.Text = Position;
            }
            else if (P == 4)
            {
                Position = "พนักงานคลังสินค้า";
                empPositionTextBox.Text = Position;
            }
            else if (P == 5)
            {
                Position = "ผู้จัดการร้าน";
                empPositionTextBox.Text = Position;
            }
        }

        private void Process16_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM Employee WHERE EmpID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Employee WHERE EmpName ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Employee WHERE EmpLast ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Employee WHERE EmpPositionID ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Employee WHERE EmpPosition ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Employee WHERE EmpBD ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Employee WHERE EmpSex ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Employee WHERE EmpTel ='{searchtextBox.Text}'";
            }
            else if (All == 8)
            {
                sql = $"SELECT * FROM Employee WHERE EmpAddress ='{searchtextBox.Text}'";
            }
            else if (All == 9)
            {
                sql = $"SELECT * FROM Employee WHERE EmpMoo ='{searchtextBox.Text}'";
            }
            else if (All == 10)
            {
                sql = $"SELECT * FROM Employee WHERE EmpSubDisrict ='{searchtextBox.Text}'";
            }
            else if (All == 11)
            {
                sql = $"SELECT * FROM Employee WHERE EmpDisrict ='{searchtextBox.Text}'";
            }
            else if (All == 12)
            {
                sql = $"SELECT * FROM Employee WHERE EmpProvince ='{searchtextBox.Text}'";
            }
            else if (All == 13)
            {
                sql = $"SELECT * FROM Employee WHERE EmpPostal ='{searchtextBox.Text}'";
            }
            else if (All == 14)
            {
                sql = $"SELECT * FROM Employee WHERE EmpPass ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridView1.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM OrderPay", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridView1.DataSource = resultTable;
        }
    }
}
