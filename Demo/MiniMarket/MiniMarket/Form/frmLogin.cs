using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using MiniMarket.Session;

namespace MiniMarket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Invalid Employee information!", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeBUS employeeBUS = new EmployeeBUS();
            Employee employee = employeeBUS.CheckAccount(int.Parse(txtEmployeeID.Text), txtPassword.Text);

            if (employee != null)
            {
                EmployeeSession.employee = employee;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Employee information!", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
