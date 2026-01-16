namespace CarRentalMS
{
    partial class FormLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Gn2CPBCar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Gn2CPrgBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbPercent = new System.Windows.Forms.Label();
            this.LbCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPBCar)).BeginInit();
            this.Gn2CPrgBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.LbHeading.Location = new System.Drawing.Point(29, 30);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(621, 43);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "AMENITY CAR RENTAL COMPANY";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gn2CPBCar
            // 
            this.Gn2CPBCar.BackColor = System.Drawing.Color.Transparent;
            this.Gn2CPBCar.Image = global::CarRentalMS.Properties.Resources.Car;
            this.Gn2CPBCar.ImageRotate = 0F;
            this.Gn2CPBCar.Location = new System.Drawing.Point(60, 60);
            this.Gn2CPBCar.Name = "Gn2CPBCar";
            this.Gn2CPBCar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Gn2CPBCar.Size = new System.Drawing.Size(180, 180);
            this.Gn2CPBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gn2CPBCar.TabIndex = 1;
            this.Gn2CPBCar.TabStop = false;
            // 
            // Gn2CPrgBar1
            // 
            this.Gn2CPrgBar1.Controls.Add(this.LbPercent);
            this.Gn2CPrgBar1.Controls.Add(this.Gn2CPBCar);
            this.Gn2CPrgBar1.FillColor = System.Drawing.Color.Silver;
            this.Gn2CPrgBar1.FillThickness = 20;
            this.Gn2CPrgBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Gn2CPrgBar1.ForeColor = System.Drawing.Color.White;
            this.Gn2CPrgBar1.InnerColor = System.Drawing.Color.Goldenrod;
            this.Gn2CPrgBar1.Location = new System.Drawing.Point(189, 116);
            this.Gn2CPrgBar1.Minimum = 0;
            this.Gn2CPrgBar1.Name = "Gn2CPrgBar1";
            this.Gn2CPrgBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.Gn2CPrgBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.Gn2CPrgBar1.ProgressColor2 = System.Drawing.Color.SteelBlue;
            this.Gn2CPrgBar1.ProgressThickness = 20;
            this.Gn2CPrgBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Gn2CPrgBar1.ShowText = true;
            this.Gn2CPrgBar1.Size = new System.Drawing.Size(300, 300);
            this.Gn2CPrgBar1.TabIndex = 2;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 40;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LbPercent
            // 
            this.LbPercent.AutoSize = true;
            this.LbPercent.BackColor = System.Drawing.Color.Transparent;
            this.LbPercent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LbPercent.Location = new System.Drawing.Point(132, 230);
            this.LbPercent.Name = "LbPercent";
            this.LbPercent.Size = new System.Drawing.Size(29, 28);
            this.LbPercent.TabIndex = 2;
            this.LbPercent.Text = "%";
            this.LbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbCaption
            // 
            this.LbCaption.AutoSize = true;
            this.LbCaption.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.LbCaption.Location = new System.Drawing.Point(162, 470);
            this.LbCaption.Name = "LbCaption";
            this.LbCaption.Size = new System.Drawing.Size(355, 34);
            this.LbCaption.TabIndex = 3;
            this.LbCaption.Text = "MAKE YOUR TOUR EASY";
            this.LbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.LbCaption);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Gn2CPrgBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLoad";
            this.Text = "Car Rental System";
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPBCar)).EndInit();
            this.Gn2CPrgBar1.ResumeLayout(false);
            this.Gn2CPrgBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Gn2CPBCar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Gn2CPrgBar1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LbPercent;
        private System.Windows.Forms.Label LbCaption;
    }
}

