namespace Garage_Express
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonMotorBike = new System.Windows.Forms.RadioButton();
            this.radioButtonQuadBike = new System.Windows.Forms.RadioButton();
            this.listBoxView = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.lblNumWheels = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumDoorsValves = new System.Windows.Forms.Label();
            this.lblChildProof = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.txtNumWheels = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNumDoorsValves = new System.Windows.Forms.TextBox();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMotors = new System.Windows.Forms.Label();
            this.lblQuads = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(114, 29);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(41, 17);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonMotorBike
            // 
            this.radioButtonMotorBike.AutoSize = true;
            this.radioButtonMotorBike.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonMotorBike.Location = new System.Drawing.Point(309, 29);
            this.radioButtonMotorBike.Name = "radioButtonMotorBike";
            this.radioButtonMotorBike.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMotorBike.TabIndex = 1;
            this.radioButtonMotorBike.Text = "MotorBike";
            this.radioButtonMotorBike.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuadBike
            // 
            this.radioButtonQuadBike.AutoSize = true;
            this.radioButtonQuadBike.Location = new System.Drawing.Point(194, 29);
            this.radioButtonQuadBike.Name = "radioButtonQuadBike";
            this.radioButtonQuadBike.Size = new System.Drawing.Size(72, 17);
            this.radioButtonQuadBike.TabIndex = 2;
            this.radioButtonQuadBike.Text = "QuadBike";
            this.radioButtonQuadBike.UseVisualStyleBackColor = true;
            // 
            // listBoxView
            // 
            this.listBoxView.FormattingEnabled = true;
            this.listBoxView.HorizontalScrollbar = true;
            this.listBoxView.Location = new System.Drawing.Point(34, 62);
            this.listBoxView.Name = "listBoxView";
            this.listBoxView.Size = new System.Drawing.Size(729, 160);
            this.listBoxView.TabIndex = 3;
            this.listBoxView.SelectedIndexChanged += new System.EventHandler(this.listBoxView_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(634, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(634, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(43, 29);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 7;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(31, 301);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(34, 240);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 9;
            this.lblMake.Text = "Make";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(156, 239);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(103, 13);
            this.lblRegNum.TabIndex = 10;
            this.lblRegNum.Text = "Registration Number";
            // 
            // lblNumWheels
            // 
            this.lblNumWheels.AutoSize = true;
            this.lblNumWheels.Location = new System.Drawing.Point(156, 301);
            this.lblNumWheels.Name = "lblNumWheels";
            this.lblNumWheels.Size = new System.Drawing.Size(83, 13);
            this.lblNumWheels.TabIndex = 11;
            this.lblNumWheels.Text = "Number Wheels";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(306, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // lblNumDoorsValves
            // 
            this.lblNumDoorsValves.AutoSize = true;
            this.lblNumDoorsValves.Location = new System.Drawing.Point(306, 301);
            this.lblNumDoorsValves.Name = "lblNumDoorsValves";
            this.lblNumDoorsValves.Size = new System.Drawing.Size(87, 13);
            this.lblNumDoorsValves.TabIndex = 13;
            this.lblNumDoorsValves.Text = "Number of Doors";
            // 
            // lblChildProof
            // 
            this.lblChildProof.AutoSize = true;
            this.lblChildProof.Location = new System.Drawing.Point(457, 239);
            this.lblChildProof.Name = "lblChildProof";
            this.lblChildProof.Size = new System.Drawing.Size(58, 13);
            this.lblChildProof.TabIndex = 14;
            this.lblChildProof.Text = "Child Proof";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(34, 317);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(93, 20);
            this.txtModel.TabIndex = 15;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(35, 255);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(93, 20);
            this.txtMake.TabIndex = 16;
            // 
            // txtRegNum
            // 
            this.txtRegNum.Enabled = false;
            this.txtRegNum.Location = new System.Drawing.Point(159, 255);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(100, 20);
            this.txtRegNum.TabIndex = 17;
            // 
            // txtNumWheels
            // 
            this.txtNumWheels.Location = new System.Drawing.Point(159, 317);
            this.txtNumWheels.Name = "txtNumWheels";
            this.txtNumWheels.Size = new System.Drawing.Size(100, 20);
            this.txtNumWheels.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(309, 254);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 19;
            // 
            // txtNumDoorsValves
            // 
            this.txtNumDoorsValves.Location = new System.Drawing.Point(309, 316);
            this.txtNumDoorsValves.Name = "txtNumDoorsValves";
            this.txtNumDoorsValves.Size = new System.Drawing.Size(100, 20);
            this.txtNumDoorsValves.TabIndex = 20;
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(460, 258);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTrue.TabIndex = 21;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "True";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(528, 259);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFalse.TabIndex = 22;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "False";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Location = new System.Drawing.Point(34, 12);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(551, 45);
            this.groupBoxVehicle.TabIndex = 23;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Vehicle Type";
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblTotal);
            this.groupBoxStats.Controls.Add(this.lblMotors);
            this.groupBoxStats.Controls.Add(this.lblQuads);
            this.groupBoxStats.Controls.Add(this.lblCars);
            this.groupBoxStats.Location = new System.Drawing.Point(769, 62);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(147, 160);
            this.groupBoxStats.TabIndex = 24;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stock Stats";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 123);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total :";
            // 
            // lblMotors
            // 
            this.lblMotors.AutoSize = true;
            this.lblMotors.Location = new System.Drawing.Point(10, 94);
            this.lblMotors.Name = "lblMotors";
            this.lblMotors.Size = new System.Drawing.Size(66, 13);
            this.lblMotors.TabIndex = 2;
            this.lblMotors.Text = "MotorBikes :";
            // 
            // lblQuads
            // 
            this.lblQuads.AutoSize = true;
            this.lblQuads.Location = new System.Drawing.Point(10, 65);
            this.lblQuads.Name = "lblQuads";
            this.lblQuads.Size = new System.Drawing.Size(65, 13);
            this.lblQuads.TabIndex = 1;
            this.lblQuads.Text = "QuadBikes :";
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(10, 34);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(34, 13);
            this.lblCars.TabIndex = 0;
            this.lblCars.Text = "Cars :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(634, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 364);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.groupBoxVehicle);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.txtNumDoorsValves);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumWheels);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblChildProof);
            this.Controls.Add(this.lblNumDoorsValves);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumWheels);
            this.Controls.Add(this.lblRegNum);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.radioButtonQuadBike);
            this.Controls.Add(this.radioButtonMotorBike);
            this.Controls.Add(this.radioButtonCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStock";
            this.Text = "Stock";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonMotorBike;
        private System.Windows.Forms.RadioButton radioButtonQuadBike;
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label lblNumWheels;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumDoorsValves;
        private System.Windows.Forms.Label lblChildProof;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.TextBox txtNumWheels;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNumDoorsValves;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMotors;
        private System.Windows.Forms.Label lblQuads;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Button btnClose;
    }
}