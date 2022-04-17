/*Kevin Kozel
 * 04/12/2022
 * Lab 04
 * BCIS 3343
 * 001049648
 * 
 * This application will import create a main form where the user can choose from 4 different options
 * that will allow them to manipulate the database and retreive the information they need.
 * This application will both work with directly implementing code as well as using controls to achieve
 * these goals.
 **/





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
    public partial class northwindSelection : Form
    {
        public northwindSelection()
        {
            InitializeComponent();
        }

        //Opens customer orders form
        private void cusOrdersButton_Click(object sender, EventArgs e)
        {
            CustomerOrders cusOrder = new CustomerOrders();
            cusOrder.Show();
        }
        //Exits application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Opens category filter form
        private void catFilterButton_Click(object sender, EventArgs e)
        {
            productsFilteredForm proFilter = new productsFilteredForm();
            proFilter.Show();
        }
        //Opens category unbound form
        private void catUnboundButton_Click(object sender, EventArgs e)
        {
            CategoryUnbound catUnbound = new CategoryUnbound();
            catUnbound.Show();
        }
        //Opens territories form
        private void territoriesButton_Click(object sender, EventArgs e)
        {
            EmployeeTerritories empTerritory = new EmployeeTerritories();
            empTerritory.Show();
        }
    }
}
