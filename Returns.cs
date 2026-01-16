using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalMS
{
    public partial class FormReturns : Form
    {
        public FormReturns()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";
        private void FormReturns_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }

        private void FormReturns_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVRents();
                    DispDGVReturns();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CarsLoad");
                }
            }
        }
        private void Gn2BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkreturnid = "Select Count(Id) From Returns Where ReturnId = @retid";
                        using (SqlCommand chkcmd =  new SqlCommand(chkreturnid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@retid", TxtBxReturnId.Text.Trim());

                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();    
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show($"ReturnId: {TxtBxReturnId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Returns (ReturnId, RegNo, CustName, DateTo, Delay, Fine, DateInsert) Values (@rtnid, @rgno, @cstname, @dtto, @delay, @fine, @dtins)";
                            using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@rtnid", TxtBxReturnId.Text.Trim());
                                inscmd.Parameters.AddWithValue("@rgno", TxtBxRegNo.Text.Trim());
                                inscmd.Parameters.AddWithValue("@cstname", TxtBxCustName.Text);
                                inscmd.Parameters.AddWithValue("@dtto", DTPReturn.Value);
                                inscmd.Parameters.AddWithValue("@delay", TxtBxDelay.Text);
                                inscmd.Parameters.AddWithValue("@fine", TxtBxFine.Text);
                                inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                DispDGVReturns();
                                MessageBox.Show("Return Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                string upddata = "Update Rents Set DateDelete = @dtdel Where CustName = @cstname";

                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@cstname", TxtBxCustName.Text);
                                    updcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);

                                    updcmd.ExecuteNonQuery();
                                }
                                ClearFields();
                                
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "ReturnsAdd");
                    }
                }
            }
        }

        private void Gn2BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure To Edit Id: {getid} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string chkreturnid = "Select Count(Id) From Returns Where ReturnId = @rtnid";

                            using (SqlCommand chkcmd = new SqlCommand(chkreturnid, sqlcon))
                            {
                                chkcmd.Parameters.AddWithValue("@rtnid", TxtBxReturnId.Text.Trim());
                                int rc = 0;
                                object res = chkcmd.ExecuteScalar();
                                if (res != DBNull.Value)
                                {
                                    rc = Convert.ToInt32(res);
                                }

                                if (rc >= 2)
                                {
                                    MessageBox.Show($"ReturnId: {TxtBxReturnId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    return;
                                }

                                string upddata = "Update Returns Set ReturnId = @rtnid, RegNo = @rgno, CustName = @cstname, DateTo = @dtto, @Delay = @delay, Fine = @fine Where Id = @id";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@rtnid", TxtBxRegNo.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@rgno", TxtBxRegNo.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@cstname", TxtBxCustName.Text);
                                    updcmd.Parameters.AddWithValue("@dtto", DTPReturn.Value);
                                    updcmd.Parameters.AddWithValue("@delay", TxtBxDelay.Text);
                                    updcmd.Parameters.AddWithValue("@fine", TxtBxFine.Text);
                                    updcmd.Parameters.AddWithValue("@id", getid);
                                   

                                    updcmd.ExecuteNonQuery();
                                    DispDGVReturns();
                                    MessageBox.Show("Return Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }


                            }
                                
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ReturnsEdit");
                        }

                    }
                }
            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxReturnId.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Record First to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure To Delete Id: {getid} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string deldata = "Delete From Returns Where Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@id", getid);

                                delcmd.ExecuteNonQuery();
                                DispDGVReturns();
                                MessageBox.Show("Return Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (SqlException ex)
                        {
                            Debug.WriteLine(ex.Message, "ReturnsDelete");
                        }
                    }
                }

            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DGVRents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVRents.Rows[e.RowIndex];

                    TxtBxRegNo.Text = (string)row.Cells[2].Value;
                    TxtBxCustName.Text = (string)row.Cells[3].Value;
                    DTPReturn.Value = (Convert.ToDateTime(row.Cells[5].Value));

                    DateTime d1 = DTPReturn.Value.Date;
                    DateTime d2 = DateTime.Today;
                    TimeSpan ts = d2 - d1;
                    int days = (int)ts.Days;
                    if (days <= 0)
                    {
                        TxtBxDelay.Text = "0";
                        TxtBxFine.Text = "0";
                    }
                    else
                    {
                        TxtBxDelay.Text = $"{days}";
                        TxtBxFine.Text = $"{days * 200}";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVRents");
            }
            
        }

        int getid;
        private void DGVReturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVReturns.Rows[e.RowIndex];
                    getid = (int)row.Cells[0].Value;

                    TxtBxReturnId.Text = (string)row.Cells[1].Value;
                    TxtBxRegNo.Text = (string)row.Cells[2].Value;
                    TxtBxCustName.Text = (string)row.Cells[3].Value;
                    DTPReturn.Value = (Convert.ToDateTime(row.Cells[4].Value));
                    TxtBxDelay.Text = row.Cells[5].Value.ToString();
                    TxtBxFine.Text = (Convert.ToSingle(row.Cells[6].Value)).ToString();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVReturns");
            }
        }


        private void DispDGVRents()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Id, RentId, RegNo, CustName, DateFrom, DateTo, Charge From Rents Where DateDelete is NULL";
                    using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVRents.DataSource = dt;   
                    }

                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispRents");
                }
            }
        }

        private void DispDGVReturns()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Returns";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVReturns.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispReturns");
                }
            }
        }

        private void ClearFields()
        {
            TxtBxReturnId.Clear();
            TxtBxDelay.Clear();
            TxtBxFine.Clear();
            TxtBxRegNo.Clear();
            TxtBxCustName.Clear();
            DTPReturn.Text = string.Empty;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxReturnId.Text) || string.IsNullOrEmpty(TxtBxRegNo.Text) || string.IsNullOrEmpty(TxtBxCustName.Text) ||
               string.IsNullOrEmpty(DTPReturn.Text) || string.IsNullOrEmpty(TxtBxDelay.Text) || string.IsNullOrEmpty(TxtBxFine.Text))
            {
                return true;
            }
            return false;
        }

        
    }
}
