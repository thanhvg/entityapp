namespace entityapp
{
    partial class Main
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
            this.lblPackageProducts = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvProSup = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDB = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAndSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvProSup)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackageProducts
            // 
            this.lblPackageProducts.AutoSize = true;
            this.lblPackageProducts.Location = new System.Drawing.Point(34, 403);
            this.lblPackageProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPackageProducts.Name = "lblPackageProducts";
            this.lblPackageProducts.Size = new System.Drawing.Size(109, 13);
            this.lblPackageProducts.TabIndex = 57;
            this.lblPackageProducts.Text = "Products in Package:";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(563, 359);
            this.txtCommission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(133, 20);
            this.txtCommission.TabIndex = 55;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(375, 362);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(104, 13);
            this.lblCommission.TabIndex = 54;
            this.lblCommission.Text = "Agency Commission:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(155, 359);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(166, 20);
            this.txtBasePrice.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(541, 20);
            this.txtName.TabIndex = 45;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(38, 202);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 51;
            this.lblDesc.Text = "Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(38, 102);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(38, 13);
            this.lblPkgName.TabIndex = 44;
            this.lblPkgName.Text = "Name:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(155, 202);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(541, 149);
            this.txtDesc.TabIndex = 50;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(155, 132);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(541, 20);
            this.txtStartDate.TabIndex = 47;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(155, 167);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(541, 20);
            this.txtEndDate.TabIndex = 49;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(38, 171);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 48;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(38, 136);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 46;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(38, 362);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(61, 13);
            this.lblBasePrice.TabIndex = 52;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(155, 46);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(99, 21);
            this.cbID.TabIndex = 59;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID:";
            // 
            // gvProSup
            // 
            this.gvProSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProSup.Location = new System.Drawing.Point(155, 403);
            this.gvProSup.Name = "gvProSup";
            this.gvProSup.Size = new System.Drawing.Size(541, 124);
            this.gvProSup.TabIndex = 61;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(431, 561);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 23);
            this.btnModify.TabIndex = 62;
            this.btnModify.Text = "Modify Package";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(563, 561);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "New Package";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete Package";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.menuDB,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.personalizationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // personalizationToolStripMenuItem
            // 
            this.personalizationToolStripMenuItem.Name = "personalizationToolStripMenuItem";
            this.personalizationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personalizationToolStripMenuItem.Text = "Personalization";
            // 
            // menuDB
            // 
            this.menuDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.productAndSupplierToolStripMenuItem,
            this.manageProductToolStripMenuItem,
            this.manageSupplierToolStripMenuItem});
            this.menuDB.Name = "menuDB";
            this.menuDB.Size = new System.Drawing.Size(67, 20);
            this.menuDB.Text = "Database";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // productAndSupplierToolStripMenuItem
            // 
            this.productAndSupplierToolStripMenuItem.Name = "productAndSupplierToolStripMenuItem";
            this.productAndSupplierToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productAndSupplierToolStripMenuItem.Text = "Product and Supplier";
            this.productAndSupplierToolStripMenuItem.Click += new System.EventHandler(this.productAndSupplierToolStripMenuItem_Click);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // manageSupplierToolStripMenuItem
            // 
            this.manageSupplierToolStripMenuItem.Name = "manageSupplierToolStripMenuItem";
            this.manageSupplierToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.manageSupplierToolStripMenuItem.Text = "Manage Supplier";
            this.manageSupplierToolStripMenuItem.Click += new System.EventHandler(this.manageSupplierToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem
            // 
            this.needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem.Name = "needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem";
            this.needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
            this.needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem.Text = "Need Help with something specific in the application?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gvProSup);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPackageProducts);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBasePrice);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProSup)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPackageProducts;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvProSup;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem needHelpWithSomethingSpecificInTheApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAndSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSupplierToolStripMenuItem;
    }
}

