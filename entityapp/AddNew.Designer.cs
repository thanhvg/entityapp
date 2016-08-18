namespace entityapp
{
    partial class AddNew
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPackageProducts = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvProSup = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProSup)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(480, 86);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 101;
            this.dtpEndDate.Tag = "End date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(149, 86);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 100;
            this.dtpStartDate.Tag = "Start date";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(695, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPackageProducts
            // 
            this.lblPackageProducts.AutoSize = true;
            this.lblPackageProducts.Location = new System.Drawing.Point(28, 372);
            this.lblPackageProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPackageProducts.Name = "lblPackageProducts";
            this.lblPackageProducts.Size = new System.Drawing.Size(109, 13);
            this.lblPackageProducts.TabIndex = 96;
            this.lblPackageProducts.Text = "Products in Package:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(589, 581);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 97;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(557, 309);
            this.txtCommission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(133, 20);
            this.txtCommission.TabIndex = 95;
            this.txtCommission.Tag = "Commision price";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(369, 312);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(104, 13);
            this.lblCommission.TabIndex = 94;
            this.lblCommission.Text = "Agency Commission:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(149, 309);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(166, 20);
            this.txtBasePrice.TabIndex = 93;
            this.txtBasePrice.Tag = "Base price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 47);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(541, 20);
            this.txtName.TabIndex = 87;
            this.txtName.Tag = "Name";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(32, 152);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 91;
            this.lblDesc.Text = "Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(32, 52);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(38, 13);
            this.lblPkgName.TabIndex = 86;
            this.lblPkgName.Text = "Name:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(149, 152);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(541, 149);
            this.txtDesc.TabIndex = 90;
            this.txtDesc.Tag = "Description";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(384, 86);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 89;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(32, 86);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 88;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(32, 312);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(61, 13);
            this.lblBasePrice.TabIndex = 92;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProSup);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(136, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 203);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            // 
            // gvProSup
            // 
            this.gvProSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProSup.Location = new System.Drawing.Point(13, 29);
            this.gvProSup.Name = "gvProSup";
            this.gvProSup.ReadOnly = true;
            this.gvProSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProSup.Size = new System.Drawing.Size(541, 124);
            this.gvProSup.TabIndex = 78;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(129, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 104;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 625);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPackageProducts);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPackageProducts;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvProSup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}