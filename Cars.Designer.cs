namespace CarRentalMS
{
    partial class FormCars
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
            this.Gn2BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.CmbBxModel = new System.Windows.Forms.ComboBox();
            this.DGVCars = new System.Windows.Forms.DataGridView();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Gn2BtnImage = new Guna.UI2.WinForms.Guna2Button();
            this.PicBxCar = new System.Windows.Forms.PictureBox();
            this.CmbBxAvlb = new System.Windows.Forms.ComboBox();
            this.LbGender = new System.Windows.Forms.Label();
            this.Gn2BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.TxtBxModel = new System.Windows.Forms.TextBox();
            this.TxtBxBrand = new System.Windows.Forms.TextBox();
            this.TxtBxRegNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbCustId = new System.Windows.Forms.Label();
            this.LbCars = new System.Windows.Forms.Label();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCars)).BeginInit();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl2.Controls.Add(this.Gn2BtnRefresh);
            this.Pnl2.Controls.Add(this.CmbBxModel);
            this.Pnl2.Controls.Add(this.DGVCars);
            this.Pnl2.Location = new System.Drawing.Point(424, 50);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(540, 580);
            this.Pnl2.TabIndex = 3;
            // 
            // Gn2BtnRefresh
            // 
            this.Gn2BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gn2BtnRefresh.Animated = true;
            this.Gn2BtnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnRefresh.BorderThickness = 4;
            this.Gn2BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnRefresh.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnRefresh.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnRefresh.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnRefresh.Location = new System.Drawing.Point(410, 10);
            this.Gn2BtnRefresh.Name = "Gn2BtnRefresh";
            this.Gn2BtnRefresh.Size = new System.Drawing.Size(120, 35);
            this.Gn2BtnRefresh.TabIndex = 17;
            this.Gn2BtnRefresh.Text = "Refresh";
            this.Gn2BtnRefresh.Click += new System.EventHandler(this.Gn2BtnRefresh_Click);
            // 
            // CmbBxModel
            // 
            this.CmbBxModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxModel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbBxModel.FormattingEnabled = true;
            this.CmbBxModel.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBxModel.Location = new System.Drawing.Point(10, 10);
            this.CmbBxModel.Name = "CmbBxModel";
            this.CmbBxModel.Size = new System.Drawing.Size(300, 33);
            this.CmbBxModel.TabIndex = 4;
            this.CmbBxModel.Text = "Select Model";
            this.CmbBxModel.SelectedIndexChanged += new System.EventHandler(this.CmbBxModel_SelectedIndexChanged);
            // 
            // DGVCars
            // 
            this.DGVCars.AllowUserToAddRows = false;
            this.DGVCars.AllowUserToDeleteRows = false;
            this.DGVCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVCars.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGVCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCars.ColumnHeadersHeight = 34;
            this.DGVCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCars.EnableHeadersVisualStyles = false;
            this.DGVCars.Location = new System.Drawing.Point(10, 55);
            this.DGVCars.Name = "DGVCars";
            this.DGVCars.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVCars.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCars.RowTemplate.Height = 28;
            this.DGVCars.Size = new System.Drawing.Size(520, 510);
            this.DGVCars.TabIndex = 0;
            this.DGVCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCars_CellClick);
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pnl1.Controls.Add(this.Gn2BtnImage);
            this.Pnl1.Controls.Add(this.PicBxCar);
            this.Pnl1.Controls.Add(this.CmbBxAvlb);
            this.Pnl1.Controls.Add(this.LbGender);
            this.Pnl1.Controls.Add(this.Gn2BtnDelete);
            this.Pnl1.Controls.Add(this.Gn2BtnEdit);
            this.Pnl1.Controls.Add(this.Gn2BtnAdd);
            this.Pnl1.Controls.Add(this.Gn2BtnClear);
            this.Pnl1.Controls.Add(this.TxtBxPrice);
            this.Pnl1.Controls.Add(this.TxtBxModel);
            this.Pnl1.Controls.Add(this.TxtBxBrand);
            this.Pnl1.Controls.Add(this.TxtBxRegNo);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.label3);
            this.Pnl1.Controls.Add(this.LbCustId);
            this.Pnl1.Location = new System.Drawing.Point(14, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(400, 580);
            this.Pnl1.TabIndex = 2;
            // 
            // Gn2BtnImage
            // 
            this.Gn2BtnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnImage.Animated = true;
            this.Gn2BtnImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnImage.BorderThickness = 4;
            this.Gn2BtnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnImage.FillColor = System.Drawing.Color.Lavender;
            this.Gn2BtnImage.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.Gn2BtnImage.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.Gn2BtnImage.Location = new System.Drawing.Point(20, 500);
            this.Gn2BtnImage.Name = "Gn2BtnImage";
            this.Gn2BtnImage.Size = new System.Drawing.Size(150, 40);
            this.Gn2BtnImage.TabIndex = 10;
            this.Gn2BtnImage.Text = "Car Image";
            this.Gn2BtnImage.Click += new System.EventHandler(this.Gn2BtnImage_Click);
            // 
            // PicBxCar
            // 
            this.PicBxCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PicBxCar.BackColor = System.Drawing.Color.DarkGray;
            this.PicBxCar.Location = new System.Drawing.Point(20, 340);
            this.PicBxCar.Name = "PicBxCar";
            this.PicBxCar.Size = new System.Drawing.Size(150, 150);
            this.PicBxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxCar.TabIndex = 21;
            this.PicBxCar.TabStop = false;
            // 
            // CmbBxAvlb
            // 
            this.CmbBxAvlb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxAvlb.FormattingEnabled = true;
            this.CmbBxAvlb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBxAvlb.Location = new System.Drawing.Point(135, 267);
            this.CmbBxAvlb.Name = "CmbBxAvlb";
            this.CmbBxAvlb.Size = new System.Drawing.Size(250, 33);
            this.CmbBxAvlb.TabIndex = 9;
            // 
            // LbGender
            // 
            this.LbGender.AutoSize = true;
            this.LbGender.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGender.Location = new System.Drawing.Point(16, 150);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(68, 24);
            this.LbGender.TabIndex = 20;
            this.LbGender.Text = "Model";
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
            this.Gn2BtnDelete.Location = new System.Drawing.Point(251, 442);
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
            this.Gn2BtnEdit.Location = new System.Drawing.Point(251, 391);
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
            this.Gn2BtnAdd.Location = new System.Drawing.Point(251, 340);
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
            this.Gn2BtnClear.Location = new System.Drawing.Point(251, 493);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(120, 45);
            this.Gn2BtnClear.TabIndex = 4;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrice.Location = new System.Drawing.Point(135, 206);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(250, 31);
            this.TxtBxPrice.TabIndex = 8;
            // 
            // TxtBxModel
            // 
            this.TxtBxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxModel.Location = new System.Drawing.Point(135, 147);
            this.TxtBxModel.Name = "TxtBxModel";
            this.TxtBxModel.Size = new System.Drawing.Size(250, 31);
            this.TxtBxModel.TabIndex = 7;
            // 
            // TxtBxBrand
            // 
            this.TxtBxBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxBrand.Location = new System.Drawing.Point(135, 88);
            this.TxtBxBrand.Name = "TxtBxBrand";
            this.TxtBxBrand.Size = new System.Drawing.Size(250, 31);
            this.TxtBxBrand.TabIndex = 6;
            // 
            // TxtBxRegNo
            // 
            this.TxtBxRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxRegNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxRegNo.Location = new System.Drawing.Point(135, 29);
            this.TxtBxRegNo.Name = "TxtBxRegNo";
            this.TxtBxRegNo.Size = new System.Drawing.Size(250, 31);
            this.TxtBxRegNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Available";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brand";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbCustId
            // 
            this.LbCustId.AutoSize = true;
            this.LbCustId.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCustId.Location = new System.Drawing.Point(16, 32);
            this.LbCustId.Name = "LbCustId";
            this.LbCustId.Size = new System.Drawing.Size(79, 24);
            this.LbCustId.TabIndex = 8;
            this.LbCustId.Text = "RegNo.";
            this.LbCustId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbCars
            // 
            this.LbCars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbCars.AutoSize = true;
            this.LbCars.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold);
            this.LbCars.ForeColor = System.Drawing.Color.Lavender;
            this.LbCars.Location = new System.Drawing.Point(458, 10);
            this.LbCars.Name = "LbCars";
            this.LbCars.Size = new System.Drawing.Size(62, 24);
            this.LbCars.TabIndex = 4;
            this.LbCars.Text = "CARS";
            this.LbCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "Image File";
            this.Ofd1.Filter = "Image Files ( *.png, *.jpg,  *.jpeg) | *.png; *.jpg; *.jpeg;";
            this.Ofd1.Title = "Select Car Image";
            // 
            // FormCars
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
            this.Name = "FormCars";
            this.Text = "Car Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCars_FormClosing);
            this.Load += new System.EventHandler(this.FormCars_Load);
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCars)).EndInit();
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVCars;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.ComboBox CmbBxAvlb;
        private System.Windows.Forms.Label LbGender;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDelete;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnEdit;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAdd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.TextBox TxtBxModel;
        private System.Windows.Forms.TextBox TxtBxBrand;
        private System.Windows.Forms.TextBox TxtBxRegNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbCustId;
        private System.Windows.Forms.Label LbCars;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnRefresh;
        private System.Windows.Forms.ComboBox CmbBxModel;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnImage;
        private System.Windows.Forms.PictureBox PicBxCar;
        private System.Windows.Forms.OpenFileDialog Ofd1;
    }
}