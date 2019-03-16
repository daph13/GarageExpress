namespace Garage_Express
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.groupBoxVehicles = new System.Windows.Forms.GroupBox();
            this.radioButtonMotor = new System.Windows.Forms.RadioButton();
            this.radioButtonQuad = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listBoxSales = new System.Windows.Forms.ListBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDatePurchase = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.datePurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCustDetails = new System.Windows.Forms.GroupBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxVehicles.SuspendLayout();
            this.groupBoxCustDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.HorizontalScrollbar = true;
            this.listBoxVehicles.ItemHeight = 20;
            this.listBoxVehicles.Location = new System.Drawing.Point(94, 103);
            this.listBoxVehicles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(1105, 144);
            this.listBoxVehicles.TabIndex = 0;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // groupBoxVehicles
            // 
            this.groupBoxVehicles.Controls.Add(this.radioButtonMotor);
            this.groupBoxVehicles.Controls.Add(this.radioButtonQuad);
            this.groupBoxVehicles.Controls.Add(this.radioButtonCar);
            this.groupBoxVehicles.Controls.Add(this.radioButtonAll);
            this.groupBoxVehicles.Location = new System.Drawing.Point(94, 12);
            this.groupBoxVehicles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxVehicles.Name = "groupBoxVehicles";
            this.groupBoxVehicles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxVehicles.Size = new System.Drawing.Size(786, 62);
            this.groupBoxVehicles.TabIndex = 1;
            this.groupBoxVehicles.TabStop = false;
            this.groupBoxVehicles.Text = "Vehicles";
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Location = new System.Drawing.Point(604, 26);
            this.radioButtonMotor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(110, 24);
            this.radioButtonMotor.TabIndex = 3;
            this.radioButtonMotor.Text = "Motor Bike";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuad
            // 
            this.radioButtonQuad.AutoSize = true;
            this.radioButtonQuad.Location = new System.Drawing.Point(387, 26);
            this.radioButtonQuad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonQuad.Name = "radioButtonQuad";
            this.radioButtonQuad.Size = new System.Drawing.Size(108, 24);
            this.radioButtonQuad.TabIndex = 2;
            this.radioButtonQuad.Text = "Quad Bike";
            this.radioButtonQuad.UseVisualStyleBackColor = true;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(214, 26);
            this.radioButtonCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(59, 24);
            this.radioButtonCar.TabIndex = 1;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(24, 26);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(51, 24);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(1089, 258);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(112, 35);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1160, 640);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicles.Location = new System.Drawing.Point(90, 78);
            this.lblVehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(128, 20);
            this.lblVehicles.TabIndex = 4;
            this.lblVehicles.Text = "Vehicles for Sale";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(90, 258);
            this.lblSalePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(154, 20);
            this.lblSalePrice.TabIndex = 5;
            this.lblSalePrice.Text = "Sale Price of Vehicle";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(916, 568);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listBoxSales
            // 
            this.listBoxSales.FormattingEnabled = true;
            this.listBoxSales.ItemHeight = 20;
            this.listBoxSales.Location = new System.Drawing.Point(94, 349);
            this.listBoxSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxSales.Name = "listBoxSales";
            this.listBoxSales.Size = new System.Drawing.Size(1105, 144);
            this.listBoxSales.TabIndex = 8;
            this.listBoxSales.SelectedIndexChanged += new System.EventHandler(this.listBoxSales_SelectedIndexChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(14, 37);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(14, 103);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(210, 37);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(99, 20);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(210, 105);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(435, 103);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // lblDatePurchase
            // 
            this.lblDatePurchase.AutoSize = true;
            this.lblDatePurchase.Location = new System.Drawing.Point(435, 37);
            this.lblDatePurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatePurchase.Name = "lblDatePurchase";
            this.lblDatePurchase.Size = new System.Drawing.Size(124, 20);
            this.lblDatePurchase.TabIndex = 15;
            this.lblDatePurchase.Text = "Date Purchased";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(14, 62);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 26);
            this.txtFName.TabIndex = 16;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(14, 128);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 26);
            this.txtLName.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(214, 128);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 26);
            this.txtPhone.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(440, 126);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(326, 26);
            this.txtAddress.TabIndex = 20;
            // 
            // datePurchaseDate
            // 
            this.datePurchaseDate.CustomFormat = "dd/MM/yyyy";
            this.datePurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePurchaseDate.Location = new System.Drawing.Point(440, 63);
            this.datePurchaseDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePurchaseDate.Name = "datePurchaseDate";
            this.datePurchaseDate.Size = new System.Drawing.Size(148, 26);
            this.datePurchaseDate.TabIndex = 21;
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthDate.Location = new System.Drawing.Point(214, 62);
            this.dateBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(148, 26);
            this.dateBirthDate.TabIndex = 22;
            // 
            // groupBoxCustDetails
            // 
            this.groupBoxCustDetails.Controls.Add(this.dateBirthDate);
            this.groupBoxCustDetails.Controls.Add(this.lblFName);
            this.groupBoxCustDetails.Controls.Add(this.datePurchaseDate);
            this.groupBoxCustDetails.Controls.Add(this.lblLName);
            this.groupBoxCustDetails.Controls.Add(this.txtAddress);
            this.groupBoxCustDetails.Controls.Add(this.lblDOB);
            this.groupBoxCustDetails.Controls.Add(this.txtPhone);
            this.groupBoxCustDetails.Controls.Add(this.lblPhone);
            this.groupBoxCustDetails.Controls.Add(this.txtLName);
            this.groupBoxCustDetails.Controls.Add(this.lblAddress);
            this.groupBoxCustDetails.Controls.Add(this.txtFName);
            this.groupBoxCustDetails.Controls.Add(this.lblDatePurchase);
            this.groupBoxCustDetails.Location = new System.Drawing.Point(94, 505);
            this.groupBoxCustDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustDetails.Name = "groupBoxCustDetails";
            this.groupBoxCustDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustDetails.Size = new System.Drawing.Size(813, 171);
            this.groupBoxCustDetails.TabIndex = 23;
            this.groupBoxCustDetails.TabStop = false;
            this.groupBoxCustDetails.Text = "Customer Details";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(94, 311);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(49, 20);
            this.lblSales.TabIndex = 24;
            this.lblSales.Text = "Sales";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1038, 568);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 694);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.groupBoxCustDetails);
            this.Controls.Add(this.listBoxSales);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.groupBoxVehicles);
            this.Controls.Add(this.listBoxVehicles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSales";
            this.Text = "Sales";
            this.groupBoxVehicles.ResumeLayout(false);
            this.groupBoxVehicles.PerformLayout();
            this.groupBoxCustDetails.ResumeLayout(false);
            this.groupBoxCustDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.GroupBox groupBoxVehicles;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonQuad;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox listBoxSales;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDatePurchase;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker datePurchaseDate;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.GroupBox groupBoxCustDetails;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Button btnDelete;
    }
}