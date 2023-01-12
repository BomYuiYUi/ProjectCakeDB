using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShop
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            if ((Button)sender == buttonP1)
            {
                using (Process01 P1 = new Process01())
                {
                    P1.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP3)
            {
                using (Process03 P3 = new Process03())
                {
                    P3.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP4)
            {
                using (Process04 P4 = new Process04())
                {
                    P4.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP5)
            {
                using (Process05 P5 = new Process05())
                {
                    P5.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP6)
            {
                using (Process06 P6 = new Process06())
                {
                    P6.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP7)
            {
                using (Process07 P7 = new Process07())
                {
                    P7.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP8)
            {
                using (Process08 P8 = new Process08())
                {
                    P8.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP9)
            {
                using (Process09 P9 = new Process09())
                {
                    P9.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP10)
            {
                using (Process10 P10 = new Process10())
                {
                    P10.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP11)
            {
                using (Process11 P11 = new Process11())
                {
                    P11.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP12)
            {
                using (Process12 P12 = new Process12())
                {
                    P12.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP13)
            {
                using (Process13 P13 = new Process13())
                {
                    P13.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP14)
            {
                using (Process14 P14 = new Process14())
                {
                    P14.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP15)
            {
                using (Process15 P15 = new Process15())
                {
                    P15.ShowDialog();
                }
            }
            else if ((Button)sender == buttonP16)
            {
                using (Process16 P16 = new Process16())
                {
                    P16.ShowDialog();
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            int result = Ep.EnID;
            if(result == 1)
            {
                buttonP1.Location = new Point(12, 12);
                buttonP3.Location = new Point(12, 69);
                buttonP9.Location = new Point(12, 126);
                buttonP5.Location = new Point(12, 183);
                buttonP4.Visible = false;
                buttonP6.Visible = false;
                buttonP7.Visible = false;
                buttonP8.Visible = false;
                buttonP10.Visible = false;
                buttonP11.Visible = false;
                buttonP12.Visible = false;
                buttonP13.Visible = false;
                buttonP14.Visible = false;
                buttonP15.Visible = false;
                buttonP16.Visible = false;
            }
            else if (result == 2)
            {
                buttonP1.Visible = false;
                buttonP3.Visible = false;
                buttonP4.Location = new Point(12, 12);
                buttonP5.Visible = false;
                buttonP6.Location = new Point(12, 69);
                buttonP7.Location = new Point(12, 126);
                buttonP8.Location = new Point(12, 183);
                buttonP9.Visible = false;
                buttonP10.Visible = false;
                buttonP11.Visible = false;
                buttonP12.Visible = false;
                buttonP13.Visible = false;
                buttonP14.Visible = false;
                buttonP15.Visible = false;
                buttonP16.Visible = false;
            }
            else if (result == 3)
            {
                buttonP1.Visible = false;
                buttonP3.Visible = false;
                buttonP4.Visible = false;
                buttonP5.Visible = false;
                buttonP6.Visible = false;
                buttonP7.Visible = false;
                buttonP8.Visible = false;
                buttonP9.Visible = false;
                buttonP10.Location = new Point(12, 69);
                buttonP11.Visible = false;
                buttonP12.Visible = false;
                buttonP13.Location = new Point(12, 12);
                buttonP14.Visible = false;
                buttonP15.Visible = false;
                buttonP16.Visible = false;
            }
            else if (result == 4)
            {
                buttonP1.Visible = false;
                buttonP3.Visible = false;
                buttonP4.Visible = false;
                buttonP5.Visible = false;
                buttonP6.Visible = false;
                buttonP7.Visible = false;
                buttonP8.Visible = false;
                buttonP9.Visible = false;
                buttonP10.Visible = false;
                buttonP11.Location = new Point(12, 126);
                buttonP12.Location = new Point(12, 69);
                buttonP13.Location = new Point(12, 12);
                buttonP14.Visible = false;
                buttonP15.Visible = false;
                buttonP16.Visible = false;
            }
            else if (result == 5)
            {
                buttonP1.Visible = false;
                buttonP3.Visible = false;
                buttonP4.Visible = false;
                buttonP5.Visible = false;
                buttonP6.Visible = false;
                buttonP7.Visible = false;
                buttonP8.Visible = false;
                buttonP9.Visible = false;
                buttonP10.Visible = false;
                buttonP11.Visible = false;
                buttonP12.Visible = false;
                buttonP13.Location = new Point(12, 12);
                buttonP14.Location = new Point(12, 69);
                buttonP15.Location = new Point(12, 126);
                buttonP16.Visible = false;
            }
            else if (result == 6)
            {
                buttonP1.Location = new Point(12, 12);
                buttonP3.Location = new Point(12, 69);
                buttonP4.Location = new Point(12, 240);
                buttonP5.Location = new Point(12, 183);
                buttonP6.Location = new Point(12, 297);
                buttonP7.Location = new Point(12, 354);
                buttonP8.Location = new Point(229, 12);
                buttonP9.Location = new Point(12, 126);
                buttonP10.Location = new Point(229, 69);
                buttonP11.Location = new Point(229, 183);
                buttonP12.Location = new Point(229, 126);
                buttonP13.Location = new Point(446, 12);
                buttonP14.Location = new Point(229, 297);
                buttonP15.Location = new Point(229, 354);
                buttonP16.Location = new Point(229, 240);
            }
            else if (result == 0)
            {
                buttonP1.Location = new Point(12, 12);
                buttonP3.Location = new Point(12, 69);
                buttonP4.Location = new Point(12, 240);
                buttonP5.Location = new Point(12, 183);
                buttonP6.Location = new Point(12, 297);
                buttonP7.Location = new Point(12, 354);
                buttonP8.Location = new Point(229, 12);
                buttonP9.Location = new Point(12, 126);
                buttonP10.Location = new Point(229, 69);
                buttonP11.Location = new Point(229, 183);
                buttonP12.Location = new Point(229, 126);
                buttonP13.Location = new Point(446, 12);
                buttonP14.Location = new Point(229, 297);
                buttonP15.Location = new Point(229, 354);
                buttonP16.Location = new Point(229, 240);
            }



        }
    }
}