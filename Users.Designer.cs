namespace CarRentalMS
{
    partial class FormUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gn2BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.LbRentId = new System.Windows.Forms.Label();
            this.LbCars = new System.Windows.Forms.Label();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.Pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl2.Controls.Add(this.DGVUsers);
            this.Pnl2.Location = new System.Drawing.Point(424, 50);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(540, 580);
            this.Pnl2.TabIndex = 7;
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            this.DGVUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUsers.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUsers.ColumnHeadersHeight = 34;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.Location = new System.Drawing.Point(10, 10);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.ReadOnly = true;
            this.DGVUsers.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUsers.RowTemplate.Height = 28;
            this.DGVUsers.Size = new System.Drawing.Size(520, 550);
            this.DGVUsers.TabIndex = 0;
            this.DGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellClick);
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl1.Controls.Add(this.TxtBxPassword);
            this.Pnl1.Controls.Add(this.CmbBxStatus);
            this.Pnl1.Controls.Add(this.label4);
            this.Pnl1.Controls.Add(this.label3);
            this.Pnl1.Controls.Add(this.Gn2BtnDelete);
            this.Pnl1.Controls.Add(this.Gn2BtnEdit);
            this.Pnl1.Controls.Add(this.Gn2BtnAdd);
            this.Pnl1.Controls.Add(this.Gn2BtnClear);
            this.Pnl1.Controls.Add(this.TxtBxUsername);
            this.Pnl1.Controls.Add(this.LbRentId);
            this.Pnl1.Location = new System.Drawing.Point(14, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(400, 580);
            this.Pnl1.TabIndex = 6;
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(133, 136);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.Size = new System.Drawing.Size(250, 31);
            this.TxtBxPassword.TabIndex = 6;
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CmbBxStatus.Location = new System.Drawing.Point(133, 194);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(250, 29);
            this.CmbBxStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnDelete
            // 
            this.Gn2BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnDelete.Animated = true;
            this.Gn2BtnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnDelete.BorderThickness = 4;
            this.Gn2BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnDelete.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnDelete.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnDelete.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.Gn2BtnDelete.Location = new System.Drawing.Point(25, 460);
            this.Gn2BtnDelete.Name = "Gn2BtnDelete";
            this.Gn2BtnDelete.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnDelete.TabIndex = 3;
            this.Gn2BtnDelete.Text = "Delete";
            this.Gn2BtnDelete.Click += new System.EventHandler(this.Gn2BtnDelete_Click);
            // 
            // Gn2BtnEdit
            // 
            this.Gn2BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnEdit.Animated = true;
            this.Gn2BtnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnEdit.BorderThickness = 4;
            this.Gn2BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnEdit.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnEdit.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnEdit.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnEdit.Location = new System.Drawing.Point(256, 409);
            this.Gn2BtnEdit.Name = "Gn2BtnEdit";
            this.Gn2BtnEdit.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnEdit.TabIndex = 2;
            this.Gn2BtnEdit.Text = "Edit";
            this.Gn2BtnEdit.Click += new System.EventHandler(this.Gn2BtnEdit_Click);
            // 
            // Gn2BtnAdd
            // 
            this.Gn2BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnAdd.Animated = true;
            this.Gn2BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnAdd.BorderThickness = 4;
            this.Gn2BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnAdd.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnAdd.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnAdd.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnAdd.Location = new System.Drawing.Point(25, 409);
            this.Gn2BtnAdd.Name = "Gn2BtnAdd";
            this.Gn2BtnAdd.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnAdd.TabIndex = 1;
            this.Gn2BtnAdd.Text = "Add";
            this.Gn2BtnAdd.Click += new System.EventHandler(this.Gn2BtnAdd_Click);
            // 
            // Gn2BtnClear
            // 
            this.Gn2BtnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.Gn2BtnClear.Location = new System.Drawing.Point(256, 460);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnClear.TabIndex = 4;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(133, 78);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(250, 31);
            this.TxtBxUsername.TabIndex = 5;
            // 
            // LbRentId
            // 
            this.LbRentId.AutoSize = true;
            this.LbRentId.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRentId.Location = new System.Drawing.Point(18, 136);
            this.LbRentId.Name = "LbRentId";
            this.LbRentId.Size = new System.Drawing.Size(99, 24);
            this.LbRentId.TabIndex = 8;
            this.LbRentId.Text = "Password";
            this.LbRentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbCars
            // 
            this.LbCars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbCars.AutoSize = true;
            this.LbCars.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold);
            this.LbCars.ForeColor = System.Drawing.Color.Lavender;
            this.LbCars.Location = new System.Drawing.Point(454, 9);
            this.LbCars.Name = "LbCars";
            this.LbCars.Size = new System.Drawing.Size(71, 24);
            this.LbCars.TabIndex = 8;
            this.LbCars.Text = "USERS";
            this.LbCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbCars);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUsers";
            this.Text = "Car Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDelete;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnEdit;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAdd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Label LbRentId;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.Label LbCars;
    }
}