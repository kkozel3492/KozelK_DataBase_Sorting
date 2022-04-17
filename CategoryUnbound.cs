using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3343_KozelK_Lab04
{
    public partial class CategoryUnbound : Form
    {
        public CategoryUnbound()
        {
            InitializeComponent();
        }

        private void CategoryUnbound_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);

            //Create a table adaptor for products
            northwndDataSetTableAdapters.ProductsTableAdapter productTableAdaptor =
                new northwndDataSetTableAdapters.ProductsTableAdapter();

            productTableAdaptor.Fill(northwndDataSet.Products);

            //Opens with an empty selection
            catComboBox.SelectedValue = -1;

        }

        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Declare variables
            int catID;
            DataRow catDataRow;
            DataRow[] prodDataRows;

            catID = Convert.ToInt16(catComboBox.SelectedValue);

            catDataRow = this.northwndDataSet.Categories.FindByCategoryID(catID);

            prodDataRows = catDataRow.GetChildRows("FK_Products_Categories");

            prodListBox.Items.Clear();

            foreach(DataRow prodDataRow in prodDataRows)
            {
                prodListBox.Items.Add(prodDataRow["ProductName"]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
