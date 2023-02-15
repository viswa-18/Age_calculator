using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_calculator
{
    public partial class frmAgecalculator : Form
    {
        public frmAgecalculator()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            try
            {
                if (isValid())
                {
                    int birth_date = Convert.ToInt32(txtboxdate.Text);
                    int birth_month = Convert.ToInt32(txtboxmonth.Text);
                    int birth_year = Convert.ToInt32(txtboxyear.Text);
                    DateTime current = DateTime.Today;
                    var currentDate = current.ToString("dd");
                    int current_date = Convert.ToInt32(currentDate);
                    int current_month = current.Month;
                    int current_year = current.Year;
                    int calculated_date, calculated_month;
                    if (current_date > birth_date)
                    {
                        current_date = current_date + month[birth_month - 1];
                        current_month = current_month - 1;
                    }
                    if (birth_month > current_month)
                    {
                        current_year = current_year - 1;
                        current_month = current_month + 12;
                    }
                    calculated_date = current_date - birth_date;
                    calculated_month = current_month - birth_month;
                    int calculated_year = current_year - birth_year;
                    string age = "You are " + calculated_year + " years " + calculated_month + " months " + calculated_date + " days old";

                    txtboxage.Text = age;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception");
            }
        }
            public bool isValid()
            {
            return isPresent(txtboxdate, "Enter your birthdate") &&
                   isInt(txtboxdate, "Enter your birthdate") &&
                   isPresent(txtboxmonth, "Enter your birthmonth") &&
                   isInt(txtboxmonth, "Enter your birthmonth") &&
                   isPresent(txtboxyear, "Enter your birthyear") &&
                   isInt(txtboxyear, "Enter your birthyear");
            }
            public bool isPresent(TextBox txt,string s)
            {
            if(txt.Text == "")
            {
                MessageBox.Show(s + " is a required field. ", "Entry Error");
                txt.Focus();
                return false;
            }
            return true;
            }
            public bool isInt(TextBox txt,string s)
        {
            int number = 0;
            if(Int32.TryParse(txt.Text, out number)){
                return true;
            }
            else
            {
                MessageBox.Show(s + " must be an integer ", "Entry Error");
                txt.Focus();
                return false;
            }
        }
        
    }
}
