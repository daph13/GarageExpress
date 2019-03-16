namespace Garage_Express
{
    partial class frmAddSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSale));
            this.groupBoxCustDetails = new System.Windows.Forms.GroupBox();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDatePurchase = new System.Windows.Forms.Label();
            this.datePurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxCustDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustDetails
            // 
            this.groupBoxCustDetails.Controls.Add(this.dateBirthDate);
            this.groupBoxCustDetails.Controls.Add(this.lblBirthDate);
            this.groupBoxCustDetails.Controls.Add(this.txtAddress);
            this.groupBoxCustDetails.Controls.Add(this.lblAddress);
            this.groupBoxCustDetails.Controls.Add(this.txtPhone);
            this.groupBoxCustDetails.Controls.Add(this.lblPhone);
            this.groupBoxCustDetails.Controls.Add(this.lblDatePurchase);
            this.groupBoxCustDetails.Controls.Add(this.datePurchaseDate);
            this.groupBoxCustDetails.Controls.Add(this.txtLastName);
            this.groupBoxCustDetails.Controls.Add(this.txtFirstName);
            this.groupBoxCustDetails.Controls.Add(this.lblLastName);
            this.groupBoxCustDetails.Controls.Add(this.lblFirstName);
            this.groupBoxCustDetails.Location = new System.Drawing.Point(25, 25);
            this.groupBoxCustDetails.Name = "groupBoxCustDetails";
            this.groupBoxCustDetails.Size = new System.Drawing.Size(283, 289);
            this.groupBoxCustDetails.TabIndex = 1;
            this.groupBoxCustDetails.TabStop = false;
            this.groupBoxCustDetails.Text = "Customer Details";
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthDate.Location = new System.Drawing.Point(23, 154);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(101, 20);
            this.dateBirthDate.TabIndex = 11;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(23, 137);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(68, 13);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Date Of Birth";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(23, 250);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(253, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 234);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 185);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblDatePurchase
            // 
            this.lblDatePurchase.AutoSize = true;
            this.lblDatePurchase.Location = new System.Drawing.Point(154, 34);
            this.lblDatePurchase.Name = "lblDatePurchase";
            this.lblDatePurchase.Size = new System.Drawing.Size(84, 13);
            this.lblDatePurchase.TabIndex = 5;
            this.lblDatePurchase.Text = "Date Purchased";
            // 
            // datePurchaseDate
            // 
            this.datePurchaseDate.CustomFormat = "dd/MM/yyyy";
            this.datePurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePurchaseDate.Location = new System.Drawing.Point(157, 50);
            this.datePurchaseDate.Name = "datePurchaseDate";
            this.datePurchaseDate.Size = new System.Drawing.Size(100, 20);
            this.datePurchaseDate.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(23, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(24, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(28, 320);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(233, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 365);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.groupBoxCustDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSale";
            this.Text = "New Sale";
            this.groupBoxCustDetails.ResumeLayout(false);
            this.groupBoxCustDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCustDetails;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDatePurchase;
        private System.Windows.Forms.DateTimePicker datePurchaseDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
    }
}