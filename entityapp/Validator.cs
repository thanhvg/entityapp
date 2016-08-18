/*
* Gia Thanh Vuong, June 2016
* Validator class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace entityapp
{
    public static class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsPositive(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number) && number >=0 )            {
                
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a positive value.", Title);
                textBox.Focus();
                return false;
            }
        }


        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(Control control)
        {
            int number = 0;
            if (Int32.TryParse(control.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(control.Tag + " must be an integer.", Title);
                control.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsComboSelect (ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show(cmb.Tag + " must be selected");
                cmb.Focus();
                return false;
            }
            return true;
        }

        public static bool IsHavingIllegalChar(TextBox textBox, char ch)
        {
            if (textBox.Text.Contains(ch))
            {
                MessageBox.Show(textBox.Tag + " must not have illegal character: " + ch, Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool AreDatesOK(DateTimePicker start, DateTimePicker end)
        {
            if (start.Value.CompareTo(end.Value) > 0)
            {
                MessageBox.Show("Start date should be later than end date");
                start.Focus();
                return false;
            }

            return true;
        }
        
        public static bool IsCommisionOK (TextBox tp, TextBox tc)
        {
            if (Convert.ToDecimal(tp.Text) <= Convert.ToDecimal(tc.Text) )
            {
                MessageBox.Show("Commission should be less than base price");
                tc.Focus();
                return false;
            }
            return true;

        }
    }
}
