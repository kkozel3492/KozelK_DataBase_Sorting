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
    public partial class EmployeeTerritories : Form
    {
        public EmployeeTerritories()
        {
            InitializeComponent();
        }
        private northwndDataSet aNorthwndDataSet = new northwndDataSet();

        private void EmployeeTerritories_Load(object sender, EventArgs e)
        {
            //Create dataset objects for each of the tables
            northwndDataSetTableAdapters.EmployeesTableAdapter anEmployeeTableAdapter;
            northwndDataSetTableAdapters.TerritoriesTableAdapter aTerritoriesTableAdapter;
            northwndDataSetTableAdapters.EmployeeTerritoriesTableAdapter aJointTableAdapter;

            anEmployeeTableAdapter = new northwndDataSetTableAdapters.EmployeesTableAdapter();
            aTerritoriesTableAdapter = new northwndDataSetTableAdapters.TerritoriesTableAdapter();
            aJointTableAdapter = new northwndDataSetTableAdapters.EmployeeTerritoriesTableAdapter();

            //Fill
            anEmployeeTableAdapter.Fill(aNorthwndDataSet.Employees);
            aTerritoriesTableAdapter.Fill(aNorthwndDataSet.Territories);
            aJointTableAdapter.Fill(aNorthwndDataSet.EmployeeTerritories);

            //Connect ComboBox to DataSource
            empComboBox.DataSource = aNorthwndDataSet.Employees;
            empComboBox.DisplayMember = "FullName";
            empComboBox.ValueMember = "EmployeeID";
            
            empComboBox.SelectedIndex = -1;
        }

        private void empComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Variables
            int employeeID;
            string territory = "";
            List<string> territories = new List<string>();

            DataRow empDataRow;
            DataRow[] employeeTerritoriesDataRows;

            //Assign value from comboBox
            employeeID = Convert.ToInt16(empComboBox.SelectedValue);
            

            //Assign value to author data row
            empDataRow = aNorthwndDataSet.Employees.FindByEmployeeID(employeeID);

            //Assign values to employee territories data row
            employeeTerritoriesDataRows = empDataRow.GetChildRows("EmployeeTerritoriesToEmployees");

            foreach(DataRow employeeTerritoriesDataRow in employeeTerritoriesDataRows)
            {
                territory = employeeTerritoriesDataRow.GetParentRow("EmployeeTerritoriesToTerritories")["TerritoryDescription"].ToString();
                territories.Add(territory);
            }
            //Clear list box
            terListBox.Items.Clear();

            //Populate list box
            foreach(string territoriesA in territories)
            {
                terListBox.Items.Add(territoriesA);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
