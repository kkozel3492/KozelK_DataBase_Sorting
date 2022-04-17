
namespace _3343_KozelK_Lab04
{
    partial class CategoryUnbound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwndDataSet = new _3343_KozelK_Lab04.northwndDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.prodListBox = new System.Windows.Forms.ListBox();
            this.categoriesTableAdapter = new _3343_KozelK_Lab04.northwndDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new _3343_KozelK_Lab04.northwndDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // catComboBox
            // 
            this.catComboBox.DataSource = this.categoriesBindingSource;
            this.catComboBox.DisplayMember = "CategoryName";
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(107, 12);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(186, 24);
            this.catComboBox.TabIndex = 1;
            this.catComboBox.ValueMember = "CategoryID";
            this.catComboBox.SelectionChangeCommitted += new System.EventHandler(this.catComboBox_SelectionChangeCommitted);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northwndDataSet;
            // 
            // northwndDataSet
            // 
            this.northwndDataSet.DataSetName = "northwndDataSet";
            this.northwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products:";
            // 
            // prodListBox
            // 
            this.prodListBox.FormattingEnabled = true;
            this.prodListBox.ItemHeight = 16;
            this.prodListBox.Location = new System.Drawing.Point(107, 51);
            this.prodListBox.Name = "prodListBox";
            this.prodListBox.Size = new System.Drawing.Size(186, 196);
            this.prodListBox.TabIndex = 3;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3343_KozelK_Lab04.northwndDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(218, 263);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CategoryUnbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(307, 299);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prodListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CategoryUnbound";
            this.Text = "Category Products (Unbound)";
            this.Load += new System.EventHandler(this.CategoryUnbound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox prodListBox;
        private northwndDataSet northwndDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private northwndDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private northwndDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button exitButton;
    }
}