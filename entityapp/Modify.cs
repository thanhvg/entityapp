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
* Modify package
*/
namespace entityapp
{
    public partial class Modify : Form
    {
        // package reference
        Package package;        

        // constructor, get package reference
        public Modify(Package package)
        {
            this.package = package;
            InitializeComponent();
        }

        // return the packageID
        public int getId()
        {
            return package.PackageId;
        }

        // on loading polulating the data with package reference
        private void Modify_Load(object sender, EventArgs e)
        {
            txtName.Text = package.PkgName;
            if (package.PkgStartDate != null)            
                dtpStartDate.Value = package.PkgStartDate.Value; // must use value because of nullable type
            if (package.PkgEndDate != null)           
                dtpEndDate.Value = package.PkgEndDate.Value;
            txtDesc.Text = package.PkgDesc;
            txtBasePrice.Text = package.PkgBasePrice.ToString("f2");
            txtCommission.Text = package.PkgAgencyCommission.Value.ToString("f2");
            refreshGridView();

        }

        // refresh and diplay the grid control
        private void refreshGridView()
        {
            gvProSup.DataSource = null;
           
            // linq kungfu spagheti 
            var dataForGidView = from ps in package.Products_Suppliers
                                 join p in TravelExpertEntity.travelExpert.Products on ps.ProductId equals p.ProductId
                                 join s in TravelExpertEntity.travelExpert.Suppliers
                                 on ps.SupplierId equals s.SupplierId
                                 select new { ps.ProductSupplierId, ps.ProductId, p.ProdName, ps.SupplierId, s.SupName };
            gvProSup.DataSource = dataForGidView.ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int selectedRow = getSelectedRow();
            if (selectedRow !=  -1)
            {
                // remove from entity 
                List<Products_Suppliers> gvList = package.Products_Suppliers.ToList<Products_Suppliers>();
                package.Products_Suppliers.Remove(gvList[selectedRow]);
                        
            }
            else
                MessageBox.Show("Please select the row you want to delete", "Please");
            refreshGridView();
        }

        // get the select row index
        private int getSelectedRow()
        {
            // get the select row index
            int selectedRowCount, selectedRow = -1;
            selectedRowCount = gvProSup.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            selectedRow = gvProSup.SelectedRows[0].Index;
            return selectedRow;
        }      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddProduct(package).ShowDialog();
            refreshGridView();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // valiating the input
            if (IsValid()) // if ok save 
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


        // validating input, true if ok
        bool IsValid ()
        {
            return Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsDecimal(txtBasePrice) &&
                Validator.IsPositive(txtBasePrice) &&                
                Validator.IsDecimal(txtCommission) &&
                Validator.IsPositive(txtCommission) &&
                Validator.AreDatesOK(dtpStartDate, dtpEndDate) &&
                Validator.IsCommisionOK(txtBasePrice, txtCommission);                        

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
