using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class mdi_frm_main : Form
    {
        public mdi_frm_main()
        {
            InitializeComponent();
        }

        private void Mdi_frm_main_Load(object sender, EventArgs e)
        {
            UpdateLoginStatus();
            MnLogin_Click(sender, e);
        }

        private void UpdateLoginStatus()
        {
            if (Session.EmployeeSession.employee == null)
            {
                mnLogin.Enabled = true;
                mnLogout.Enabled = false;
                mnPosFunction.Enabled = false;
                mnReport.Enabled = false;
                mnCustomerManagement.Enabled = false;
                ttsLoginedEmployee.Text = String.Empty;
            }
            else
            {
                mnLogin.Enabled = false;
                mnLogout.Enabled = true;
                mnPosFunction.Enabled = true;
                mnReport.Enabled = true;
                mnCustomerManagement.Enabled = true;
                ttsLoginedEmployee.Text = Session.EmployeeSession.employee.EmployeeName;
            }
        }

        private void TsmnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void MnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            UpdateLoginStatus();
        }

        private void MnLogout_Click(object sender, EventArgs e)
        {
            Session.EmployeeSession.employee = null;
            UpdateLoginStatus();

            MnLogin_Click(sender, e);
        }

        private void MnPosFunction_Click(object sender, EventArgs e)
        {
            frmPosFunction frm = new frmPosFunction();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
