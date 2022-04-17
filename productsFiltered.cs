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
    public partial class productsFilteredForm : Form
    {
        public productsFilteredForm()
        {
            InitializeComponent();
        }

        private void productsFilteredForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);

            //Opens with  an empty selection
            catComboBox.SelectedValue = -1;

        }

 
        private void catComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            string userSelection;

            userSelection = catComboBox.SelectedValue.ToString();

            bindingSource1.DataMember = "Products";
            bindingSource1.Filter = "CategoryID = '" + userSelection + "'";
            bindingSource1.Sort = "ProductName";

            prodListBox.DataSource = bindingSource1;
            prodListBox.DisplayMember = "ProductName";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
