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
using System.IO;
using System.Xml.Linq;

namespace CarRentalMS
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        string targetpath;
        private void FormCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVCars();
                    DispModelsinCB();  
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
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidPrice(TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string regno = TxtBxRegNo.Text.Trim().ToUpper();
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("CarsDirectory", $"{regno}.jpg");
                    targetpath = Path.Combine(basedirectory, relativepath);

                    string directorypath = Path.GetDirectoryName(targetpath);
                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }

                    if (!string.IsNullOrEmpty(PicBxCar.ImageLocation))
                    {
                        File.Copy(PicBxCar?.ImageLocation, targetpath, true);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "PicBxAdd");
                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkregno = "Select Count(Id) From Cars Where RegNo = @rgno";
                        using (SqlCommand chkcmd = new SqlCommand(chkregno, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@rgno", TxtBxRegNo.Text.Trim());

                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }
                            if (rc > 0)
                            {
                                MessageBox.Show($"RegNo: {TxtBxRegNo.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Cars (RegNo, Brand, Model, Price, Availability, ImagePath, DateInsert) Values (@regno, @brand, @model, @price, @avlb, @imgpath, @dtins)";
                            using (SqlCommand updcmd = new SqlCommand(insdata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@regno", regno);
                                updcmd.Parameters.AddWithValue("@brand", TxtBxBrand.Text.Trim());
                                updcmd.Parameters.AddWithValue("@model", TxtBxModel.Text.Trim());
                                updcmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                updcmd.Parameters.AddWithValue("@avlb", CmbBxAvlb.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                updcmd.ExecuteNonQuery();
                                DispDGVCars();
                                MessageBox.Show("Car Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "CarsAdd");
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
            if (!ValidPrice(TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are You Sure to Edit Id: {getid} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string regno = TxtBxRegNo.Text.Trim().ToUpper();
                    try
                    {
                        string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativepath = Path.Combine("CarsDirectory", $"{regno}.jpg");
                        targetpath = Path.Combine(basedirectory, relativepath);

                        if (!string.IsNullOrEmpty(PicBxCar.ImageLocation))
                        {
                            File.Copy(PicBxCar?.ImageLocation, targetpath, true);
                        }
                        MessageBox.Show("Image Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "PicBxEdit");
                    }
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string upddata = "Update Cars Set Brand = @brand, Model = @model, Price = @price, Availability = @avlb, ImagePath = @imgpath, DateUpdate = @dtupd Where Id = @id";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@id", getid);
                                updcmd.Parameters.AddWithValue("@brand", TxtBxBrand.Text.Trim());
                                updcmd.Parameters.AddWithValue("@model", TxtBxModel.Text.Trim());
                                updcmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                updcmd.Parameters.AddWithValue("@avlb", CmbBxAvlb.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);

                                updcmd.ExecuteNonQuery();
                                DispDGVCars();
                                MessageBox.Show("Car Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "CarsEdit");
                        }
                    }
                    
                   
                }

            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxRegNo.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Record First to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string deldata = "Update Cars Set DateDelete = @dtdel Where Id = @id";

                        using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                        {
                            delcmd.Parameters.AddWithValue("@id", getid);
                            delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);

                            delcmd.ExecuteNonQuery();
                            DispDGVCars();
                            MessageBox.Show("Car Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "CarsDelete");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        int getid;
        private void DGVCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVCars.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    TxtBxRegNo.Text = (string)row.Cells[1].Value;
                    TxtBxBrand.Text = (string)row.Cells[2].Value;
                    TxtBxModel.Text = (string)row.Cells[3].Value;
                    TxtBxPrice.Text = Convert.ToSingle(row.Cells[4].Value).ToString();
                    CmbBxAvlb.Text = (string)row.Cells[5].Value;

                    string imgpath = row.Cells[6].Value.ToString();

                    if (File.Exists(imgpath))
                    {
                        PicBxCar.ImageLocation = imgpath;
                    }
                    PicBxCar.Image = null;
                }
            
        }

        private void Gn2BtnImage_Click(object sender, EventArgs e)
        {
            string imgpath = string.Empty;

            try
            {
                if (Ofd1.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd1.FileName;
                    PicBxCar.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "BtnImage");
            }
            
        }

        private void DispDGVCars()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Id, RegNo, Brand, Model, Price, Availability, ImagePath, DateInsert From Cars";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);    
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVCars.DataSource = dt;    
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispCars"); 
                }
            }
        }

        private void ClearFields()
        {
            TxtBxRegNo.Clear();
            TxtBxBrand.Clear();
            TxtBxModel.Clear();
            TxtBxPrice.Clear();
            CmbBxAvlb.SelectedIndex = -1;
            PicBxCar.Image = null;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxRegNo.Text) || string.IsNullOrEmpty(TxtBxBrand.Text) || string.IsNullOrEmpty(TxtBxModel.Text) || string.IsNullOrEmpty(TxtBxPrice.Text) || CmbBxAvlb.SelectedIndex == -1 || PicBxCar.Image == null)
            {
                return true;
            }
            return false;
        }

        
        private void CmbBxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selmodel = CmbBxModel.Text.Trim();

            if (selmodel != null)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string seldata = $"Select Id, RegNo, Brand, Model, Price, Availability, ImagePath, DateInsert From Cars Where Model = '{selmodel}'";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DGVCars.DataSource = dt;    
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "CmbBxModel");
                    }
                }
            }
        }

        private void Gn2BtnRefresh_Click(object sender, EventArgs e)
        {
            DispDGVCars();
            CmbBxModel.Text = "Select Model";
        }

        private void DispModelsinCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    CmbBxModel.Items.Clear();
                    sqlcon.Open();

                    string seldata = "Select Model From Cars";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while(sdr.Read())
                            {
                                string model = (string)sdr["Model"];
                                CmbBxModel.Items.Add(model);
                            }
                        }
                        sdr.Close();
                    }
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispModels");
                }
            }
        }

        private bool ValidPrice(string pricetext, out float price)
        {
            if (float.TryParse(pricetext, out price))
            {
                if (price >= 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
