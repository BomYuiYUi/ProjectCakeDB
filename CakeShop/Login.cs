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
    public partial class Login : Form
    {
        SqlConnection CakesConnection;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            string PoID = "";
            strSQL = $"Select EmpID,EmpPass,EmpPositionID from Employee where EmpID ='{UsertextBox.Text}' and EmpPass ='{PasstextBox.Text}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            string user = Convert.ToString(UsertextBox.Text);
            string pass = Convert.ToString(PasstextBox.Text);
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("admin");
                Ep.EnID = 0;
                CakesConnection.Dispose();
                using (Employee em = new Employee())
                {
                    em.ShowDialog();
                }
                this.Close();
            }
            else
            {
                if (dataReader.Read())
                {
                    PoID = Convert.ToString(dataReader.GetValue(2));
                    if (PoID == "P01")
                    {
                        MessageBox.Show("พนักงานหน้าร้าน");
                        Ep.EnID = 1;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (PoID == "P02")
                    {
                        MessageBox.Show("พ่อครัว");
                        Ep.EnID = 2;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (PoID == "P03")
                    {
                        MessageBox.Show("พนักงานจัดซื้อ");
                        Ep.EnID = 3;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (PoID == "P04")
                    {
                        MessageBox.Show("พนักงานคลังสินค้า");
                        Ep.EnID = 4;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (PoID == "P05")
                    {
                        MessageBox.Show("พนักงานบัญชี");
                        Ep.EnID = 5;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (PoID == "P06")
                    {
                        MessageBox.Show("ผู้จัดการร้าน");
                        Ep.EnID = 6;
                        CakesConnection.Dispose();
                        using (Employee em = new Employee())
                        {
                            em.ShowDialog();
                        }
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้รหัสหรือรหัสผ่านไม่ถูกต้อง");
                    }
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้รหัสหรือรหัสผ่านไม่ถูกต้อง");
                }
                dataReader.Close();
            }
        }
    }
}
