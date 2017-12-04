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
    public partial class BookForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager currencyManager;        //reference to CurrencyManager
        private CurrencyManager cmVendor;              //reference to Vendorcurrency manager
        private CurrencyManager cmBookInfo;             //reference to Book Info currency manager

        public BookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();                             //call the method BindControls for working with the data in the table

            pnlAddBook.Left = 120;                    //coordinates for the Add panel
            pnlAddBook.Top = 20;

            pnlUpdBook.Left = 120;                    //coordinates for the Update panel
            pnlUpdBook.Top = 20;
        }

        //method binds the data from the Book table to labels and txt boxes
        public void BindControls()
        {
            txtBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            txtCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.ClientOrderID");
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");

            lstBook.DataSource = DM.dsBookBrokers;
            lstBook.DisplayMember = "Book.BookID";
            lstBook.ValueMember = "Book.BookID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];

            txtBookID.Enabled = false;
            txtClientID.Enabled = false;
            txtCost.Enabled = false;
            txtDatePublished.Enabled = false;
            txtPrice.Enabled = false;
            txtTitle.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;

            //Update panel
            cboUpdBookID.Enabled = false;
            cboUpdTitle.Enabled = false;
            cboUpdVendorID.Enabled = false;
            cboUpdVendorName.Enabled = false;

            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];

        }


        //makes Vendor Name displaying by linking to the Vendor table
        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (txtVendorID.Text == "")
            {
                txtVendorName.Text = "";
            }

            else
            {
                int aVendorID = Convert.ToInt32(txtVendorID.Text);            
                cmBookInfo.Position = DM.VendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[cmBookInfo.Position];
                txtVendorName.Text = drVendor["VendorName"].ToString();
            }
        }


        //makes book title displaying by linking to the Book Info table
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            DataRow BookRow = DM.dtBook.Rows[currencyManager.Position];
            if (txtBookID.Text == "")
            {
                txtTitle.Text = "";
            }

            else
            {
                int aBookID = Convert.ToInt32(BookRow["BookInfoID"]);           
                cmBookInfo.Position = DM.BookInfoView.Find(aBookID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();

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
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];

            //check if book was ordered
            if (txtClientID.Text != "")
            {
                MessageBox.Show("You may only delete Books which weren't ordered", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this Book?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookRow.Delete();
                    DM.UpdateBook();
                }
            }
        }

        //close the add panel, return to the Vendor form
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddBook.Hide();
            lstBook.Visible = true;
            btnDeleteBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateBook.Enabled = true;
        }

        //calls the Add panel by clicking btn
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lstBook.Visible = false;
            btnDeleteBook.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateBook.Enabled = false;
            pnlAddBook.Show();
            LoadVendorsToAdd();
            LoadBookInfoToAdd();
        }

        //links the data from Vendors table to the Add panel
        private void LoadVendorsToAdd()
        {
            cboAddVendorName.DataSource = DM.dsBookBrokers;
            cboAddVendorName.DisplayMember = "Vendor.VendorName";
            cboAddVendorName.ValueMember = "Vendor.VendorName";
            cboAddVendorID.DataSource = DM.dsBookBrokers;
            cboAddVendorID.DisplayMember = "Vendor.VendorID";
            cboAddVendorID.ValueMember = "Vendor.VendorID";

        }

        //links the data from BookInfo table to the Add panel
        private void LoadBookInfoToAdd()
        {
            cboAddTitle.DataSource = DM.dsBookBrokers;
            cboAddTitle.DisplayMember = "BookInfo.Title";
            cboAddTitle.ValueMember = "BookInfo.Title";
            cboAddBookID.DataSource = DM.dsBookBrokers;
            cboAddBookID.DisplayMember = "BookInfo.BookInfoID";
            cboAddBookID.ValueMember = "BookInfo.BookInfoID";

        }

        //add new book to the table
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newBookRow = DM.dtBook.NewRow();

            if (isNumber(txtAddCost.Text) == false)
            {
                MessageBox.Show("You must type in a Cost as a number", "Error");
            }

            else if (isNumber(txtAddPrice.Text) == false)
            {
                MessageBox.Show("You must type in a Price as a number", "Error");
            }

            else
            {
                newBookRow["Cost"] = txtAddCost.Text;
                newBookRow["Price"] = txtAddPrice.Text;
                newBookRow["BookInfoID"] = cboAddBookID.Text;
                newBookRow["VendorID"] = cboAddVendorID.Text;
                newBookRow["DatePublished"] = dtpAddDatePublished.Text;
                DM.dtBook.Rows.Add(newBookRow);
                MessageBox.Show("Book added successfully", "Success");
                DM.UpdateBook();
            }
        }


        //calls the Update panel by clicking btn
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            //check if book was ordered
            if (txtClientID.Text != "")
            {
                MessageBox.Show("You may only update Books which weren't ordered", "Error");
            }
            else
            {
                lstBook.Visible = false;
                btnDeleteBook.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnAddBook.Enabled = false;

                //Getting current data from form
                DataRow BookRow = DM.dtBook.Rows[currencyManager.Position];
                txtUpdPrice.Text = txtPrice.Text;
                txtUpdCost.Text = txtCost.Text;
                dtpUpdDatePublished.Text = txtDatePublished.Text;
                cboUpdBookID.Text = Convert.ToString(BookRow["BookInfoID"]);
                cboUpdTitle.Text = txtTitle.Text;
                cboUpdVendorID.Text = txtVendorID.Text;
                cboUpdVendorName.Text = txtVendorName.Text;

                pnlUpdBook.Show();
            }
        }

        //Update book in the table
        private void btnUpdSave_Click(object sender, EventArgs e)
        {
            DataRow updBookRow = DM.dtBook.Rows[currencyManager.Position];

            if (isNumber(txtUpdCost.Text) == false)
            {
                MessageBox.Show("You must type in a Cost as a number", "Error");
            }

            else if (isNumber(txtUpdPrice.Text) == false)
            {
                MessageBox.Show("You must type in a Price as a number", "Error");
            }

            else
            {
                updBookRow["Cost"] = txtUpdCost.Text;
                updBookRow["Price"] = txtUpdPrice.Text;
                updBookRow["DatePublished"] = dtpUpdDatePublished.Text;

                currencyManager.EndCurrentEdit();
                MessageBox.Show("Book updated successfully", "Success");
                DM.UpdateBook();
            }
        }

        //close the Update panel, return to the Vendor form
        private void btnUpdCancel_Click(object sender, EventArgs e)
        {
            pnlUpdBook.Hide();
            lstBook.Visible = true;
            btnDeleteBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddBook.Enabled = true;
        }




        //Check if number was inputed
        public bool isNumber(string num)
        {
            Regex rxNums = new Regex(@"[0-9]*\.[0-9]+|[0-9]+");
            if (rxNums.IsMatch(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
