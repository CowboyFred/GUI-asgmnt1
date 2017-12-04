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
    public partial class MainForm : Form
    {
        private DataModule DM;              //The reference to the form that holds the data components
        private BookForm frmBook;           //The reference to the Book form
        private BookInfoForm frmBookInfo;   //The reference to the Book info form
        private ClientForm frmClient;       //The reference to the Client form  
        private AddBookForm frmAddBook;     //The reference to the Add Book form
        private InvoicesForm frmInvoices;   //The reference to the Invoices form
        private OrderForm frmOrder;         //The reference to the Order form
        private VendorForm frmVendor;       //The reference to the Vendor maintenance form
        private VendorsForm frmVendors;     //The reference to the Vendors form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();      //Create the data module and load the dataset
        }
        
        //open vendor maintenance from
        private void btnVendor_Click(object sender, EventArgs e)        //opens the Vendor maitenance form by clicking on btn
        {
            if (frmVendor == null)                                      //(here and below) check whether the same form is already opened
            {
                frmVendor = new VendorForm(DM, this);                   //(here and below) frm variable taking the value of the corresponding form
            }
            frmVendor.ShowDialog();                                     //(here and below) open the form
        }

        private void btnExit_Click(object sender, EventArgs e)          //exit the program by clicking in exit btn
        {
            Close();
        }

        //open book maintenance form
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (frmBook == null)                                     
            {
                frmBook = new BookForm(DM, this);                   
            }
            frmBook.ShowDialog();                                     
        }

        //open Client maintenance form
        private void btnClient_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }
            frmClient.ShowDialog();
        }

        //open Book Info maintenance form
        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            if (frmBookInfo == null)
            {
                frmBookInfo = new BookInfoForm(DM, this);
            }
            frmBookInfo.ShowDialog();
        }

        //open Client Order maintenance form
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (frmOrder == null)
            {
                frmOrder = new OrderForm(DM, this);
            }
            frmOrder.ShowDialog();
        }

        //open Add Book form
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (frmAddBook == null)
            {
                frmAddBook = new AddBookForm(DM, this);
            }
            frmAddBook.ShowDialog();
        }

        //open Invoices form
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoices == null)
            {
                frmInvoices = new InvoicesForm(DM, this);
            }
            frmInvoices.ShowDialog();
        }

        //Open vendors form
        private void btnVendors_Click(object sender, EventArgs e)
        {
            if (frmVendors == null)
            {
                frmVendors = new VendorsForm(DM, this);
            }
            frmVendors.ShowDialog();
        }
    }
}



