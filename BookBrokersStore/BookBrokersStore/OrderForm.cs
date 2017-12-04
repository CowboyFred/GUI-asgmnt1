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
    public partial class OrderForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm    
        private CurrencyManager currencyManager;        //reference to CurrencyManager
        private CurrencyManager cmClient;              //reference to Author table currency manager

        public OrderForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();                             //call the method BindControls for working with the data in the table

            pnlAddClientOrder.Left = 120;                    //coordinates for the Add panel
            pnlAddClientOrder.Top = 20;

            pnlUpdClientOrder.Left = 120;                    //coordinates for the Update panel
            pnlUpdClientOrder.Top = 20;
        }

        //method binds the data from the Client Info table to txt boxes
        public void BindControls()
        {
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");


            lstClientOrder.DataSource = DM.dsBookBrokers;
            lstClientOrder.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrder.ValueMember = "ClientOrder.ClientOrderID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];

            txtStatus.Enabled = false;
            txtClientOrderID.Enabled = false;
            txtClientOrderDate.Enabled = false;
            txtClientLastName.Enabled = false;
            txtClientID.Enabled = false;
            txtClientFirstName.Enabled = false;

            //Update panel
            txtUpdClientFirstName.Enabled = false;
            txtUpdClientID.Enabled = false;
            txtUpdClientLastName.Enabled = false;
            txtUpdClientOrderID.Enabled = false;
            txtUpdStatus.Enabled = false;

            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
        }
        
        //makes Client name displaying by linking to the Country table
        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            DataRow ClientRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if (txtClientID.Text == "")
            {
                txtClientFirstName.Text = "";
                txtClientLastName.Text = "";
            }

            else
            {
                int aClientID = Convert.ToInt32(ClientRow["ClientID"]);
                cmClient.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
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

        //Delete Client Order from table
        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];

            //check if there are books availible
            DataRow[] ClientOrderRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete a client order that has no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this Client Order?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientOrderRow.Delete();
                    DM.UpdateClientOrder();
                }
            }
        }

        //calls the Add panel by clicking btn
        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrder.Visible = false;
            btnDeleteClientOrder.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            pnlAddClientOrder.Show();
            LoadClientsToAdd();
        }
        //links the data from author table to the Add panel
        private void LoadClientsToAdd()
        {
            cboAddClientFirstName.DataSource = DM.dsBookBrokers;
            cboAddClientFirstName.DisplayMember = "Client.FirstName";
            cboAddClientFirstName.ValueMember = "Client.FirstName";
            cboAddClientLastName.DataSource = DM.dsBookBrokers;
            cboAddClientLastName.DisplayMember = "Client.LastName";
            cboAddClientLastName.ValueMember = "Client.LastName";
            cboAddClientID.DataSource = DM.dsBookBrokers;
            cboAddClientID.DisplayMember = "Client.ClientID";
            cboAddClientID.ValueMember = "Client.ClientID";
        }

        //close the add panel, return to the Book Info form
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Hide();
            lstClientOrder.Visible = true;
            btnDeleteClientOrder.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
        }

        //add new Book Info to the table
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();
       
            newClientOrderRow["ClientID"] = cboAddClientID.Text;
            newClientOrderRow["OrderDate"] = dtpClientOrderDate.Text;
            newClientOrderRow["Status"] = "Current";

            DM.dtClientOrder.Rows.Add(newClientOrderRow);
            MessageBox.Show("Client Order added successfully", "Success");
            DM.UpdateClientOrder();
        }

        //calls the Update panel by clicking btn
        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrder.Visible = false;
            btnDeleteClientOrder.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddClientOrder.Enabled = false;


            //Getting current data from form
            txtUpdClientFirstName.Text = txtClientFirstName.Text;
            txtUpdClientID.Text = txtClientID.Text;
            txtUpdClientLastName.Text = txtClientLastName.Text;
            txtUpdClientOrderID.Text = txtClientOrderID.Text;
            txtUpdStatus.Text = txtStatus.Text;
            dtpUpdClientOrderDate.Text = txtClientOrderDate.Text;

            pnlUpdClientOrder.Show();
        }

        //close the Update panel, return to the Book Info form
        private void btnUpdCancel_Click(object sender, EventArgs e)
        {
            pnlUpdClientOrder.Hide();
            lstClientOrder.Visible = true;
            btnDeleteClientOrder.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddClientOrder.Enabled = true;
        }

        //Update Book Info in the table
        private void btnUpdSave_Click(object sender, EventArgs e)
        {
            DataRow updClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            updClientOrderRow["OrderDate"] = dtpUpdClientOrderDate.Text;
            currencyManager.EndCurrentEdit();
            MessageBox.Show("Client Order was updated successfully", "Success");
            DM.UpdateClientOrder();
        }


        //Changing status from shipped to paid in the table by clicking btn
        private void btnPaid_Click(object sender, EventArgs e)
        {
            DataRow updClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];

            if (updClientOrderRow["Status"].ToString() == "Shipped")
            {
                updClientOrderRow["Status"] = "Paid";
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Client Order marked as Paid", "Success");
                DM.UpdateClientOrder();
            }
            else
            {
                MessageBox.Show("Only shipped client orders can be marked as paid", "Error");
            }
        }

        //Changing status from current to shipped in the table by clicking btn
        private void btnShipped_Click(object sender, EventArgs e)
        {
            DataRow updClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];

            if (updClientOrderRow["Status"].ToString() == "Current")
            {
                updClientOrderRow["Status"] = "Shipped";
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Client Order marked as Shipped", "Success");
                DM.UpdateClientOrder();
            }
            else
            {
                MessageBox.Show("Only current client orders can be marked as shipped", "Error");
            }
        }
    }
}
