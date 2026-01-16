using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CarRentalMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure to Quit ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            e.Cancel = true;

        }

        private void Gn2BtnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure to SignOut ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                FormLogin frmlgn = new FormLogin();
                frmlgn.Show();
                Hide();
            }

        }

        private void MainBtns_Click(object sender, EventArgs e)
        {
            Guna2Button gnbtn = (Guna2Button)sender;

            switch (gnbtn.Name)
            {
                case "Gn2BtnDashboard":
                    FormDashboard frmdshbrd = new FormDashboard();
                    frmdshbrd.Show();
                    
                    break;
                case "Gn2BtnUsers":
                    FormUsers frmusers = new FormUsers();
                    frmusers.Show();
                    
                    break;
                case "Gn2BtnCars":
                    FormCars frmcars = new FormCars();
                    frmcars.Show();
                    
                    break;
                case "Gn2BtnCustms":
                    FormCustomers frmcustms = new FormCustomers();
                    frmcustms.Show();
                    
                    break;
                case "Gn2BtnRents":
                    FormRents frmrnts = new FormRents();
                    frmrnts.Show();
                    
                    break;
                case "Gn2BtnReturns":
                    FormReturns frmrtns = new FormReturns();
                    frmrtns.Show();
                    
                    break;
            }

            Hide();

        }
    }
}
