using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace CarRentalMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        private void Gn2BtnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Gn2TBUsername.Text) || string.IsNullOrEmpty(Gn2TBPswrd.Text))
            {
                MessageBox.Show("Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(Id) From Users Where Username = @un AND Password = @pswrd";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text);
                            selcmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text);

                            int rc = 0;
                            object res = selcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                MainForm mnfrm = new MainForm();
                                mnfrm.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SignIn");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            Gn2TBUsername.Clear();
            Gn2TBPswrd.Clear();
        }

        private void Gn2BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister frmreg = new FormRegister();
            frmreg.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            Gn2TBPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

    }
}
