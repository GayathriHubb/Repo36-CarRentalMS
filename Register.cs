using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalMS
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        private void Gn2BtnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Gn2TBUsername.Text) || string.IsNullOrEmpty(Gn2TBPswrd.Text) || string.IsNullOrEmpty(Gn2TBCnfmPswrd.Text))
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

                        string chkun = "Select Count(Id) From Users Where Username = @un";
                        using (SqlCommand chkcmd =  new SqlCommand(chkun, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text.Trim());
                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();    
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc > 0)
                            {
                                string tempun = $"{Gn2TBUsername.Text.Trim().Substring(0, 1).ToUpper()}{Gn2TBUsername.Text.Trim().Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                                return;
                            }
                            if (Gn2TBPswrd.Text.Trim().Length < 8)
                            {
                                MessageBox.Show("Invalid Password.. Must be Atleast 8 characters or Up", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                            if (Gn2TBCnfmPswrd.Text != Gn2TBPswrd.Text)
                            {
                                MessageBox.Show("Passwords Does Not Match", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                            string insdata = "Insert Into Users (Username, Password, Status, DateRegister) Values (@un, @pswrd, @st, @dtreg)";
                            using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text.Trim());
                                inscmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text.Trim());
                                inscmd.Parameters.AddWithValue("@st", "Active");
                                inscmd.Parameters.AddWithValue("@dtreg", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                MessageBox.Show("Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                FormLogin frmlgn = new FormLogin();
                                frmlgn.Show();
                                Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SignUp");
                    }
                }

            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            Gn2TBUsername.Clear();
            Gn2TBPswrd.Clear();
            Gn2TBCnfmPswrd.Clear();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            Gn2TBPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            Gn2TBCnfmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

        private void Gn2BtnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin frmlgn = new FormLogin();
            frmlgn.Show();
            Hide();
        }
    }
}
