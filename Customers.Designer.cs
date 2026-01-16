namespace CarRentalMS
{
    partial class FormCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.MskdTxtBxPhn = new System.Windows.Forms.MaskedTextBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.LbGender = new System.Windows.Forms.Label();
            this.Gn2BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBxAddress = new System.Windows.Forms.TextBox();
            this.TxtBxCustName = new System.Windows.Forms.TextBox();
            this.TxtBxCustId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbCustId = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVCustms = new System.Windows.Forms.DataGridView();
            this.Pnl1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustms)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl1.Controls.Add(this.MskdTxtBxPhn);
            this.Pnl1.Controls.Add(this.CmbBxGender);
            this.Pnl1.Controls.Add(this.LbGender);
            this.Pnl1.Controls.Add(this.Gn2BtnDelete);
            this.Pnl1.Controls.Add(this.Gn2BtnEdit);
            this.Pnl1.Controls.Add(this.Gn2BtnAdd);
            this.Pnl1.Controls.Add(this.Gn2BtnClear);
            this.Pnl1.Controls.Add(this.TxtBxAddress);
            this.Pnl1.Controls.Add(this.TxtBxCustName);
            this.Pnl1.Controls.Add(this.TxtBxCustId);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.label3);
            this.Pnl1.Controls.Add(this.LbCustId);
            this.Pnl1.Location = new System.Drawing.Point(10, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(400, 580);
            this.Pnl1.TabIndex = 0;
            // 
            // MskdTxtBxPhn
            // 
            this.MskdTxtBxPhn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskdTxtBxPhn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskdTxtBxPhn.Location = new System.Drawing.Point(34, 403);
            this.MskdTxtBxPhn.Mask = "0000000000";
            this.MskdTxtBxPhn.Name = "MskdTxtBxPhn";
            this.MskdTxtBxPhn.Size = new System.Drawing.Size(316, 31);
            this.MskdTxtBxPhn.TabIndex = 9;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(120, 178);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(230, 33);
            this.CmbBxGender.TabIndex = 7;
            // 
            // LbGender
            // 
            this.LbGender.AutoSize = true;
            this.LbGender.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGender.Location = new System.Drawing.Point(30, 182);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(78, 24);
            this.LbGender.TabIndex = 20;
            this.LbGender.Text = "Gender";
            this.LbGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Gn2BtnDelete.Location = new System.Drawing.Point(34, 511);
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
            this.Gn2BtnEdit.Location = new System.Drawing.Point(230, 460);
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
            this.Gn2BtnAdd.Location = new System.Drawing.Point(34, 460);
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
            this.Gn2BtnClear.Location = new System.Drawing.Point(230, 511);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnClear.TabIndex = 4;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // TxtBxAddress
            // 
            this.TxtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddress.Location = new System.Drawing.Point(30, 260);
            this.TxtBxAddress.Multiline = true;
            this.TxtBxAddress.Name = "TxtBxAddress";
            this.TxtBxAddress.Size = new System.Drawing.Size(320, 100);
            this.TxtBxAddress.TabIndex = 8;
            // 
            // TxtBxCustName
            // 
            this.TxtBxCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCustName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCustName.Location = new System.Drawing.Point(30, 125);
            this.TxtBxCustName.Name = "TxtBxCustName";
            this.TxtBxCustName.Size = new System.Drawing.Size(320, 31);
            this.TxtBxCustName.TabIndex = 6;
            // 
            // TxtBxCustId
            // 
            this.TxtBxCustId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCustId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCustId.Location = new System.Drawing.Point(30, 47);
            this.TxtBxCustId.Name = "TxtBxCustId";
            this.TxtBxCustId.Size = new System.Drawing.Size(200, 31);
            this.TxtBxCustId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "CustName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbCustId
            // 
            this.LbCustId.AutoSize = true;
            this.LbCustId.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCustId.Location = new System.Drawing.Point(30, 20);
            this.LbCustId.Name = "LbCustId";
            this.LbCustId.Size = new System.Drawing.Size(69, 24);
            this.LbCustId.TabIndex = 8;
            this.LbCustId.Text = "CustId";
            this.LbCustId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.Lavender;
            this.LbHeading.Location = new System.Drawing.Point(421, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(136, 24);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "CUSTOMERS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl2.Controls.Add(this.DGVCustms);
            this.Pnl2.Location = new System.Drawing.Point(420, 50);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(540, 580);
            this.Pnl2.TabIndex = 1;
            // 
            // DGVCustms
            // 
            this.DGVCustms.AllowUserToAddRows = false;
            this.DGVCustms.AllowUserToDeleteRows = false;
            this.DGVCustms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCustms.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGVCustms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCustms.ColumnHeadersHeight = 34;
            this.DGVCustms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCustms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCustms.EnableHeadersVisualStyles = false;
            this.DGVCustms.Location = new System.Drawing.Point(10, 15);
            this.DGVCustms.Name = "DGVCustms";
            this.DGVCustms.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVCustms.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCustms.RowTemplate.Height = 28;
            this.DGVCustms.Size = new System.Drawing.Size(520, 550);
            this.DGVCustms.TabIndex = 0;
            this.DGVCustms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustms_CellClick);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCustomers";
            this.Text = "Car Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomers_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbCustId;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.TextBox TxtBxCustName;
        private System.Windows.Forms.TextBox TxtBxCustId;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAdd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDelete;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnEdit;
        private System.Windows.Forms.DataGridView DGVCustms;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.MaskedTextBox MskdTxtBxPhn;
    }
}