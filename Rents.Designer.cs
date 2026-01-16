namespace CarRentalMS
{
    partial class FormRents
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
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVRents = new System.Windows.Forms.DataGridView();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Gn2BtnCharge = new Guna.UI2.WinForms.Guna2Button();
            this.CmbBxRegNo = new System.Windows.Forms.ComboBox();
            this.CmbBxCustId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBxCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gn2BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBxCharge = new System.Windows.Forms.TextBox();
            this.TxtBxRentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbRentId = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRents)).BeginInit();
            this.Pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl2.Controls.Add(this.DGVRents);
            this.Pnl2.Location = new System.Drawing.Point(424, 50);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(540, 580);
            this.Pnl2.TabIndex = 5;
            // 
            // DGVRents
            // 
            this.DGVRents.AllowUserToAddRows = false;
            this.DGVRents.AllowUserToDeleteRows = false;
            this.DGVRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRents.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGVRents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRents.ColumnHeadersHeight = 34;
            this.DGVRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVRents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVRents.EnableHeadersVisualStyles = false;
            this.DGVRents.Location = new System.Drawing.Point(10, 10);
            this.DGVRents.Name = "DGVRents";
            this.DGVRents.ReadOnly = true;
            this.DGVRents.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVRents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRents.RowTemplate.Height = 28;
            this.DGVRents.Size = new System.Drawing.Size(520, 550);
            this.DGVRents.TabIndex = 0;
            this.DGVRents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRents_CellClick);
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl1.Controls.Add(this.Gn2BtnCharge);
            this.Pnl1.Controls.Add(this.CmbBxRegNo);
            this.Pnl1.Controls.Add(this.CmbBxCustId);
            this.Pnl1.Controls.Add(this.label6);
            this.Pnl1.Controls.Add(this.TxtBxCustName);
            this.Pnl1.Controls.Add(this.label5);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.DTPTo);
            this.Pnl1.Controls.Add(this.DTPFrom);
            this.Pnl1.Controls.Add(this.label4);
            this.Pnl1.Controls.Add(this.label3);
            this.Pnl1.Controls.Add(this.Gn2BtnDelete);
            this.Pnl1.Controls.Add(this.Gn2BtnEdit);
            this.Pnl1.Controls.Add(this.Gn2BtnAdd);
            this.Pnl1.Controls.Add(this.Gn2BtnClear);
            this.Pnl1.Controls.Add(this.TxtBxCharge);
            this.Pnl1.Controls.Add(this.TxtBxRentId);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.LbRentId);
            this.Pnl1.Location = new System.Drawing.Point(14, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(400, 580);
            this.Pnl1.TabIndex = 4;
            // 
            // Gn2BtnCharge
            // 
            this.Gn2BtnCharge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnCharge.Animated = true;
            this.Gn2BtnCharge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnCharge.BorderThickness = 4;
            this.Gn2BtnCharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnCharge.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCharge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnCharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnCharge.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnCharge.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnCharge.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnCharge.Location = new System.Drawing.Point(25, 428);
            this.Gn2BtnCharge.Name = "Gn2BtnCharge";
            this.Gn2BtnCharge.Size = new System.Drawing.Size(348, 40);
            this.Gn2BtnCharge.TabIndex = 28;
            this.Gn2BtnCharge.Text = "Calc Charge";
            this.Gn2BtnCharge.Click += new System.EventHandler(this.Gn2BtnCharge_Click);
            // 
            // CmbBxRegNo
            // 
            this.CmbBxRegNo.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxRegNo.FormattingEnabled = true;
            this.CmbBxRegNo.Location = new System.Drawing.Point(135, 83);
            this.CmbBxRegNo.Name = "CmbBxRegNo";
            this.CmbBxRegNo.Size = new System.Drawing.Size(250, 29);
            this.CmbBxRegNo.TabIndex = 6;
            // 
            // CmbBxCustId
            // 
            this.CmbBxCustId.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxCustId.FormattingEnabled = true;
            this.CmbBxCustId.Location = new System.Drawing.Point(135, 145);
            this.CmbBxCustId.Name = "CmbBxCustId";
            this.CmbBxCustId.Size = new System.Drawing.Size(250, 29);
            this.CmbBxCustId.TabIndex = 7;
            this.CmbBxCustId.SelectedIndexChanged += new System.EventHandler(this.CmbBxCustId_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "CustName";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxCustName
            // 
            this.TxtBxCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCustName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCustName.Location = new System.Drawing.Point(135, 200);
            this.TxtBxCustName.Name = "TxtBxCustName";
            this.TxtBxCustName.Size = new System.Drawing.Size(250, 31);
            this.TxtBxCustName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "DateTo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "DateFrom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPTo
            // 
            this.DTPTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPTo.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold);
            this.DTPTo.Location = new System.Drawing.Point(135, 316);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(250, 31);
            this.DTPTo.TabIndex = 10;
            this.DTPTo.ValueChanged += new System.EventHandler(this.DTPTo_ValueChanged);
            // 
            // DTPFrom
            // 
            this.DTPFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPFrom.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold);
            this.DTPFrom.Location = new System.Drawing.Point(135, 258);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(250, 31);
            this.DTPFrom.TabIndex = 9;
            this.DTPFrom.ValueChanged += new System.EventHandler(this.DTPFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "CustId";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "RentId";
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
            this.Gn2BtnDelete.Location = new System.Drawing.Point(22, 525);
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
            this.Gn2BtnEdit.Location = new System.Drawing.Point(253, 474);
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
            this.Gn2BtnAdd.Location = new System.Drawing.Point(22, 474);
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
            this.Gn2BtnClear.Location = new System.Drawing.Point(253, 525);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnClear.TabIndex = 4;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // TxtBxCharge
            // 
            this.TxtBxCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCharge.Location = new System.Drawing.Point(135, 374);
            this.TxtBxCharge.Name = "TxtBxCharge";
            this.TxtBxCharge.Size = new System.Drawing.Size(250, 31);
            this.TxtBxCharge.TabIndex = 11;
            // 
            // TxtBxRentId
            // 
            this.TxtBxRentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxRentId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxRentId.Location = new System.Drawing.Point(135, 29);
            this.TxtBxRentId.Name = "TxtBxRentId";
            this.TxtBxRentId.Size = new System.Drawing.Size(250, 31);
            this.TxtBxRentId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Charge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbRentId
            // 
            this.LbRentId.AutoSize = true;
            this.LbRentId.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRentId.Location = new System.Drawing.Point(21, 87);
            this.LbRentId.Name = "LbRentId";
            this.LbRentId.Size = new System.Drawing.Size(79, 24);
            this.LbRentId.TabIndex = 8;
            this.LbRentId.Text = "RegNo.";
            this.LbRentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.Lavender;
            this.LbHeading.Location = new System.Drawing.Point(452, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(75, 24);
            this.LbHeading.TabIndex = 6;
            this.LbHeading.Text = "RENTS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRents";
            this.Text = "Car Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRents_FormClosing);
            this.Load += new System.EventHandler(this.FormRents_Load);
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRents)).EndInit();
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVRents;
        private System.Windows.Forms.Panel Pnl1;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDelete;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnEdit;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAdd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private System.Windows.Forms.TextBox TxtBxCharge;
        private System.Windows.Forms.TextBox TxtBxRentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbRentId;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBxCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBxRegNo;
        private System.Windows.Forms.ComboBox CmbBxCustId;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnCharge;
    }
}