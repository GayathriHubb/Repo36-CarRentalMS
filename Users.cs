using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CarRentalMS
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";
        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVUsers();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "UsersLoad");
                }
            }
        }

        private void Gn2BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPassword.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            if (TxtBxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Must be Atleast 8 characters or Up", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                        using (SqlCommand chkcmd = new SqlCommand(chkun, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());

                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc > 0)
                            {
                                string tempun = $"{TxtBxUsername.Text.Trim().Substring(0, 1).ToUpper()}{TxtBxUsername.Text.Trim().Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Users (Username, Password, Status, DateRegister) Values (@un, @pswrd, @st, @dtreg)";
                            using (SqlCommand inscmd = new SqlCommand (insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                inscmd.Parameters.AddWithValue("@pswrd", TxtBxPassword.Text.Trim());
                                inscmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                inscmd.Parameters.AddWithValue("@dtreg", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                DispDGVUsers();
                                MessageBox.Show("User Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "UsersAdd");
                    }
                }
            }
        }

        private void Gn2BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPassword.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (TxtBxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Must be Atleast 8 characters or Up", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure to Edit Id: {getid} ?", "Edit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string chkun = "Select Count(Id) From Users Where Username = @un";
                            using (SqlCommand chkcmd = new SqlCommand(chkun, sqlcon))
                            {
                                chkcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());

                                int rc = 0;
                                object res = chkcmd.ExecuteScalar();
                                if (res != DBNull.Value)
                                {
                                    rc = Convert.ToInt32(res);
                                }

                                if (rc >= 2)
                                {
                                    string tempun = $"{TxtBxUsername.Text.Trim().Substring(0, 1).ToUpper()}{TxtBxUsername.Text.Trim().Substring(1)}";
                                    MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    return;
                                }

                                string upddata = "Update Users Set Username = @un, Password = @pswrd, Status = @st Where Id = @id";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@psrwd", TxtBxPassword.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@id", getid);

                                    updcmd.ExecuteNonQuery();
                                    DispDGVUsers();
                                    MessageBox.Show("User Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }


                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "UsersEdit");
                        }
                    }
                }
                   
            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Record First to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure to Delete Id: {getid} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From Users Where Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@id", getid);

                                delcmd.ExecuteNonQuery();
                                DispDGVUsers();
                                MessageBox.Show("User Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "UsersDelete");
                        }
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        int getid;
        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVUsers.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    TxtBxUsername.Text = (string)row.Cells[1].Value;
                    TxtBxPassword.Text = (string)row.Cells[2].Value;
                    CmbBxStatus.Text = (string)row.Cells[3].Value;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVUsers");
            }
        }

        private void ClearFields()
        {
            TxtBxUsername.Clear();
            TxtBxPassword.Clear();
            CmbBxStatus.SelectedIndex = -1; 
        }

        private void DispDGVUsers()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Users";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVUsers.DataSource = dt;
                    }

                    if (MaximizeBox)
                    {
                        DGVUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        DGVUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispUsers");
                }
            }
        }

       
    }
}
