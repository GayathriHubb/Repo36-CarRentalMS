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
    public partial class FormRents : Form
    {
        public FormRents()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        private void FormRents_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }

        private void FormRents_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVRents();
                    FetchRegNoinCB();
                    FetchCustIdInCB();  
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CarsLoad");
                }
            }
        }

        private void Gn2BtnAdd_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
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
                        CalcCharge();
                        string chkrentid = "Select Count(Id) From Rents Where RentId = @rntid AND DateDelete is NULL";
                        using (SqlCommand chkcmd = new SqlCommand(chkrentid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@rntid", TxtBxRentId.Text.Trim());
                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = (int)res;
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show($"RentId: {TxtBxRentId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Rents (RentId, RegNo, CustId, CustName, DateFrom, DateTo, Charge, DateInsert) Values (@rntid, @rgno, @cstid, @cstname,@dtfrom, @dtto, @charge, @dtins)";
                            using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@rntid", TxtBxRentId.Text.Trim().ToUpper());
                                inscmd.Parameters.AddWithValue("@rgno",CmbBxRegNo.Text.Trim());
                                inscmd.Parameters.AddWithValue("@cstid", CmbBxCustId.Text);
                                inscmd.Parameters.AddWithValue("@cstname", TxtBxCustName.Text.Trim());
                                inscmd.Parameters.AddWithValue("@dtfrom", DTPFrom.Value);
                                inscmd.Parameters.AddWithValue("@dtto", DTPTo.Value);
                                inscmd.Parameters.AddWithValue("@charge", TxtBxCharge.Text.Trim());
                                inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                DispDGVRents();
                                MessageBox.Show("Rent Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();  
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "RentsAdd");
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
                DialogResult dr = MessageBox.Show($"Are you Sure To Edit Id: {getid} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            CalcCharge();

                            string upddata = "Update Rents Set RentId = @rntid, RegNo = @rgno, CustId = @cstid, CustName = @cstname, DateFrom = @dtfrm, DateTo = @dtto, Charge = @charge, DateUpdate = @dtupd Where Id = @id";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@rntid", TxtBxRentId.Text.Trim().ToUpper());
                                updcmd.Parameters.AddWithValue("@rgno", CmbBxRegNo.Text.Trim());
                                updcmd.Parameters.AddWithValue("@cstid", CmbBxCustId.Text);
                                updcmd.Parameters.AddWithValue("@cstname", TxtBxCustName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dtfrm", DTPFrom.Value);
                                updcmd.Parameters.AddWithValue("@dtto", DTPTo.Value);
                                updcmd.Parameters.AddWithValue("@charge", TxtBxCharge.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                updcmd.Parameters.AddWithValue("@id", getid);

                                updcmd.ExecuteNonQuery();
                                DispDGVRents();
                                MessageBox.Show("Rent Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "RentsEdit");
                        }
                    }
                }
            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxRentId.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Record First to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure To Delete Id: {getid} ? ", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From Rents Where Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@id", getid);

                                delcmd.ExecuteNonQuery();
                                DispDGVRents();
                                MessageBox.Show("Rent Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "RentsDelete");
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
        private void DGVRents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVRents.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    TxtBxRentId.Text = (string) row.Cells[1].Value;
                    CmbBxRegNo.Text = (string)row.Cells[2].Value;
                    CmbBxCustId.Text = (string)row.Cells[3].Value;
                    TxtBxCustName.Text = (string)row.Cells[4].Value;
                    DTPFrom.Value = (Convert.ToDateTime(row.Cells[5].Value));
                    DTPTo.Value = (Convert.ToDateTime(row.Cells[6].Value));
                    TxtBxCharge.Text = (Convert.ToSingle(row.Cells[7].Value).ToString());

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVRents");
            }
        }

        private void DispDGVRents()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Id, RentId, RegNo, CustId, CustName, DateFrom, DateTo, Charge, DateInsert From Rents Where DateDelete is NULL";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
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

        private void FetchRegNoinCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    CmbBxRegNo.Items.Clear();   
                    sqlcon.Open();
                    string seldata = "Select * From Cars";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                string regno = (string)sdr["RegNo"];
                                CmbBxRegNo.Items.Add(regno);
                            }
                        }
                        sdr.Close();

                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message, "FetchRegNo");
                }
            }
        }

        private void FetchCustIdInCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    CmbBxCustId.Items.Clear();
                    sqlcon.Open();
                    string seldata = "Select * From Clients";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if(sdr.HasRows)
                        {
                            while(sdr.Read())
                            {
                                string custid = (string)sdr["ClientId"];
                                CmbBxCustId.Items.Add(custid);  
                            }
                        }
                        sdr.Close();

                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message, "FetchCustId");
                }
            }
        }

       float charge;
       private void CalcCharge()
       {
            if (DTPTo.Value <= DTPFrom.Value)
            {
                TxtBxCharge.Text = string.Empty;
                return;
            }
            GetPrice();

            DateTime dtfrom = DTPFrom.Value;
            DateTime dtto = DTPTo.Value;
            TimeSpan ts = dtto - dtfrom;
            int days = (int)ts.Days;
            charge = days * getprice;
            TxtBxCharge.Text = $"{charge:0.##}";
       }

        float getprice;
        private void GetPrice()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Cars Where RegNo = @rgno";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@rgno", CmbBxRegNo.Text.Trim());
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            if (sdr["Price"] != DBNull.Value)
                            {
                                getprice = Convert.ToSingle(sdr["Price"]);

                            }
                            sdr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "GetPrice");
                }
            }
        }

        private void CmbBxCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selcustid = CmbBxCustId.Text;
            TxtBxCustName.Text = string.Empty;

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = $"Select ClientName From Clients Where ClientId = '{selcustid}'";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            object rawname = sdr["ClientName"];
                            if (rawname != DBNull.Value)
                            {
                                TxtBxCustName.Text = rawname.ToString();    
                            }
                        }
                        sdr.Close();
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CmbBxCustId");
                }
            }
        }

        private void Gn2BtnCharge_Click(object sender, EventArgs e)
        {
            CalcCharge();
        }

        private void DTPFrom_ValueChanged(object sender, EventArgs e)
        {
            CalcCharge();
        }

        private void DTPTo_ValueChanged(object sender, EventArgs e)
        {
            CalcCharge();
        }

        private void ClearFields()
        {
            TxtBxRentId.Clear();
            TxtBxCustName.Clear();
            TxtBxCharge.Text = string.Empty;
            CmbBxRegNo.SelectedIndex = -1;
            CmbBxCustId.SelectedIndex = -1;
            DTPFrom.Text = string.Empty;
            DTPTo.Text = string.Empty;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxRentId.Text) || string.IsNullOrEmpty(TxtBxCustName.Text) || string.IsNullOrEmpty(TxtBxCharge.Text) ||
                CmbBxCustId.SelectedIndex == -1 || CmbBxRegNo.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }
    }
}
