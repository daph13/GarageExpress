namespace Garage_Express
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.comboBoxDates = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.listBoxSales = new System.Windows.Forms.ListBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblVehiclesSold = new System.Windows.Forms.Label();
            this.lblDateSelected = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPurchaseDetails = new System.Windows.Forms.Label();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDates
            // 
            this.comboBoxDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDates.FormattingEnabled = true;
            this.comboBoxDates.Location = new System.Drawing.Point(22, 30);
            this.comboBoxDates.Name = "comboBoxDates";
            this.comboBoxDates.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDates.TabIndex = 0;
            this.comboBoxDates.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Choose a Date";
            // 
            // listBoxSales
            // 
            this.listBoxSales.FormattingEnabled = true;
            this.listBoxSales.HorizontalScrollbar = true;
            this.listBoxSales.Location = new System.Drawing.Point(22, 66);
            this.listBoxSales.Name = "listBoxSales";
            this.listBoxSales.Size = new System.Drawing.Size(658, 121);
            this.listBoxSales.TabIndex = 2;
            this.listBoxSales.SelectedIndexChanged += new System.EventHandler(this.listBoxSales_SelectedIndexChanged);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblTotalSales);
            this.groupBoxStats.Controls.Add(this.lblProfit);
            this.groupBoxStats.Controls.Add(this.lblVehiclesSold);
            this.groupBoxStats.Controls.Add(this.lblDateSelected);
            this.groupBoxStats.Location = new System.Drawing.Point(686, 66);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(193, 121);
            this.groupBoxStats.TabIndex = 3;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Sales Summary";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(16, 72);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(78, 13);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "Sales Amount :";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(16, 97);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(76, 13);
            this.lblProfit.TabIndex = 2;
            this.lblProfit.Text = "Profit Amount :";
            // 
            // lblVehiclesSold
            // 
            this.lblVehiclesSold.AutoSize = true;
            this.lblVehiclesSold.Location = new System.Drawing.Point(16, 49);
            this.lblVehiclesSold.Name = "lblVehiclesSold";
            this.lblVehiclesSold.Size = new System.Drawing.Size(77, 13);
            this.lblVehiclesSold.TabIndex = 1;
            this.lblVehiclesSold.Text = "Vehicles Sold :";
            // 
            // lblDateSelected
            // 
            this.lblDateSelected.AutoSize = true;
            this.lblDateSelected.Location = new System.Drawing.Point(16, 25);
            this.lblDateSelected.Name = "lblDateSelected";
            this.lblDateSelected.Size = new System.Drawing.Size(36, 13);
            this.lblDateSelected.TabIndex = 0;
            this.lblDateSelected.Text = "Date :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(804, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPurchaseDetails
            // 
            this.lblPurchaseDetails.AutoSize = true;
            this.lblPurchaseDetails.Location = new System.Drawing.Point(22, 199);
            this.lblPurchaseDetails.Name = "lblPurchaseDetails";
            this.lblPurchaseDetails.Size = new System.Drawing.Size(87, 13);
            this.lblPurchaseDetails.TabIndex = 6;
            this.lblPurchaseDetails.Text = "Purchase Details";
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 340);
            this.Controls.Add(this.lblPurchaseDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.listBoxSales);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.comboBoxDates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesReport";
            this.Text = "Sales Report";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDates;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox listBoxSales;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblVehiclesSold;
        private System.Windows.Forms.Label lblDateSelected;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPurchaseDetails;
        private System.Windows.Forms.Label lblTotalSales;
    }
}