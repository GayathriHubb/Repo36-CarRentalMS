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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        private void FormCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVCustms();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustmsLoad");
                }
            }
        }

        private void Gn2BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkcustid = "Select Count(Id) From Clients Where ClientId = @clid";
                        using (SqlCommand chkcmd = new SqlCommand(chkcustid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@clid", TxtBxCustId.Text.Trim());

                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                res = (int)res;
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show($"CustId: {TxtBxCustId.Text} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Clients (ClientId, ClientName, Gender, Address, Phone, DateInsert) Values (@clid, @clname, @gndr, @addrss, @phn, @dtins)";
                            using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@clid", TxtBxCustId.Text.Trim().ToUpper());
                                inscmd.Parameters.AddWithValue("@clname", TxtBxCustName.Text.Trim());
                                inscmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                                inscmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                                inscmd.Parameters.AddWithValue("@phn", MskdTxtBxPhn.Text);
                                inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                DispDGVCustms();
                                MessageBox.Show("Customer Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "CustmsAdd");
                    }
                }
            }
        }

        private void Gn2BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                            string chkcustid = "Select Count(Id) From Clients Where ClientId = @clid";
                            using (SqlCommand chkcmd = new SqlCommand(chkcustid, sqlcon))
                            {
                                chkcmd.Parameters.AddWithValue("@clid", TxtBxCustId.Text.Trim());

                                int rc = 0;
                                object res = chkcmd.ExecuteScalar();
                                if (res != DBNull.Value) 
                                {
                                    rc = (int)res;
                                }

                                if (rc >= 2)
                                {
                                    MessageBox.Show($"CustId: {TxtBxCustId.Text} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    return;
                                }

                                string upddata = "Update Clients Set ClientId = @clid, ClientName = @clname, Gender = @gndr, Address = @addrss, Phone = @phn, DateUpdate = @dtupd Where Id = @id";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@clid", TxtBxCustId.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@clname", TxtBxCustName.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@phn", MskdTxtBxPhn.Text);
                                    updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                    updcmd.Parameters.AddWithValue("@id", getid);

                                    updcmd.ExecuteNonQuery();
                                    DispDGVCustms();
                                    MessageBox.Show("Customer Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "CustmsEdit");
                        }
                    }
                }
                
            }
        }
        

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxCustId.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Record First or Enter CustId to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                            string deldata = "Delete From Clients Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@id", getid);

                                delcmd.ExecuteNonQuery();
                                DispDGVCustms();
                                MessageBox.Show("Customer Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "CustmsDelete");
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
        private void DGVCustms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVCustms.Rows[e.RowIndex];
                    getid = (int)row.Cells[0].Value;

                    TxtBxCustId.Text = (string) row.Cells[1].Value;
                    TxtBxCustName.Text = (string) row.Cells[2].Value;
                    CmbBxGender.Text = (string) row.Cells[3].Value;
                    TxtBxAddress.Text = (string)row.Cells[4].Value;
                    MskdTxtBxPhn.Text = (string)row.Cells[5].Value;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVCustms");
            }
        }

        private void ClearFields()
        {
            TxtBxCustId.Clear();
            TxtBxCustName.Clear();
            TxtBxAddress.Clear();
            MskdTxtBxPhn.Clear();
            CmbBxGender.SelectedIndex = -1;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxCustId.Text) || string.IsNullOrEmpty(TxtBxCustName.Text) || string.IsNullOrEmpty(TxtBxAddress.Text) ||
                string.IsNullOrEmpty(MskdTxtBxPhn.Text) || CmbBxGender.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        private void DispDGVCustms()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Id, ClientId, ClientName, Gender, Address, Phone, DateInsert From Clients";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVCustms.DataSource = dt;
                    }

                        

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispCustms");
                }
            }
        }

        
    }
}
