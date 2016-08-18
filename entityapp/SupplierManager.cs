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
    public partial class SupplierManager : Form
    {
        public SupplierManager()
        {
            InitializeComponent();
        }

        private void SupplierManager_Load(object sender, EventArgs e)
        {
            refeshGridView();
        }

        void refeshGridView()
        {
            gvProSup.DataSource = null;

            // linq kungfu spagheti 
            var dataForGidView = from s in TravelExpertEntity.travelExpert.Suppliers                                 
                                 select new { s.SupplierId, s.SupName };
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
                List<Supplier> gvList = TravelExpertEntity.travelExpert.Suppliers.ToList<Supplier>();
                TravelExpertEntity.travelExpert.Suppliers.Remove(gvList[selectedRow]);
                //TravelExpertEntity.travelExpert.SaveChanges();
                TravelExpertEntity.saveToDatabase();                            
            }
            refeshGridView();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Supplier s;
            int selectedRow = getSelectedRow();
            if (selectedRow != -1)
            {
                List<Supplier> gvList = TravelExpertEntity.travelExpert.Suppliers.ToList<Supplier>();
                s = gvList[selectedRow];
                GetTextInputDlg dlg = new GetTextInputDlg("Supplier Name");
                DialogResult re = dlg.ShowDialog();
                if (re == DialogResult.OK) 
                {
                    string input = dlg.getInput();
                    if (!isDuplicate(input))
                    {
                        s.SupName = input;
                        TravelExpertEntity.saveToDatabase();
                        refeshGridView();
                    }

                }
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetTextInputDlg dlg = new GetTextInputDlg("Supplier Name");
            DialogResult re = dlg.ShowDialog();
            if (re == DialogResult.OK)
            {
                string input = dlg.getInput();
                if (!isDuplicate(input))
                {
                    Supplier s = new Supplier
                    {
                        SupplierId = genSupId(),
                        SupName = input
                    };

                    TravelExpertEntity.travelExpert.Suppliers.Add(s);
                    //TravelExpertEntity.travelExpert.SaveChanges();
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
            var search = (from s in TravelExpertEntity.travelExpert.Suppliers
                             where s.SupName == str
                             select s);
            return search.Any();
        }

        // workaround for the supplierId because it is not generated automatically by SQL 
        int genSupId()
        {
            
            // get the max id in Supplier
            int id = (from s in TravelExpertEntity.travelExpert.Suppliers
                      orderby s.SupplierId descending
                      select s.SupplierId).First();
            return id + 1;
        }
    }
}
