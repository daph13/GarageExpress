namespace Garage_Express
{
    partial class frmStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockReport));
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMotors = new System.Windows.Forms.Label();
            this.lblQuads = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.HorizontalScrollbar = true;
            this.listBoxVehicles.Location = new System.Drawing.Point(46, 50);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxVehicles.Size = new System.Drawing.Size(728, 147);
            this.listBoxVehicles.TabIndex = 0;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblTotal);
            this.groupBoxStats.Controls.Add(this.lblMotors);
            this.groupBoxStats.Controls.Add(this.lblQuads);
            this.groupBoxStats.Controls.Add(this.lblCars);
            this.groupBoxStats.Location = new System.Drawing.Point(46, 203);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(214, 104);
            this.groupBoxStats.TabIndex = 1;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stock Summary";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Vehicles :";
            // 
            // lblMotors
            // 
            this.lblMotors.AutoSize = true;
            this.lblMotors.Location = new System.Drawing.Point(20, 59);
            this.lblMotors.Name = "lblMotors";
            this.lblMotors.Size = new System.Drawing.Size(69, 13);
            this.lblMotors.TabIndex = 2;
            this.lblMotors.Text = "Motor Bikes :";
            // 
            // lblQuads
            // 
            this.lblQuads.AutoSize = true;
            this.lblQuads.Location = new System.Drawing.Point(20, 42);
            this.lblQuads.Name = "lblQuads";
            this.lblQuads.Size = new System.Drawing.Size(68, 13);
            this.lblQuads.TabIndex = 1;
            this.lblQuads.Text = "Quad Bikes :";
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(20, 25);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(34, 13);
            this.lblCars.TabIndex = 0;
            this.lblCars.Text = "Cars :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(46, 12);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(699, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 319);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.listBoxVehicles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockReport";
            this.Text = "Stock Report";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMotors;
        private System.Windows.Forms.Label lblQuads;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnBack;
    }
}