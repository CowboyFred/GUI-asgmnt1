using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BookBrokersStore
{
    public partial class VendorForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager currencyManager;        //reference to CurrencyManager
        private CurrencyManager cmCountry;              //reference to Country table currency manager

        public VendorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();                             //call the method BindControls for working with the data in the table

            pnlAddVendor.Left = 120;                    //coordinates for the Add panel
            pnlAddVendor.Top = 20;

            pnlUpdVendor.Left = 120;                    //coordinates for the Update panel
            pnlUpdVendor.Top = 20;
        }

        //method binds the data in the Vendor table to labels and txt boxes
        public void BindControls()
        {
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtPostBox.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            lstVendor.DataSource = DM.dsBookBrokers;
            lstVendor.DisplayMember = "Vendor.VendorName";
            lstVendor.ValueMember = "Vendor.VendorName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            txtCountry.Enabled = false;
            txtEmail.Enabled = false;
            txtPostBox.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;

            //update panel
            txtUpdVendorID.Enabled = false;
            txtUpdCountry.Enabled = false;

            txtUpdVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtUpdEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtUpdPostNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtUpdVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");

            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];

        }

        //makes country name displaying by linking to the Country table
        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            DataRow CountryRow = DM.dtVendor.Rows[currencyManager.Position];
            if (txtVendorID.Text == "")
            {
                txtCountry.Text = "";
            }

            else
            {
                int aCountryID = Convert.ToInt32(CountryRow["CountryID"]);           
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountry.Text = drCountry["CountryName"].ToString();
                txtUpdCountry.Text = txtCountry.Text;
            }
        }

        //links the data in countries table to the Add panel
        private void LoadCountriesToAdd()
        {
            cboAddCountryName.DataSource = DM.dsBookBrokers;
            cboAddCountryName.DisplayMember = "Country.CountryName";
            cboAddCountryName.ValueMember = "Country.CountryName";
            cboAddCountryID.DataSource = DM.dsBookBrokers;
            cboAddCountryID.DisplayMember = "Country.CountryID";
            cboAddCountryID.ValueMember = "Country.CountryID";

        }

        //move cursor on previous position by clicking on btn
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //move cursor on next position by clicking on btn
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //return to main menu by clicking btn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //calls the Add panel by clicking btn
        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            btnDeleteVendor.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateVendor.Enabled = false;
            pnlAddVendor.Show();
            LoadCountriesToAdd();
        }

        //save new vendor in the table
        private void btnSaveVendor_Click(object sender, EventArgs e)
        {
            DataRow newVendorRow = DM.dtVendor.NewRow();

            if (txtAddVendorName.Text == "")
            {
                MessageBox.Show("You must type in a Vendor name", "Error");
            }

            else if (txtAddPostNumber.Text == "")
            {
                MessageBox.Show("You must type in a Post Box Number", "Error");
            }

            else if (isValidEmail(txtAddEmail.Text) == false)
            {
                MessageBox.Show("You must type an email in correct format", "Error");
            }

            else
            {
                newVendorRow["VendorName"] = txtAddVendorName.Text;
                newVendorRow["PostBoxNumber"] = txtAddPostNumber.Text;
                newVendorRow["Email"] = txtAddEmail.Text;
                newVendorRow["CountryID"] = cboAddCountryID.Text;
                DM.dtVendor.Rows.Add(newVendorRow);
                MessageBox.Show("Vendor added successfully", "Success");
                DM.UpdateVendor();
            }
        }

        //close the add panel, return to the Vendor form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendor.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVendor.Enabled = true;
        }

        //check whether email was written correctly
        public bool isValidEmail(string email)
        {
            //regular expression pattern for valid email
            //addresses, allows for the following domains:
            //com,edu,info,gov,int,mil,net,org,biz,name,museum,coop,aero,pro,tv
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
    (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
            //Regular expression object
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }
            //return the value to the calling method
            return valid;
        }

        //delete vendor from the table
        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            DataRow deleteVendorRow = DM.dtVendor.Rows[currencyManager.Position];

            //check if vendor has books
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete Vendors who do not have books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this Vendor?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVendorRow.Delete();
                    DM.UpdateVendor();
                }
            }
        }

        //call the Update panel, fill form with the existing data
        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            btnDeleteVendor.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddVendor.Enabled = false;
            pnlUpdVendor.Show();


        }

        //close the Update panel, return to the form
        private void btnCancelUpd_Click(object sender, EventArgs e)
        {
            pnlUpdVendor.Hide();
            lstVendor.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddVendor.Enabled = true;
        }

        //updating table with the new data
        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            DataRow updVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            if (txtUpdVendorName.Text == "")
            {
                MessageBox.Show("You must type in a Vendor name", "Error");
            }

            else if (txtUpdPostNumber.Text == "")
            {
                MessageBox.Show("You must type in a Post Box Number", "Error");
            }

            else if (isValidEmail(txtUpdEmail.Text) == false)
            {
                MessageBox.Show("You must type an email in correct format", "Error");
            }

            else
            {
                updVendorRow["VendorName"] = txtUpdVendorName.Text;
                updVendorRow["PostBoxNumber"] = txtUpdPostNumber.Text;
                updVendorRow["Email"] = txtUpdEmail.Text;
                
                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();
                MessageBox.Show("Vendor updated successfully", "Success");
            }
        }


    }
}