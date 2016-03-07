namespace ctlAddressLib
{
    partial class ctlAddress
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Records = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LstDetails = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbosearch = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtSuburb = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Records)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Records
            // 
            this.dgv_Records.AllowUserToAddRows = false;
            this.dgv_Records.AllowUserToDeleteRows = false;
            this.dgv_Records.AllowUserToResizeColumns = false;
            this.dgv_Records.AllowUserToResizeRows = false;
            this.dgv_Records.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Records.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Address,
            this.Suburb,
            this.City,
            this.Phone,
            this.Country});
            this.dgv_Records.Location = new System.Drawing.Point(48, 301);
            this.dgv_Records.MultiSelect = false;
            this.dgv_Records.Name = "dgv_Records";
            this.dgv_Records.ReadOnly = true;
            this.dgv_Records.RowHeadersVisible = false;
            this.dgv_Records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Records.Size = new System.Drawing.Size(601, 124);
            this.dgv_Records.TabIndex = 68;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Suburb
            // 
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(56, 308);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(599, 126);
            this.label19.TabIndex = 67;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(435, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Maroon;
            this.btnEdit.Location = new System.Drawing.Point(315, 445);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 31);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(191, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 31);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(64, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 31);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.LstDetails);
            this.grpSearch.Controls.Add(this.label16);
            this.grpSearch.Controls.Add(this.cbosearch);
            this.grpSearch.Controls.Add(this.label18);
            this.grpSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.Maroon;
            this.grpSearch.Location = new System.Drawing.Point(360, 18);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(309, 277);
            this.grpSearch.TabIndex = 61;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(194, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 31);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LstDetails
            // 
            this.LstDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LstDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstDetails.ItemHeight = 19;
            this.LstDetails.Location = new System.Drawing.Point(105, 64);
            this.LstDetails.Name = "LstDetails";
            this.LstDetails.Size = new System.Drawing.Size(184, 194);
            this.LstDetails.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(112, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 200);
            this.label16.TabIndex = 39;
            // 
            // cbosearch
            // 
            this.cbosearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbosearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbosearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbosearch.DropDownWidth = 80;
            this.cbosearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbosearch.Location = new System.Drawing.Point(6, 23);
            this.cbosearch.Name = "cbosearch";
            this.cbosearch.Size = new System.Drawing.Size(160, 27);
            this.cbosearch.TabIndex = 16;
            this.cbosearch.Text = "Search";
            this.cbosearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbosearch_MouseClick);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 26);
            this.label18.TabIndex = 15;
            // 
            // grpDetail
            // 
            this.grpDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDetail.Controls.Add(this.lblCountry);
            this.grpDetail.Controls.Add(this.lblCity);
            this.grpDetail.Controls.Add(this.lblSuburb);
            this.grpDetail.Controls.Add(this.lblPhone);
            this.grpDetail.Controls.Add(this.lblAddress);
            this.grpDetail.Controls.Add(this.lblName);
            this.grpDetail.Controls.Add(this.cboCountry);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.TxtAdd);
            this.grpDetail.Controls.Add(this.TxtName);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.TxtCity);
            this.grpDetail.Controls.Add(this.TxtSuburb);
            this.grpDetail.Controls.Add(this.TxtPhone);
            this.grpDetail.Controls.Add(this.label7);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetail.ForeColor = System.Drawing.Color.Maroon;
            this.grpDetail.Location = new System.Drawing.Point(37, 18);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(317, 277);
            this.grpDetail.TabIndex = 60;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Enter Details";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(7, 241);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(73, 23);
            this.lblCountry.TabIndex = 41;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 169);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 23);
            this.lblCity.TabIndex = 40;
            this.lblCity.Text = "City";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(7, 135);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(66, 23);
            this.lblSuburb.TabIndex = 39;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 203);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 23);
            this.lblPhone.TabIndex = 38;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 64);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 23);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 23);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name";
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.DropDownWidth = 80;
            this.cboCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCountry.Location = new System.Drawing.Point(127, 236);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(160, 27);
            this.cboCountry.TabIndex = 35;
            this.cboCountry.Text = "Select - Country";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 34;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAdd.Location = new System.Drawing.Point(127, 62);
            this.TxtAdd.MaxLength = 30;
            this.TxtAdd.Multiline = true;
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(160, 67);
            this.TxtAdd.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtName.Location = new System.Drawing.Point(127, 28);
            this.TxtName.MaxLength = 15;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(160, 27);
            this.TxtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(135, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 63);
            this.label3.TabIndex = 15;
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCity.Location = new System.Drawing.Point(127, 169);
            this.TxtCity.MaxLength = 10;
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(160, 27);
            this.TxtCity.TabIndex = 4;
            // 
            // TxtSuburb
            // 
            this.TxtSuburb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSuburb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSuburb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSuburb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSuburb.Location = new System.Drawing.Point(127, 135);
            this.TxtSuburb.MaxLength = 15;
            this.TxtSuburb.Name = "TxtSuburb";
            this.TxtSuburb.Size = new System.Drawing.Size(160, 27);
            this.TxtSuburb.TabIndex = 3;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPhone.Location = new System.Drawing.Point(127, 203);
            this.TxtPhone.MaxLength = 10;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(160, 27);
            this.TxtPhone.TabIndex = 5;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(135, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 29);
            this.label7.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(134, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(135, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(135, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(560, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 31);
            this.btnExit.TabIndex = 69;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ctlAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgv_Records);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDetail);
            this.Name = "ctlAddress";
            this.Size = new System.Drawing.Size(707, 490);
            this.Load += new System.EventHandler(this.ctlAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Records)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Records;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox LstDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbosearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtSuburb;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExit;
    }
}
