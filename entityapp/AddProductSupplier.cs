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
* Add product with supplier to a package
*/

namespace entityapp
{
    
    public partial class AddProductSupplier : Form
    {
        public AddProductSupplier()
        {
            InitializeComponent();
        }
        List<Product> getProductList()
        {
            //linq 
            return (from p in TravelExpertEntity.travelExpert.Products
                    select p).ToList();
        }

        List<Supplier> getSupplierList()
        {
            return (from s in TravelExpertEntity.travelExpert.Suppliers
                    select s).ToList();
        }       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!isDuplicate())
            {
                Products_Suppliers ps = new Products_Suppliers
                {
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue)
                };
                TravelExpertEntity.travelExpert.Product_Suppliers.Add(ps);
                TravelExpertEntity.saveToDatabase();

                this.Close(); 
            } else
            {
                MessageBox.Show("Duplicate product supplier", "Duplicate");
            }
        }
        bool isDuplicate()
        {
            
            int proId = Convert.ToInt32(cmbProduct.SelectedValue);
            int supId = Convert.ToInt32(cmbSupplier.SelectedValue);
            var ps = (from p in TravelExpertEntity.travelExpert.Product_Suppliers
                                     where p.ProductId == proId && p.SupplierId == supId
                                     select p);
            return ps.Any();
        }

        private void AddProductToPackage_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = getProductList();
            cmbProduct.DisplayMember = "ProdName";
            cmbProduct.ValueMember = "ProductId";

            cmbSupplier.DataSource = getSupplierList();
            cmbSupplier.DisplayMember = "SupName";
            cmbSupplier.ValueMember = "SupplierId";

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
