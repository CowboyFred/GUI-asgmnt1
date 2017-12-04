using System.Data.OleDb;             //add System.Data.OleDb Namespace for working with the database

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
    //create and fill variables with the data from the tables 
    public partial class DataModule : Form
    {
        public DataTable dtVendor;
        public DataTable dtClient;
        public DataTable dtClientOrder;
        public DataTable dtCountry;
        public DataTable dtBook;
        public DataTable dtBookInfo;
        public DataTable dtAuthor;

        public DataView VendorView;
        public DataView ClientView;
        public DataView ClientOrderView;
        public DataView CountryView;
        public DataView BookView;
        public DataView BookInfoView;
        public DataView AuthorView;

        public DataModule()
        {
            InitializeComponent();
            dsBookBrokers.EnforceConstraints = false;

            daAuthor.Fill(dsBookBrokers);
            daBook.Fill(dsBookBrokers);
            daBookInfo.Fill(dsBookBrokers);
            daClient.Fill(dsBookBrokers);
            daClientOrder.Fill(dsBookBrokers);
            daCountry.Fill(dsBookBrokers);
            daVendor.Fill(dsBookBrokers);

            dtAuthor = dsBookBrokers.Tables["Author"];
            dtBook = dsBookBrokers.Tables["Book"];
            dtBookInfo = dsBookBrokers.Tables["BookInfo"];
            dtClient = dsBookBrokers.Tables["Client"];
            dtClientOrder = dsBookBrokers.Tables["ClientOrder"];
            dtCountry = dsBookBrokers.Tables["Country"];
            dtVendor = dsBookBrokers.Tables["Vendor"];

            dsBookBrokers.EnforceConstraints = true;

            VendorView = new DataView(dtVendor);
            VendorView.Sort = "VendorID";
            ClientView = new DataView(dtClient);
            ClientView.Sort = "ClientID";
            ClientOrderView = new DataView(dtClientOrder);
            ClientOrderView.Sort = "ClientOrderID";
            CountryView = new DataView(dtCountry);
            CountryView.Sort = "CountryID";
            BookView = new DataView(dtBook);
            BookView.Sort = "BookID";
            BookInfoView = new DataView(dtBookInfo);
            BookInfoView.Sort = "BookInfoID";
            AuthorView = new DataView(dtAuthor);
            AuthorView.Sort = "AuthorID";
        }


        public void minusOneSolver (string ID, OleDbRowUpdatedEventArgs e)
        {
            //include a variable and a command to retrieve the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //retrive the identity value and store it in the ID column
                newID = (int)idCMD.ExecuteScalar();
                e.Row[ID] = newID;
            }
        }

        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }


        //solve -1 problem
        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            minusOneSolver("VendorID", e);
        }

        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }

        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
           minusOneSolver("BookID", e);
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            minusOneSolver("ClientID", e);
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }

        private void daBookInfo_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            minusOneSolver("BookInfoID", e);
        }

        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);
        }

        private void daClientOrder_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            minusOneSolver("ClientOrderID", e);
        }     
    }
}
