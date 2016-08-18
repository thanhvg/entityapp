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
* Manage Supplier table 
*/
namespace entityapp
{
    public partial class ProductSupplier : Form
    {
        public ProductSupplier()
        {
            InitializeComponent();
        }

        private void ProductSupplier_Load(object sender, EventArgs e)
        {
            refeshGridView();
        }

        void refeshGridView()
        {
            gvProSup.DataSource = null;

            // linq kungfu spagheti 
            var dataForGidView = from ps in TravelExpertEntity.travelExpert.Product_Suppliers
                                 join p in TravelExpertEntity.travelExpert.Products on ps.ProductId equals p.ProductId
                                 join s in TravelExpertEntity.travelExpert.Suppliers
                                 on ps.SupplierId equals s.SupplierId
                                 select new { ps.ProductSupplierId, ps.ProductId, p.ProdName, ps.SupplierId, s.SupName };
            gvProSup.DataSource = dataForGidView.ToList();

            // 
        }

        private int getSelectedRow()
        {
            // get the select row index
            int selectedRowCount, selectedRow = -1;
            selectedRowCount = gvProSup.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
                selectedRow = gvProSup.SelectedRows[0].Index;
            return selectedRow;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow();
            if (selectedRow != -1)
            {
                // remove from entity 
                List<Products_Suppliers> gvList = TravelExpertEntity.travelExpert.Product_Suppliers.ToList<Products_Suppliers>();
                TravelExpertEntity.travelExpert.Product_Suppliers.Remove(gvList[selectedRow]);
                TravelExpertEntity.saveToDatabase();                            
            }
            refeshGridView();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Products_Suppliers ps;
            int selectedRow = getSelectedRow();
            if (selectedRow != -1)
            {
                // remove from entity 
                List<Products_Suppliers> gvList = TravelExpertEntity.travelExpert.Product_Suppliers.ToList<Products_Suppliers>();
                ps = gvList[selectedRow];
                new ChangeProductSupplier(ps);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddProductSupplier().ShowDialog();

            refeshGridView();
        }
    }
}
