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
* Modify product with supplier 
*/
namespace entityapp
{
    public partial class ChangeProductSupplier : Form
    {
        Products_Suppliers ps;
        public ChangeProductSupplier(Products_Suppliers ps)
        {
            this.ps = ps;
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

        private void ChangeProduct_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = getProductList();
            cmbProduct.DisplayMember = "ProdName";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.SelectedValue = ps.ProductId;

            cmbSupplier.DataSource = getSupplierList();
            cmbSupplier.DisplayMember = "SupName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.SelectedValue = ps.SupplierId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ps.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
            ps.SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
            TravelExpertEntity.saveToDatabase();
            this.Close();

        }
    }
}
