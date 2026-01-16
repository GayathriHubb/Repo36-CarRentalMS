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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CarRentalMS\CarRental.mdf;Integrated Security = True";

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            Hide();
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    TotalCarsCount();
                    TotalUsersCount();  
                    TotalCustmsCount();
                    DispAvlbCars();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DashboardLoad");
                }
            }
        }

        public void TotalCarsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(Id) From Cars";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            LbTotCars.Text = Convert.ToInt32(res).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotCarsCnt");
                }
            }
        }

        public void TotalUsersCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(Id) From Users";
                    using (SqlCommand selcmd = new SqlCommand( seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            LbTotUsers.Text = Convert.ToInt32(res).ToString();  
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotUsersCnt");
                }
            }
        }

        public void TotalCustmsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(Id) From Clients";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            LbTotCustms.Text = Convert.ToInt32(res).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotCustmsCnt");
                }
            }
        }

        public void DispAvlbCars()
        {
            using (SqlConnection sqlcon = new SqlConnection (constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select RegNo, Brand, Model, Price, Availability, ImagePath, DateInsert From Cars Where Availability = @avl";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@avl", "Yes");

                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVAvlbCars.DataSource = dt;
                    }

                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispAvlbCars");
                }

            }
        }

        
    }
}
