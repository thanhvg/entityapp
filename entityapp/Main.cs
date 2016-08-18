using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityapp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearControls();
            RefreshPackageId();
        }

        // package display
        private void RefreshPackageId()
        {
            // populating combobox
            var productId = from Package in TravelExpertEntity.travelExpert.Packages
                            select new { Package.PackageId }; // a collection of anomynous class which have PackageId property
            var ids = productId.Select(x => (int)x.PackageId); // get only the value of the column            
            cbID.DataSource = new List<int>(ids);
            
        }

        private Package package;
        private List<Products_Suppliers> proSupList;
        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get package id
            int id = Convert.ToInt32(cbID.SelectedValue);

            // linq kung fu
            try
            {
                package = (from p in TravelExpertEntity.travelExpert.Packages
                           where p.PackageId == id
                           select p).Single();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            txtName.Text = package.PkgName;
            if (package.PkgStartDate == null)
                txtStartDate.Text = "";
            else
                txtStartDate.Text = package.PkgStartDate.Value.ToShortDateString(); // must use value because of nullable type

            if (package.PkgEndDate == null)
                txtEndDate.Text = "";
            else
                txtEndDate.Text = package.PkgEndDate.Value.ToShortDateString();
            txtDesc.Text = package.PkgDesc;
            txtBasePrice.Text = package.PkgBasePrice.ToString("f2");
            txtCommission.Text = package.PkgAgencyCommission.Value.ToString("f2");

            //get list of ProductSuppliers
            var proSupListLinq = from pa in package.Products_Suppliers
                             join ps in TravelExpertEntity.travelExpert.Product_Suppliers on pa.ProductSupplierId equals ps.ProductSupplierId
                             select pa;
            proSupList = proSupListLinq.ToList();

            // loading the list view
            var dataProSup = from pa in package.Products_Suppliers
                             join ps in TravelExpertEntity.travelExpert.Product_Suppliers on pa.ProductSupplierId equals ps.ProductSupplierId
                             join sp in TravelExpertEntity.travelExpert.Suppliers on ps.SupplierId equals sp.SupplierId
                             join pr in TravelExpertEntity.travelExpert.Products on ps.ProductId equals pr.ProductId
                             select new { ps.ProductSupplierId, pr.ProdName, sp.SupName };

            gvProSup.DataSource = dataProSup.ToList();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Delete this package", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // get package id
                int id = Convert.ToInt32(cbID.SelectedValue);
                // get the Package object
                Package package = (from p in TravelExpertEntity.travelExpert.Packages
                                   where p.PackageId == id
                                   select p).Single();

                //delete this package, because entity model will take care of related tables 
                TravelExpertEntity.travelExpert.Packages.Remove(package);
                TravelExpertEntity.travelExpert.SaveChanges();
                ClearControls();
                RefreshPackageId();

            }
        }

        // clears the form
        private void ClearControls() // Written by Jay Weber
        {
            txtName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtDesc.Text = "";
            txtBasePrice.Text = "";
            txtCommission.Text = "";
            gvProSup.DataSource = null;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Modify mod = new Modify(package);
            DialogResult result = mod.ShowDialog();
            ClearControls();
            TravelExpertEntity.refreshEntity();
            RefreshPackageId();
            if (result == DialogResult.OK)
            {
                TravelExpertEntity.saveToDatabase();
                int id = mod.getId();
                cbID.SelectedItem = id;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNew ad = new AddNew();
            DialogResult result = ad.ShowDialog();
            ClearControls();
            RefreshPackageId();

            if (result == DialogResult.OK)
            {
                TravelExpertEntity.saveToDatabase();
                int id = ad.getId();
                cbID.SelectedItem = id;                
            }

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TravelExpertEntity.refreshEntity();
            ClearControls();
            RefreshPackageId();

        }

        private void productAndSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductSupplier().ShowDialog();
            TravelExpertEntity.refreshEntity();
            ClearControls();
            RefreshPackageId();

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductManager().ShowDialog();
            TravelExpertEntity.refreshEntity();
            ClearControls();
            RefreshPackageId();

        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SupplierManager().ShowDialog();
            TravelExpertEntity.refreshEntity();
            ClearControls();
            RefreshPackageId();
        }
    }
}
