using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Thanh Vuong
* Add new package
*/
namespace entityapp
{
    public partial class AddNew : Form
    {
        // Package object
        Package package;

        // return the package id
        public int getId()
        {
            return package.PackageId;
        }

        // Constructor, generate new package ID 
        public AddNew()
        {
            package = new Package { PkgAgencyCommission = 0, PkgBasePrice = 1, PkgDesc = "", PkgName = "",  };
            TravelExpertEntity.travelExpert.Packages.Add(package);
            TravelExpertEntity.travelExpert.SaveChanges();
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            // show the new package id 
            txtId.Text = package.PackageId.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddProduct(package).ShowDialog();
            refreshGridView();
        }


        // display data on gridview control
        private void refreshGridView()
        {
            gvProSup.DataSource = null;
            // linq kungfu get the data from database  
            var dataForGidView = from ps in package.Products_Suppliers
                                 join p in TravelExpertEntity.travelExpert.Products on ps.ProductId equals p.ProductId
                                 join s in TravelExpertEntity.travelExpert.Suppliers
                                 on ps.SupplierId equals s.SupplierId
                                 select new { ps.ProductSupplierId, ps.ProductId, p.ProdName, ps.SupplierId, s.SupName };
            // convert data to display on gridview
            gvProSup.DataSource = dataForGidView.ToList();

        }

        // get the index of the selected row on gridview control
        private int getSelectedRow()
        {
            // get the select row index
            int selectedRowCount, selectedRow = -1;
            selectedRowCount = gvProSup.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
                selectedRow = gvProSup.SelectedRows[0].Index;
            return selectedRow;
        }

        // delete a product-supplier in gridview
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow();
            if (selectedRow != -1)
            {
                List<Products_Suppliers> gvList = package.Products_Suppliers.ToList<Products_Suppliers>();
                //TravelExpertEntity.travelExpert.Products_Suppliers.Remove(gvList[selectedRow]);
                package.Products_Suppliers.Remove(gvList[selectedRow]);
            }
            else
                MessageBox.Show("Please select the row you want to delete", "Please");
            refreshGridView();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // validates the inputs
            if (IsValid())
            {
                package.PkgName = txtName.Text;
                package.PkgDesc = txtDesc.Text;
                package.PkgStartDate = dtpStartDate.Value;
                package.PkgEndDate = dtpEndDate.Value;
                package.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                TravelExpertEntity.saveToDatabase();
                this.Close();
            }
            else
                this.DialogResult = DialogResult.None;
        }

        // validates the input
        bool IsValid()
        {
            return Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsDecimal(txtBasePrice) &&
                Validator.IsDecimal(txtCommission) &&

                Validator.AreDatesOK(dtpStartDate, dtpEndDate) &&
                Validator.IsCommisionOK(txtBasePrice, txtCommission);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Cancel this package", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TravelExpertEntity.travelExpert.Packages.Remove(package);
                TravelExpertEntity.travelExpert.SaveChanges();
                this.Close();
            }
               
        }
    }
}
