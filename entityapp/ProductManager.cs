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
* Manage Product table 
*/
namespace entityapp
{
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            refeshGridView();
        }

        void refeshGridView()
        {
            gvProSup.DataSource = null;

            // linq kungfu spagheti 
            var dataForGidView = from p in TravelExpertEntity.travelExpert.Products                                 
                                 select new { p.ProductId, p.ProdName };
            gvProSup.DataSource = dataForGidView.ToList();

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
                List<Product> gvList = TravelExpertEntity.travelExpert.Products.ToList<Product>();
                TravelExpertEntity.travelExpert.Products.Remove(gvList[selectedRow]);
                TravelExpertEntity.saveToDatabase();                            
            }
            refeshGridView();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Product p;
            int selectedRow = getSelectedRow();
            if (selectedRow != -1)
            {
                List<Product> gvList = TravelExpertEntity.travelExpert.Products.ToList<Product>();
                p = gvList[selectedRow];
                GetTextInputDlg dlg = new GetTextInputDlg("Product Name");
                DialogResult re = dlg.ShowDialog();
                if (re == DialogResult.OK) 
                {
                    string input = dlg.getInput();
                    if (!isDuplicate(input))
                    {
                        p.ProdName = input;
                        TravelExpertEntity.saveToDatabase();
                        refeshGridView();
                    }

                }
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetTextInputDlg dlg = new GetTextInputDlg("Product Name");
            DialogResult re = dlg.ShowDialog();
            if (re == DialogResult.OK)
            {
                string input = dlg.getInput();
                if (!isDuplicate(input))
                {
                    Product p = new Product
                    {
                        ProdName = input,
                    };
                    TravelExpertEntity.travelExpert.Products.Add(p);
                    TravelExpertEntity.saveToDatabase();
                    refeshGridView();
                }

            }

        }

        List<Product> getProductList()
        {
            //linq 
            return (from p in TravelExpertEntity.travelExpert.Products
                    select p).ToList();
        }

        bool isDuplicate(string str)
        {
            var search = (from p in TravelExpertEntity.travelExpert.Products
                             where p.ProdName == str
                             select p.ProdName);
            return search.Any();
        }
    }
}
