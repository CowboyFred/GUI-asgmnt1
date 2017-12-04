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
    public partial class InvoicesForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm   
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoicesForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        //Filter rows for shipped orders, make preview visible
        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Shipped'";
            string strSort = "ClientOrderID";
            invoicesForPrint = DM.dsBookBrokers.Tables["CLIENTORDER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();
        }

        //Binds data for printing
        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drClientOrder = invoicesForPrint[amountOfInvoicesPrinted];



            CurrencyManager cmClient;
            CurrencyManager cmClientOrder;
            CurrencyManager cmCountry;
            CurrencyManager cmBook;
            CurrencyManager cmBookInfo;
            double orderTotal = 0;

            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Country"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //get the Client record matching the ClientID from the clientorder record
            int aClientID = Convert.ToInt32(drClientOrder["ClientID"].ToString());
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];

            //get the Country record matching the CountryID from the client record
            int aCountryID = Convert.ToInt32(drClient["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Client ID: " + drClient["ClientID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString( drClient["FirstName"] + " " + drClient["LastName"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["City"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Client Order ID: " + drClientOrder["ClientOrderID"] + "    Date:" + 
                DateTime.Parse(drClientOrder["OrderDate"].ToString()).ToShortDateString(), headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;


            //make table with books in order
            DataRow[] drBooks = drClientOrder.GetChildRows(DM.dtClientOrder.ChildRelations["ClientOrder_Book"]);

            if (drBooks.Length == 0)
            {
                g.DrawString("This order has no books", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Books: ", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                foreach (DataRow drBooksOrder in drBooks)
                {
                    //get the book record matching the BookID from the clientorder record
                    int aBook = Convert.ToInt32(drBooksOrder["BookID"].ToString());
                    cmBook.Position = DM.BookView.Find(aBook);
                    DataRow drBook = DM.dtBook.Rows[cmBook.Position];

                    //get the book info record matching the Book record
                    int aBookInfo = Convert.ToInt32(drBook["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(aBookInfo);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                    orderTotal += Convert.ToDouble(drBook["Price"]);
                    g.DrawString(String.Format("{0,-10}", drBook["BookID"]), headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,10}{1,-10}", " ", drBookInfo["Title"]),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    //it shows me all prices in rubles, so instead :C, I had to implement :0.00 and add $ sign 
                    g.DrawString(String.Format("{0,100}{1:0.00}", "$", drBook["Price"]), headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }

                linesSoFarHeading++;
                //same situation with rubles
                g.DrawString(String.Format("{0, 95}{1:0.00}", "Total: $", orderTotal), headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));

            }

            orderTotal = 0;
            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
