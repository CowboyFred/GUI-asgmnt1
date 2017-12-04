using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokersStore
{
    public partial class BookInfoForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager currencyManager;        //reference to CurrencyManager
        private CurrencyManager cmAuthor;              //reference to Author table currency manager


        public BookInfoForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();                             //call the method BindControls for working with the data in the table

            pnlAddBookInfo.Left = 120;                    //coordinates for the Add panel
            pnlAddBookInfo.Top = 20;

            pnlUpdBookInfo.Left = 120;                    //coordinates for the Update panel
            pnlUpdBookInfo.Top = 20;
        }

        //method binds the data from the Boook Info table to txt boxes
        public void BindControls()
        {
            txtAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");
            txtTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");

            lstBookInfo.DataSource = DM.dsBookBrokers;
            lstBookInfo.DisplayMember = "BookInfo.Title";
            lstBookInfo.ValueMember = "BookInfo.Title";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];

            txtTitle.Enabled = false;
            txtNotes.Enabled = false;
            txtBookInfoID.Enabled = false;
            txtAuthorLastName.Enabled = false;
            txtAuthorID.Enabled = false;
            txtAuthorFirstName.Enabled = false;

            //Update panel
            txtUpdAuthorFirstName.Enabled = false;
            txtUpdAuthorID.Enabled = false;
            txtUpdAuthorLastName.Enabled = false;
            txtUpdBookInfoID.Enabled = false;

            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
        }

        //makes Author name displaying by linking to the Country table
        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
            DataRow AuthorRow = DM.dtBookInfo.Rows[currencyManager.Position];
            if (txtAuthorID.Text == "")
            {
                txtAuthorFirstName.Text = "";
                txtAuthorLastName.Text = "";
            }

            else
            {
                int anAuthorID = Convert.ToInt32(AuthorRow["AuthorID"]);
                cmAuthor.Position = DM.AuthorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtAuthorLastName.Text = drAuthor["LastName"].ToString();
                txtAuthorFirstName.Text = drAuthor["FirstName"].ToString();
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

        //Delete Book Info from table
        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {
            DataRow deleteBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];

            //check if there are books availible
            DataRow[] BookInfoRow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (BookInfoRow.Length != 0)
            {
                MessageBox.Show("You may only delete book info records that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this Book Info?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookInfoRow.Delete();
                    DM.UpdateBookInfo();
                }
            }
        }

        //calls the Add panel by clicking btn
        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = false;
            btnDeleteBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            pnlAddBookInfo.Show();
            LoadAuthorsToAdd();
        }

        //links the data from author table to the Add panel
        private void LoadAuthorsToAdd()
        {
            cboAddAuthorFirstName.DataSource = DM.dsBookBrokers;
            cboAddAuthorFirstName.DisplayMember = "Author.FirstName";
            cboAddAuthorFirstName.ValueMember = "Author.FirstName";
            cboAddAuthorLastName.DataSource = DM.dsBookBrokers;
            cboAddAuthorLastName.DisplayMember = "Author.LastName";
            cboAddAuthorLastName.ValueMember = "Author.LastName";
            cboAddAuthorID.DataSource = DM.dsBookBrokers;
            cboAddAuthorID.DisplayMember = "Author.AuthorID";
            cboAddAuthorID.ValueMember = "Author.AuthorID";
        }

        //close the add panel, return to the Book Info form
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Hide();
            lstBookInfo.Visible = true;
            btnDeleteBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
        }

        //add new Book Info to the table
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();

            if (txtAddTitle.Text == "")
            {
                MessageBox.Show("You must type in a Book Title", "Error");
            }

            else
            {
                newBookInfoRow["Title"] = txtAddTitle.Text;
                newBookInfoRow["Notes"] = txtAddNotes.Text;
                newBookInfoRow["AuthorID"] = cboAddAuthorID.Text;

                DM.dtBookInfo.Rows.Add(newBookInfoRow);
                MessageBox.Show("Book Info added successfully", "Success");
                DM.UpdateBookInfo();
            }
        }

        //calls the Update panel by clicking btn
        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = false;
            btnDeleteBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddBookInfo.Enabled = false;


            //Getting current data from form
            txtUpdAuthorFirstName.Text = txtAuthorFirstName.Text;
            txtUpdAuthorID.Text = txtAuthorID.Text;
            txtUpdAuthorLastName.Text = txtAuthorLastName.Text;
            txtUpdBookInfoID.Text = txtBookInfoID.Text;
            txtUpdNotes.Text = txtNotes.Text;
            txtUpdTitle.Text = txtTitle.Text;


            pnlUpdBookInfo.Show();
        }

        //close the Update panel, return to the Book Info form
        private void btnUpdCancel_Click(object sender, EventArgs e)
        {
            pnlUpdBookInfo.Hide();
            lstBookInfo.Visible = true;
            btnDeleteBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddBookInfo.Enabled = true;
        }

        //Update Book Info in the table
        private void btnUpdSave_Click(object sender, EventArgs e)
        {
            DataRow updBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];

            if (txtUpdTitle.Text == "")
            {
                MessageBox.Show("You must type in a Book Title", "Error");
            }

            else
            {
                updBookInfoRow["Title"] = txtUpdTitle.Text;
                updBookInfoRow["Notes"] = txtUpdNotes.Text;

                currencyManager.EndCurrentEdit();
                MessageBox.Show("Book Info was updated successfully", "Success");
                DM.UpdateBookInfo();
            }
        }
    }
}
