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
* Add new product_supplier
*/
namespace entityapp
{
    public partial class AddProduct : Form
    {
        // package reference to work on
        Package package;
        // default constructor, needs package object reference
        public AddProduct(Package package)
        {
            this.package = package;
            InitializeComponent();
        }

        // on loading popluae the product combobox
        private void AddProduct_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = getProductList();
            cmbProduct.DisplayMember = "ProdName";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.SelectedIndex = -1;
        }

        // get list of products 
        List<Product> getProductList()
        {
            //linq 
            return (from p in TravelExpertEntity.travelExpert.Products orderby p.ProdName
                    select p).ToList<Product>();
        }

        // get list of ProductSupplier
        List<Products_Suppliers> getProductSupplierList()
        {
            return (from ps in TravelExpertEntity.travelExpert.Product_Suppliers
                    orderby ps.ProductSupplierId
                    select ps).ToList();
        }
        

        // get list of names of suppliers who provide product id 
        List<Supplier> getSupplierName(int id)
        {
            return (from ps in TravelExpertEntity.travelExpert.Product_Suppliers
                    join p in TravelExpertEntity.travelExpert.Products on ps.ProductId equals p.ProductId
                    join s in TravelExpertEntity.travelExpert.Suppliers on ps.SupplierId equals s.SupplierId
                    where p.ProductId == id
                    select s).ToList();
        }


        Products_Suppliers ps = null;

        // return the produc_supplier object having product id and suppler id
        int getProdSupId(int prodId, int supId)
        {
            ps = (from ps in TravelExpertEntity.travelExpert.Product_Suppliers
                  where ps.SupplierId == supId && ps.ProductId == prodId
                  select ps).Single();
            return ps.ProductSupplierId;
        }

        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (package !=null)
            {
                package.Products_Suppliers.Add(ps);
                ps.Packages.Add(package); 
            }
            this.Close();
        }


        // when value change update
        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // get selected product id
            int id = Convert.ToInt32(cmbProduct.SelectedValue);
            cmbSupplier.DataSource = getSupplierName(id);
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.DisplayMember = "SupName";
            cmbSupplier.SelectedIndex = -1;
        }

        // when value change update
        private void cmbSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // get selected product id
            int prodId = Convert.ToInt32(cmbProduct.SelectedValue);
            // get supid
            int supId = Convert.ToInt32(cmbSupplier.SelectedValue);
            // get ps id
            int psId = getProdSupId(prodId, supId);
            // set textbox value
            txtPsId.Text = psId.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
