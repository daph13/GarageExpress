namespace Garage_Express
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.groupBoxReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Controls.Add(this.btnBack);
            this.groupBoxReports.Controls.Add(this.btnViewSales);
            this.groupBoxReports.Controls.Add(this.btnViewStock);
            this.groupBoxReports.Location = new System.Drawing.Point(38, 23);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(200, 192);
            this.groupBoxReports.TabIndex = 0;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Reports";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(162, 169);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(64, 110);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(75, 23);
            this.btnViewSales.TabIndex = 1;
            this.btnViewSales.Text = "Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(64, 55);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(75, 23);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "Reports";
            this.groupBoxReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnBack;
    }
}