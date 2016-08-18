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
* Public function to get a text input
* will nag user if text empty
*/
namespace entityapp
{
    public partial class GetTextInputDlg : Form
    {
        string hint =  "";
        string input;
        public string getInput()
        {
            return input;
        }
        
        public GetTextInputDlg(string hint)
        {
            this.hint = hint;
            InitializeComponent();
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                input = txtInput.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter value", "Please");
                this.DialogResult = DialogResult.None;
                txtInput.Focus();
            }


        }

        private void GetTextInputDlg_Load(object sender, EventArgs e)
        {
            lblHint.Text = hint;
        }
    }
}
