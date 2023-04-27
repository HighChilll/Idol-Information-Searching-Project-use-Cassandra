namespace cassandra_demo
{
    partial class frmDemo
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
            this.dgvIdol = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.lblStageName = new System.Windows.Forms.Label();
            this.pnlSearchIdol = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdol)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.pnlSearchIdol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIdol
            // 
            this.dgvIdol.AllowUserToAddRows = false;
            this.dgvIdol.AllowUserToDeleteRows = false;
            this.dgvIdol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIdol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIdol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIdol.Location = new System.Drawing.Point(0, 153);
            this.dgvIdol.Name = "dgvIdol";
            this.dgvIdol.ReadOnly = true;
            this.dgvIdol.RowHeadersWidth = 51;
            this.dgvIdol.RowTemplate.Height = 24;
            this.dgvIdol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIdol.Size = new System.Drawing.Size(1182, 600);
            this.dgvIdol.TabIndex = 0;
            this.dgvIdol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdol_CellClick);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnDelete);
            this.pnlInput.Controls.Add(this.btnReset);
            this.pnlInput.Controls.Add(this.btnUpdate);
            this.pnlInput.Controls.Add(this.btnInsert);
            this.pnlInput.Controls.Add(this.txtInstagram);
            this.pnlInput.Controls.Add(this.lblInstagram);
            this.pnlInput.Controls.Add(this.chkFemale);
            this.pnlInput.Controls.Add(this.txtBirthPlace);
            this.pnlInput.Controls.Add(this.lblBirthPlace);
            this.pnlInput.Controls.Add(this.txtCountry);
            this.pnlInput.Controls.Add(this.lblCountry);
            this.pnlInput.Controls.Add(this.txtGroup);
            this.pnlInput.Controls.Add(this.lblGroup);
            this.pnlInput.Controls.Add(this.dtpDateOfBirth);
            this.pnlInput.Controls.Add(this.lblDateOfBirth);
            this.pnlInput.Controls.Add(this.txtFullName);
            this.pnlInput.Controls.Add(this.lblFullName);
            this.pnlInput.Controls.Add(this.txtStageName);
            this.pnlInput.Controls.Add(this.lblStageName);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(670, 153);
            this.pnlInput.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(501, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsert.Location = new System.Drawing.Point(420, 117);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInstagram
            // 
            this.txtInstagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstagram.Location = new System.Drawing.Point(396, 81);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(180, 30);
            this.txtInstagram.TabIndex = 13;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstagram.Location = new System.Drawing.Point(315, 85);
            this.lblInstagram.Margin = new System.Windows.Forms.Padding(3);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(75, 20);
            this.lblInstagram.TabIndex = 12;
            this.lblInstagram.Text = "Instagram";
            this.lblInstagram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFemale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFemale.Location = new System.Drawing.Point(311, 120);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(79, 24);
            this.chkFemale.TabIndex = 14;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthPlace.Location = new System.Drawing.Point(396, 45);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(180, 30);
            this.txtBirthPlace.TabIndex = 11;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthPlace.Location = new System.Drawing.Point(311, 49);
            this.lblBirthPlace.Margin = new System.Windows.Forms.Padding(3);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(79, 20);
            this.lblBirthPlace.TabIndex = 10;
            this.lblBirthPlace.Text = "Birth Place";
            this.lblBirthPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(396, 9);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(180, 30);
            this.txtCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(330, 13);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(3);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 20);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGroup
            // 
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroup.Location = new System.Drawing.Point(110, 117);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(180, 30);
            this.txtGroup.TabIndex = 7;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(54, 121);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(3);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(50, 20);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Group";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(110, 81);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(131, 30);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(10, 85);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(3);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(94, 20);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Location = new System.Drawing.Point(110, 45);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 30);
            this.txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(28, 49);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(3);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStageName
            // 
            this.txtStageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStageName.Location = new System.Drawing.Point(110, 9);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(180, 30);
            this.txtStageName.TabIndex = 1;
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStageName.Location = new System.Drawing.Point(13, 13);
            this.lblStageName.Margin = new System.Windows.Forms.Padding(3);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(91, 20);
            this.lblStageName.TabIndex = 0;
            this.lblStageName.Text = "Stage Name";
            this.lblStageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearchIdol
            // 
            this.pnlSearchIdol.Controls.Add(this.btnClear);
            this.pnlSearchIdol.Controls.Add(this.btnSearch);
            this.pnlSearchIdol.Controls.Add(this.txtSearch);
            this.pnlSearchIdol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchIdol.Location = new System.Drawing.Point(670, 0);
            this.pnlSearchIdol.Name = "pnlSearchIdol";
            this.pnlSearchIdol.Size = new System.Drawing.Size(512, 48);
            this.pnlSearchIdol.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.Location = new System.Drawing.Point(402, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.Location = new System.Drawing.Point(321, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(35, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Location = new System.Drawing.Point(582, 79);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.Location = new System.Drawing.Point(582, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pnlSearchIdol);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.dgvIdol);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassandra Demo";
            this.Load += new System.EventHandler(this.frmDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdol)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlSearchIdol.ResumeLayout(false);
            this.pnlSearchIdol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIdol;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Panel pnlSearchIdol;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
    }
}

