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
    public partial class ClientForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager currencyManager;        //reference to CurrencyManager
        private CurrencyManager cmCountry;              //reference to Country table currency manager


        public ClientForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();                             //call the method BindControls for working with the data in the table

            pnlAddClient.Left = 120;                    //coordinates for the Add panel
            pnlAddClient.Top = 20;

            pnlUpdClient.Left = 120;                    //coordinates for the Update panel
            pnlUpdClient.Top = 20;
        }

        //method binds the data from the Client table to labels and txt boxes
        public void BindControls()
        {
            txtCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");

            lstClient.DataSource = DM.dsBookBrokers;
            lstClient.DisplayMember = "Client.LastName";
            lstClient.ValueMember = "Client.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];

            txtCity.Enabled = false;
            txtClientID.Enabled = false;
            txtCountry.Enabled = false;
            txtCreditStatus.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;

            //Combobox values for Add and Upd Panels
            cboAddCreditStatus.Items.AddRange(new string[] { "Valid", "Invalid" });
            cboUpdCreditStatus.Items.AddRange(new string[] { "Valid", "Invalid" });


            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
        }

        //makes Country name displaying by linking to the Country table
        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            DataRow CountryRow = DM.dtClient.Rows[currencyManager.Position];
            if (txtClientID.Text == "")
            {
                txtCountry.Text = "";
            }

            else
            {
                int aCountryID = Convert.ToInt32(CountryRow["CountryID"]);
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountry.Text = drCountry["CountryName"].ToString();
            }
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

        //delete book from the table
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];

            //check if Client has orders
            DataRow[] ClientRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);
            if (ClientRow.Length != 0)
            {
                MessageBox.Show("You may only delete Clients who has no orders", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this Client?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                }
            }
        }

        //calls the Add panel by clicking btn
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            btnDeleteClient.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateClient.Enabled = false;
            pnlAddClient.Show();
            LoadCountriesToAdd();
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

        //close the add panel, return to the Client form
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            lstClient.Visible = true;
            btnDeleteClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateClient.Enabled = true;
        }

        //add new client to the table
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newClientRow = DM.dtClient.NewRow();

            if (txtAddLastName.Text == "")
            {
                MessageBox.Show("You must type in a Client's Last Name", "Error");
            }

            else if (txtAddFirstName.Text == "")
            {
                MessageBox.Show("You must type in a Client's First Name", "Error");
            }

            else if (txtAddStreetAddress.Text == "")
            {
                MessageBox.Show("You must type in a Client's Street Address", "Error");
            }

            else if (txtAddSuburb.Text == "")
            {
                MessageBox.Show("You must type in a Client's Suburb Name", "Error");
            }

            else if (txtAddCity.Text == "")
            {
                MessageBox.Show("You must type in a Client's City Name", "Error");
            }

            else if (isValidEmail(txtAddEmail.Text) == false)
            {
                MessageBox.Show("You must type an Email in correct format", "Error");
            }

            else if(isLetterContains(txtAddLastName.Text) == false)
            {
                MessageBox.Show("Client's Last Name can contain only letters", "Error");
            }

            else if(isLetterContains(txtAddFirstName.Text) == false)
            {
                MessageBox.Show("Client's First Name can contain only letters", "Error");
            }

            else if (cboAddCreditStatus.Text == "")
            {
                MessageBox.Show("Choose Client's Credit Status Please", "Error");
            }

            else
            {
                newClientRow["City"] = txtAddCity.Text;
                newClientRow["Email"] = txtAddEmail.Text;
                newClientRow["FirstName"] = txtAddFirstName.Text;
                newClientRow["LastName"] = txtAddLastName.Text;
                newClientRow["StreetAddress"] = txtAddStreetAddress.Text;
                newClientRow["Suburb"] = txtAddSuburb.Text;
                newClientRow["CreditStatus"] = cboAddCreditStatus.Text;
                newClientRow["CountryID"] = cboAddCountryID.Text;

                DM.dtClient.Rows.Add(newClientRow);
                MessageBox.Show("Client added successfully", "Success");
                DM.UpdateClient();
            }
        }

        //calls the Update panel by clicking btn
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            btnDeleteClient.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddClient.Enabled = false;


            //Getting current data from form
            DataRow ClientRow = DM.dtClient.Rows[currencyManager.Position];
            txtUpdCity.Text = txtCity.Text;
            txtUpdEmail.Text = txtEmail.Text;
            txtUpdFirstName.Text = txtFirstName.Text;
            txtUpdLastName.Text = txtLastName.Text;
            txtUpdStreetAddress.Text = txtStreetAddress.Text;
            txtUpdSuburb.Text = txtSuburb.Text;
            cboUpdCountryID.Text = Convert.ToString(ClientRow["CountryID"]);
            cboUpdCountryName.Text = txtCountry.Text;
            cboUpdCreditStatus.Text = txtCreditStatus.Text;

            pnlUpdClient.Show();
            LoadCountriesToUpd();
        }

        //links the data in countries table to the Upd panel
        private void LoadCountriesToUpd()
        {
            cboUpdCountryName.DataSource = DM.dsBookBrokers;
            cboUpdCountryName.DisplayMember = "Country.CountryName";
            cboUpdCountryName.ValueMember = "Country.CountryName";
            cboUpdCountryID.DataSource = DM.dsBookBrokers;
            cboUpdCountryID.DisplayMember = "Country.CountryID";
            cboUpdCountryID.ValueMember = "Country.CountryID";

        }

        //close the Update panel, return to the Client form
        private void btnUpdCancel_Click(object sender, EventArgs e)
        {
            pnlUpdClient.Hide();
            lstClient.Visible = true;
            btnDeleteClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddClient.Enabled = true;
        }

        //Update Client in the table
        private void btnUpdSave_Click(object sender, EventArgs e)
        {
            DataRow updClientRow = DM.dtClient.Rows[currencyManager.Position];

            if (txtUpdLastName.Text == "")
            {
                MessageBox.Show("You must type in a Client's Last Name", "Error");
            }

            else if (txtUpdFirstName.Text == "")
            {
                MessageBox.Show("You must type in a Client's First Name", "Error");
            }

            else if (txtUpdStreetAddress.Text == "")
            {
                MessageBox.Show("You must type in a Client's Street Address", "Error");
            }

            else if (txtUpdSuburb.Text == "")
            {
                MessageBox.Show("You must type in a Client's Suburb Name", "Error");
            }

            else if (txtUpdCity.Text == "")
            {
                MessageBox.Show("You must type in a Client's City Name", "Error");
            }

            else if (isValidEmail(txtUpdEmail.Text) == false)
            {
                MessageBox.Show("You must type an Email in correct format", "Error");
            }

            else if (isLetterContains(txtUpdLastName.Text) == false)
            {
                MessageBox.Show("Client's Last Name can contain only letters", "Error");
            }

            else if (isLetterContains(txtUpdFirstName.Text) == false)
            {
                MessageBox.Show("Client's First Name can contain only letters", "Error");
            }

            else
            {
                updClientRow["City"] = txtUpdCity.Text;
                updClientRow["Email"] = txtUpdEmail.Text;
                updClientRow["FirstName"] = txtUpdFirstName.Text;
                updClientRow["LastName"] = txtUpdLastName.Text;
                updClientRow["StreetAddress"] = txtUpdStreetAddress.Text;
                updClientRow["Suburb"] = txtUpdSuburb.Text;
                updClientRow["CreditStatus"] = cboUpdCreditStatus.Text;
                updClientRow["CountryID"] = cboUpdCountryID.Text;

                currencyManager.EndCurrentEdit();
                MessageBox.Show("Client was updated successfully", "Success");
                DM.UpdateClient();
            }
        }

        //check whether string contains only Letters
        static bool isLetterContains(string input)
        {
            int countSymb = 0;
            int countLet = 0;
            foreach (char c in input)
            { countSymb++;
                if (Char.IsLetter(c))
                    countLet++;
            }
            
            if (countLet == countSymb)
                return true;
            return false;
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
    }
}
