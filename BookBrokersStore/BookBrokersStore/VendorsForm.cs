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
    public partial class VendorsForm : Form
    {
        private DataModule DM;                          //reference to DataModule
        private MainForm frmMenu;                       //reference to MainForm   
        private int amountOfVendorsPrinted, pagesAmountExpected;
        private DataRow[] vendorsForPrint;

        public VendorsForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        //Select vendors, make preview visible
        private void btnPrintVendors_Click(object sender, EventArgs e)
        {
            amountOfVendorsPrinted = 0;
            string strFilter = "VendorID > 0";
            string strSort = "VendorID";
            vendorsForPrint = DM.dsBookBrokers.Tables["VENDOR"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = vendorsForPrint.Length;
            prvVendors.Show();
        }

        //Binds data for printing
        private void printVendors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVendor = vendorsForPrint[amountOfVendorsPrinted];

            CurrencyManager cmVendor;
            CurrencyManager cmCountry;
            CurrencyManager cmBook;
            CurrencyManager cmBookInfo;
            CurrencyManager cmAuthor;

            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Country"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Vendor"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Author"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //get the Country record matching the CountryID from the Vendor record
            int aCountryID = Convert.ToInt32(drVendor["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Vendor ID: " + drVendor["VendorID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString(drVendor["VendorName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("PO BOX " + drVendor["PostBoxNumber"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drVendor["Email"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;


            //make table with books vendor has
            DataRow[] drBooks = drVendor.GetChildRows(DM.dtVendor.ChildRelations["Vendor_Book"]);

            if (drBooks.Length == 0)
            {
                g.DrawString("This vendor has no available books", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Books: ", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                foreach (DataRow drBooksVendor in drBooks)
                {
                    //get the book record matching the BookID from the Vendor record
                    int aBook = Convert.ToInt32(drBooksVendor["BookID"].ToString());
                    cmBook.Position = DM.BookView.Find(aBook);
                    DataRow drBook = DM.dtBook.Rows[cmBook.Position];

                    //get the book info record matching the Book record
                    int aBookInfo = Convert.ToInt32(drBook["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(aBookInfo);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                    //get the author record matching the Book record
                    int anAuthor = Convert.ToInt32(drBookInfo["AuthorID"].ToString());
                    cmAuthor.Position = DM.AuthorView.Find(anAuthor);
                    DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];

                    //it shows me all prices in rubles, so instead :C, I had to implement :0.00 and add $ sign 
                    g.DrawString(String.Format("{0,0}", drBook["BookID"]), 
                        headingFont, brush, leftMargin + headingLeftMargin,topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,10}{1,-10}", " " , drBookInfo["Title"]),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,70}{1,-10:0.00}", "$", drBook["Cost"])
                        , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,85}{1,-10:0.00}","$", drBook["Price"])
                        , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,110:dd/MM/yyyy}",drBook["DatePublished"])
                        , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(String.Format("{0,140} {1,15}",drAuthor["FirstName"], drAuthor["LastName"])
                        , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
            }

            amountOfVendorsPrinted++;

            if (!(amountOfVendorsPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }



        //Return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
