namespace CarRentalMS
{
    partial class FormLogin
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
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.LbLine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gn2TBUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gn2TBPswrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gn2BtnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gn2CPBCar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPBCar)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.LbHeading.Location = new System.Drawing.Point(79, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(621, 43);
            this.LbHeading.TabIndex = 3;
            this.LbHeading.Text = "AMENITY CAR RENTAL COMPANY";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.LbLogin.Location = new System.Drawing.Point(585, 215);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(113, 34);
            this.LbLogin.TabIndex = 4;
            this.LbLogin.Text = "SIGNIN";
            this.LbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbLine
            // 
            this.LbLine.BackColor = System.Drawing.Color.Lavender;
            this.LbLine.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.LbLine.Location = new System.Drawing.Point(0, 70);
            this.LbLine.Name = "LbLine";
            this.LbLine.Size = new System.Drawing.Size(778, 4);
            this.LbLine.TabIndex = 5;
            this.LbLine.Text = "LOGIN";
            this.LbLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2TBUsername
            // 
            this.Gn2TBUsername.Animated = true;
            this.Gn2TBUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2TBUsername.BorderThickness = 4;
            this.Gn2TBUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBUsername.DefaultText = "";
            this.Gn2TBUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2TBUsername.ForeColor = System.Drawing.Color.Navy;
            this.Gn2TBUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBUsername.Location = new System.Drawing.Point(153, 122);
            this.Gn2TBUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gn2TBUsername.Name = "Gn2TBUsername";
            this.Gn2TBUsername.PlaceholderText = "";
            this.Gn2TBUsername.SelectedText = "";
            this.Gn2TBUsername.Size = new System.Drawing.Size(300, 35);
            this.Gn2TBUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Gn2TBUsername.TabIndex = 8;
            // 
            // Gn2TBPswrd
            // 
            this.Gn2TBPswrd.Animated = true;
            this.Gn2TBPswrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2TBPswrd.BorderThickness = 4;
            this.Gn2TBPswrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBPswrd.DefaultText = "";
            this.Gn2TBPswrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBPswrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBPswrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBPswrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBPswrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2TBPswrd.ForeColor = System.Drawing.Color.Navy;
            this.Gn2TBPswrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBPswrd.Location = new System.Drawing.Point(153, 184);
            this.Gn2TBPswrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gn2TBPswrd.Name = "Gn2TBPswrd";
            this.Gn2TBPswrd.PlaceholderText = "";
            this.Gn2TBPswrd.SelectedText = "";
            this.Gn2TBPswrd.Size = new System.Drawing.Size(300, 35);
            this.Gn2TBPswrd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Gn2TBPswrd.TabIndex = 9;
            this.Gn2TBPswrd.UseSystemPasswordChar = true;
            // 
            // Gn2BtnSignIn
            // 
            this.Gn2BtnSignIn.Animated = true;
            this.Gn2BtnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnSignIn.BorderThickness = 4;
            this.Gn2BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnSignIn.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnSignIn.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnSignIn.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnSignIn.Location = new System.Drawing.Point(39, 323);
            this.Gn2BtnSignIn.Name = "Gn2BtnSignIn";
            this.Gn2BtnSignIn.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnSignIn.TabIndex = 10;
            this.Gn2BtnSignIn.Text = "SignIn";
            this.Gn2BtnSignIn.Click += new System.EventHandler(this.Gn2BtnSignIn_Click);
            // 
            // Gn2BtnClear
            // 
            this.Gn2BtnClear.Animated = true;
            this.Gn2BtnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnClear.BorderThickness = 4;
            this.Gn2BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnClear.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnClear.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnClear.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnClear.Location = new System.Drawing.Point(273, 323);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnClear.TabIndex = 11;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // Gn2BtnRegister
            // 
            this.Gn2BtnRegister.Animated = true;
            this.Gn2BtnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnRegister.BorderThickness = 4;
            this.Gn2BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnRegister.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnRegister.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnRegister.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnRegister.Location = new System.Drawing.Point(88, 549);
            this.Gn2BtnRegister.Name = "Gn2BtnRegister";
            this.Gn2BtnRegister.Size = new System.Drawing.Size(300, 50);
            this.Gn2BtnRegister.TabIndex = 12;
            this.Gn2BtnRegister.Text = "Register";
            this.Gn2BtnRegister.Click += new System.EventHandler(this.Gn2BtnRegister_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(286, 235);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(167, 25);
            this.ChkBxPswrd.TabIndex = 13;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(133, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "No Account Yet ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalMS.Properties.Resources.YellowCar;
            this.pictureBox1.Location = new System.Drawing.Point(491, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Gn2CPBCar
            // 
            this.Gn2CPBCar.BackColor = System.Drawing.Color.DarkKhaki;
            this.Gn2CPBCar.Image = global::CarRentalMS.Properties.Resources.User;
            this.Gn2CPBCar.ImageRotate = 0F;
            this.Gn2CPBCar.Location = new System.Drawing.Point(591, 110);
            this.Gn2CPBCar.Name = "Gn2CPBCar";
            this.Gn2CPBCar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Gn2CPBCar.Size = new System.Drawing.Size(100, 100);
            this.Gn2CPBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gn2CPBCar.TabIndex = 2;
            this.Gn2CPBCar.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.Gn2BtnRegister);
            this.Controls.Add(this.Gn2BtnClear);
            this.Controls.Add(this.Gn2BtnSignIn);
            this.Controls.Add(this.Gn2TBPswrd);
            this.Controls.Add(this.Gn2TBUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLine);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Gn2CPBCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Opacity = 0.8D;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPBCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Gn2CPBCar;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label LbLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBUsername;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBPswrd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnSignIn;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnRegister;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}