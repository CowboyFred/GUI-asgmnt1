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
    public partial class AddBookForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager cmBookInfo;             //reference to Book Info currency manager
        private CurrencyManager cmClientOrder;          //reference to Client Order currency manager
        private CurrencyManager cmBook;                 //reference to Book currency manager
        private CurrencyManager cmClient;               //reference to Client currency manager

        private CurrencyManager cmDt;

        private DataTable dtStoreBook = new DataTable();

        public AddBookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];
           
            txtClientFirstName.Enabled = false;
            txtClientLastName.Enabled = false;
            txtTitle.Enabled = false;

            //IDK why Rows.Visible for dgv doesn't work, so we just go hard way
            cmDt = (CurrencyManager)this.BindingContext[dtStoreBook];

            clearBooks2();
            BindControls();
            //clearBooks(); DOESNT WORK                        
        }

        //Binding data for data grid views
        public void BindControls()
        {
            dgvClient.DataSource = DM.dsBookBrokers;
            dgvClient.DataMember = "ClientOrder";

            dgvBook.DataSource = dtStoreBook;
            dgvBook.Columns[6].Visible = false;

            dgvOrderBook.DataSource = DM.dsBookBrokers;
            dgvOrderBook.DataMember = "ClientOrder.ClientOrder_Book";
        }

        //CLose form, return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Should clear ordered books from dgvBook, BUT IT DOESNT WORK AND IDK WHY, Columns.Visible WORKS BUT ROWS.VISIBLE DOES NOT!!!!
        //I just decided to leave it, to show that it could be made more effective and fast, without creating a new table,
        //just changing visibility, but maybe you'll find a mistake, because I can't. I've just checked literally everything. 
        
        private void clearBooks()
        {
            for (int i = 0; i < dgvBook.Rows.Count - 1; i++)
            {
                if (dgvBook.Rows[i].Cells[6].Value.ToString() == "")
                {
                    dgvBook.Rows[i].Visible = true;
                }
                else
                {
                    dgvBook.Rows[i].Visible = false;
                }
            }
        }

        //clearing table through creating new one and deleting rows
        private void clearBooks2()
        {
            dtStoreBook = DM.dsBookBrokers.Tables["Book"].Copy();
            for (int i = 0; i < dtStoreBook.Rows.Count; i++)
            {
                if (dtStoreBook.Rows[i]["ClientOrderID"].ToString() !=  "")
                {
                    dtStoreBook.Rows[i].Delete();
                }
            }
        }

        //makes Clent Name displaying by linking to the Vendor table
        private void dgvClient_SelectionChanged(object sender, EventArgs e)
        {
            int aClientID = Convert.ToInt32(DM.dtClientOrder.Rows[cmClientOrder.Position]["ClientID"]);
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];
            txtClientLastName.Text = drClient["LastName"].ToString();
            txtClientFirstName.Text = drClient["FirstName"].ToString();
        }

        //makes Book Title displaying by linking to the Vendor table
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {            
            int aBookInfoID = Convert.ToInt32(dgvBook.CurrentRow.Cells[4].Value);
            cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
            DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
            txtTitle.Text = drBookInfo["Title"].ToString();
        }

        //Add book to order
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //check status
            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                int aBookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value);
                cmBook.Position = DM.BookView.Find(aBookID);
                DataRow BookRow = DM.dtBook.Rows[cmBook.Position];

                BookRow["ClientOrderID"] = Convert.ToString(DM.dtClientOrder.Rows[cmClientOrder.Position]["ClientOrderID"]);
                cmBook.EndCurrentEdit();
                MessageBox.Show("Book added successfully", "Success");
                DM.UpdateBook();
                //renewing datagridview with unordered books
                clearBooks2();
                dgvBook.DataSource = null;
                dgvBook.DataSource = dtStoreBook;
            }

            else
            {
                MessageBox.Show("Books can only be added to current orders", "Error");
            }
        }


        //remove book from order
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            //check status
            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                if (MessageBox.Show("Are you sure want to remove this Book from order?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    int aBookID = Convert.ToInt32(dgvOrderBook.CurrentRow.Cells[0].Value);
                    cmBook.Position = DM.BookView.Find(aBookID);
                    DataRow BookRow = DM.dtBook.Rows[cmBook.Position];

                    BookRow["ClientOrderID"] = DBNull.Value;
                    cmBook.EndCurrentEdit();
                    MessageBox.Show("Book removed successfully", "Success");
                    DM.UpdateBook();
                    //renewing datagridview with unordered books
                    clearBooks2();
                    dgvBook.DataSource = null;
                    dgvBook.DataSource = dtStoreBook;
                }
            }

            else
            {
                MessageBox.Show("Books can only be removed from current orders", "Error");
            }
        }
    }
}
