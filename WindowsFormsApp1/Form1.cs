using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        double n1;
        double n2;
        double result;
        string pro;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(lb_result.Text);
            if (pro == "+")
            {
                result = n1 + n2;
                lb_result.Text = Convert.ToString(result);
            }
           else if (pro == "-")
            {
                result = n1 - n2;
                lb_result.Text = Convert.ToString(result);
            }
            else if (pro == "*")
            {
                result = n1 * n2;
                lb_result.Text = Convert.ToString(result);
            }
            else if (pro == "/")
            {
                result = n1 / n2;
                lb_result.Text = Convert.ToString(result);
            }

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton17_Click(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text =="0")
            {
                lb_result.Text = "";
                lb_result.Text = lb_result.Text + btn.Text;
            }
            else
            {
                lb_result.Text = lb_result.Text + btn.Text;
            }
            if (lb_Calculating.Text !="")
            {
                lb_Calculating.Text = lb_Calculating.Text + btn.Text;
            }
            else
            {
                lb_Calculating.Text = lb_result.Text;
            }
    

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pro_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n1 = Convert.ToDouble(lb_result.Text);
            pro = btn.Text;
            if (lb_Calculating.Text != "")
                {
                lb_Calculating.Text = lb_Calculating.Text + pro;
            }
            else
            {
                lb_Calculating.Text = lb_Calculating.Text + pro;
            }
            lb_result.Text = "";

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            lb_Calculating.Text = "";
            lb_result.Text = "";
        }
    }
}
