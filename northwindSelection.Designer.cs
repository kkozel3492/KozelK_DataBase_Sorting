
namespace _3343_KozelK_Lab04
{
    partial class northwindSelection
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
            this.cusOrdersButton = new System.Windows.Forms.Button();
            this.catUnboundButton = new System.Windows.Forms.Button();
            this.catFilterButton = new System.Windows.Forms.Button();
            this.territoriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cusOrdersButton
            // 
            this.cusOrdersButton.Location = new System.Drawing.Point(12, 23);
            this.cusOrdersButton.Name = "cusOrdersButton";
            this.cusOrdersButton.Size = new System.Drawing.Size(181, 56);
            this.cusOrdersButton.TabIndex = 1;
            this.cusOrdersButton.Text = "Customer &Orders (Master/Detail)";
            this.cusOrdersButton.UseVisualStyleBackColor = true;
            this.cusOrdersButton.Click += new System.EventHandler(this.cusOrdersButton_Click);
            // 
            // catUnboundButton
            // 
            this.catUnboundButton.Location = new System.Drawing.Point(12, 94);
            this.catUnboundButton.Name = "catUnboundButton";
            this.catUnboundButton.Size = new System.Drawing.Size(181, 63);
            this.catUnboundButton.TabIndex = 2;
            this.catUnboundButton.Text = "&Categories Products (Unbound)";
            this.catUnboundButton.UseVisualStyleBackColor = true;
            this.catUnboundButton.Click += new System.EventHandler(this.catUnboundButton_Click);
            // 
            // catFilterButton
            // 
            this.catFilterButton.Location = new System.Drawing.Point(224, 23);
            this.catFilterButton.Name = "catFilterButton";
            this.catFilterButton.Size = new System.Drawing.Size(172, 56);
            this.catFilterButton.TabIndex = 3;
            this.catFilterButton.Text = "Categories &Products (Filtering)";
            this.catFilterButton.UseVisualStyleBackColor = true;
            this.catFilterButton.Click += new System.EventHandler(this.catFilterButton_Click);
            // 
            // territoriesButton
            // 
            this.territoriesButton.Location = new System.Drawing.Point(224, 94);
            this.territoriesButton.Name = "territoriesButton";
            this.territoriesButton.Size = new System.Drawing.Size(172, 63);
            this.territoriesButton.TabIndex = 4;
            this.territoriesButton.Text = "&Employee Territories (Many-to-Many)";
            this.territoriesButton.UseVisualStyleBackColor = true;
            this.territoriesButton.Click += new System.EventHandler(this.territoriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 181);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 43);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // northwindSelection
            // 
            this.AcceptButton = this.cusOrdersButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(408, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.territoriesButton);
            this.Controls.Add(this.catFilterButton);
            this.Controls.Add(this.catUnboundButton);
            this.Controls.Add(this.cusOrdersButton);
            this.Name = "northwindSelection";
            this.Text = "Northwind Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cusOrdersButton;
        private System.Windows.Forms.Button catUnboundButton;
        private System.Windows.Forms.Button catFilterButton;
        private System.Windows.Forms.Button territoriesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

