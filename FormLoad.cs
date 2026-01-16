using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalMS
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Gn2CPrgBar1.Value += 1;
            LbPercent.Text = $"{Gn2CPrgBar1.Value}%";

            if (Gn2CPrgBar1.Value >= 100)
            {
                Gn2CPrgBar1.Value = 0;
                Timer1.Stop();

                FormLogin frmlgn = new FormLogin();
                frmlgn.Show();
                Hide();
            }
        }
    }
}
