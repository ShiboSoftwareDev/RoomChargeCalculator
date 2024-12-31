namespace RoomChargeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblDateContent = new Label();
            lblTimeContent = new Label();
            grpRoomInformation = new GroupBox();
            txtNightlyCharge = new TextBox();
            txtNights = new TextBox();
            lblNightlyCharge = new Label();
            lblNights = new Label();
            grpAdditionalCharges = new GroupBox();
            txtMisc = new TextBox();
            txtPhone = new TextBox();
            txtRoomService = new TextBox();
            lblMisc = new Label();
            lblPhone = new Label();
            lblRoomService = new Label();
            s = new GroupBox();
            txtTotalCharges = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            txtAdditionalCharges = new TextBox();
            txtRoomCharges = new TextBox();
            lblTotalCharges = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            lblAdditionalCharges = new Label();
            lblRoomCharges = new Label();
            btnCalculateCharges = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpRoomInformation.SuspendLayout();
            grpAdditionalCharges.SuspendLayout();
            s.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(242, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Peace Hotel";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(196, 56);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(77, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Today's Date:";
            lblDate.Click += lblDate_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(204, 78);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(37, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time:";
            lblTime.Click += lblTime_Click;
            // 
            // lblDateContent
            // 
            lblDateContent.AutoSize = true;
            lblDateContent.Location = new Point(286, 56);
            lblDateContent.Name = "lblDateContent";
            lblDateContent.Size = new Size(38, 15);
            lblDateContent.TabIndex = 3;
            lblDateContent.Text = "label4";
            lblDateContent.Click += lblDateContent_Click;
            // 
            // lblTimeContent
            // 
            lblTimeContent.AutoSize = true;
            lblTimeContent.Location = new Point(284, 78);
            lblTimeContent.Name = "lblTimeContent";
            lblTimeContent.Size = new Size(38, 15);
            lblTimeContent.TabIndex = 4;
            lblTimeContent.Text = "label5";
            lblTimeContent.Click += lblTimeContent_Click;
            // 
            // grpRoomInformation
            // 
            grpRoomInformation.Controls.Add(txtNightlyCharge);
            grpRoomInformation.Controls.Add(txtNights);
            grpRoomInformation.Controls.Add(lblNightlyCharge);
            grpRoomInformation.Controls.Add(lblNights);
            grpRoomInformation.Location = new Point(65, 137);
            grpRoomInformation.Name = "grpRoomInformation";
            grpRoomInformation.Size = new Size(241, 134);
            grpRoomInformation.TabIndex = 5;
            grpRoomInformation.TabStop = false;
            grpRoomInformation.Text = "Room Information";
            // 
            // txtNightlyCharge
            // 
            txtNightlyCharge.Location = new Point(108, 50);
            txtNightlyCharge.Name = "txtNightlyCharge";
            txtNightlyCharge.Size = new Size(100, 23);
            txtNightlyCharge.TabIndex = 3;
            txtNightlyCharge.TextChanged += txtNightlyCharge_TextChanged;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(103, 21);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(100, 23);
            txtNights.TabIndex = 2;
            txtNights.TextChanged += txtNights_TextChanged;
            // 
            // lblNightlyCharge
            // 
            lblNightlyCharge.AutoSize = true;
            lblNightlyCharge.Location = new Point(19, 57);
            lblNightlyCharge.Name = "lblNightlyCharge";
            lblNightlyCharge.Size = new Size(90, 15);
            lblNightlyCharge.TabIndex = 1;
            lblNightlyCharge.Text = "Nightly Charge:";
            lblNightlyCharge.Click += lblNightlyCharge_Click;
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Location = new Point(52, 18);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(45, 15);
            lblNights.TabIndex = 0;
            lblNights.Text = "Nights:";
            lblNights.Click += lblNights_Click;
            // 
            // grpAdditionalCharges
            // 
            grpAdditionalCharges.Controls.Add(txtMisc);
            grpAdditionalCharges.Controls.Add(txtPhone);
            grpAdditionalCharges.Controls.Add(txtRoomService);
            grpAdditionalCharges.Controls.Add(lblMisc);
            grpAdditionalCharges.Controls.Add(lblPhone);
            grpAdditionalCharges.Controls.Add(lblRoomService);
            grpAdditionalCharges.Location = new Point(344, 148);
            grpAdditionalCharges.Name = "grpAdditionalCharges";
            grpAdditionalCharges.Size = new Size(242, 123);
            grpAdditionalCharges.TabIndex = 6;
            grpAdditionalCharges.TabStop = false;
            grpAdditionalCharges.Text = "Additional Charges";
            // 
            // txtMisc
            // 
            txtMisc.Location = new Point(95, 71);
            txtMisc.Name = "txtMisc";
            txtMisc.Size = new Size(100, 23);
            txtMisc.TabIndex = 5;
            txtMisc.TextChanged += txtMisc_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(92, 46);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 4;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtRoomService
            // 
            txtRoomService.Location = new Point(91, 19);
            txtRoomService.Name = "txtRoomService";
            txtRoomService.Size = new Size(100, 23);
            txtRoomService.TabIndex = 3;
            txtRoomService.TextChanged += txtRoomService_TextChanged;
            // 
            // lblMisc
            // 
            lblMisc.AutoSize = true;
            lblMisc.Location = new Point(35, 61);
            lblMisc.Name = "lblMisc";
            lblMisc.Size = new Size(35, 15);
            lblMisc.TabIndex = 2;
            lblMisc.Text = "Misc:";
            lblMisc.Click += lblMisc_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(35, 35);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Telephone:";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblRoomService
            // 
            lblRoomService.AutoSize = true;
            lblRoomService.Location = new Point(36, 23);
            lblRoomService.Name = "lblRoomService";
            lblRoomService.Size = new Size(82, 15);
            lblRoomService.TabIndex = 0;
            lblRoomService.Text = "Room Service:";
            lblRoomService.Click += lblRoomService_Click;
            // 
            // s
            // 
            s.Controls.Add(txtTotalCharges);
            s.Controls.Add(txtTax);
            s.Controls.Add(txtSubtotal);
            s.Controls.Add(txtAdditionalCharges);
            s.Controls.Add(txtRoomCharges);
            s.Controls.Add(lblTotalCharges);
            s.Controls.Add(lblTax);
            s.Controls.Add(lblSubtotal);
            s.Controls.Add(lblAdditionalCharges);
            s.Controls.Add(lblRoomCharges);
            s.Location = new Point(168, 277);
            s.Name = "s";
            s.Size = new Size(312, 148);
            s.TabIndex = 7;
            s.TabStop = false;
            s.Text = "Total Charges";
            // 
            // txtTotalCharges
            // 
            txtTotalCharges.Location = new Point(82, 123);
            txtTotalCharges.Name = "txtTotalCharges";
            txtTotalCharges.Size = new Size(100, 23);
            txtTotalCharges.TabIndex = 9;
            txtTotalCharges.TextChanged += txtTotalCharges_TextChanged;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(81, 95);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 8;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(75, 66);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 7;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // txtAdditionalCharges
            // 
            txtAdditionalCharges.Location = new Point(74, 40);
            txtAdditionalCharges.Name = "txtAdditionalCharges";
            txtAdditionalCharges.Size = new Size(100, 23);
            txtAdditionalCharges.TabIndex = 6;
            txtAdditionalCharges.TextChanged += txtAdditionalCharges_TextChanged;
            // 
            // txtRoomCharges
            // 
            txtRoomCharges.Location = new Point(73, 14);
            txtRoomCharges.Name = "txtRoomCharges";
            txtRoomCharges.Size = new Size(100, 23);
            txtRoomCharges.TabIndex = 5;
            txtRoomCharges.TextChanged += txtRoomCharges_TextChanged;
            // 
            // lblTotalCharges
            // 
            lblTotalCharges.AutoSize = true;
            lblTotalCharges.Location = new Point(30, 98);
            lblTotalCharges.Name = "lblTotalCharges";
            lblTotalCharges.Size = new Size(82, 15);
            lblTotalCharges.TabIndex = 4;
            lblTotalCharges.Text = "Total Charges:";
            lblTotalCharges.Click += lblTotalCharges_Click;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(28, 75);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 3;
            lblTax.Text = "Tax:";
            lblTax.Click += lblTax_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(24, 59);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblAdditionalCharges
            // 
            lblAdditionalCharges.AutoSize = true;
            lblAdditionalCharges.Location = new Point(21, 38);
            lblAdditionalCharges.Name = "lblAdditionalCharges";
            lblAdditionalCharges.Size = new Size(111, 15);
            lblAdditionalCharges.TabIndex = 1;
            lblAdditionalCharges.Text = "Additional Charges:";
            lblAdditionalCharges.Click += lblAdditionalCharges_Click;
            // 
            // lblRoomCharges
            // 
            lblRoomCharges.AutoSize = true;
            lblRoomCharges.Location = new Point(18, 19);
            lblRoomCharges.Name = "lblRoomCharges";
            lblRoomCharges.Size = new Size(88, 15);
            lblRoomCharges.TabIndex = 0;
            lblRoomCharges.Text = "Room Charges:";
            lblRoomCharges.Click += lblRoomCharges_Click;
            // 
            // btnCalculateCharges
            // 
            btnCalculateCharges.Location = new Point(84, 461);
            btnCalculateCharges.Name = "btnCalculateCharges";
            btnCalculateCharges.Size = new Size(75, 49);
            btnCalculateCharges.TabIndex = 8;
            btnCalculateCharges.Text = "Calculate Charges";
            btnCalculateCharges.UseVisualStyleBackColor = true;
            btnCalculateCharges.Click += btnCalculateCharges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(211, 464);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(355, 459);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 522);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateCharges);
            Controls.Add(s);
            Controls.Add(grpAdditionalCharges);
            Controls.Add(grpRoomInformation);
            Controls.Add(lblTimeContent);
            Controls.Add(lblDateContent);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Room Charge Calculator";
            grpRoomInformation.ResumeLayout(false);
            grpRoomInformation.PerformLayout();
            grpAdditionalCharges.ResumeLayout(false);
            grpAdditionalCharges.PerformLayout();
            s.ResumeLayout(false);
            s.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDate;
        private Label lblTime;
        private Label lblDateContent;
        private Label lblTimeContent;
        private GroupBox grpRoomInformation;
        private Label lblNightlyCharge;
        private Label lblNights;
        private GroupBox grpAdditionalCharges;
        private Label lblPhone;
        private Label lblRoomService;
        private GroupBox s;
        private Button btnCalculateCharges;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtNightlyCharge;
        private TextBox txtNights;
        private TextBox txtMisc;
        private TextBox txtPhone;
        private TextBox txtRoomService;
        private Label lblMisc;
        private TextBox txtTotalCharges;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private TextBox txtAdditionalCharges;
        private TextBox txtRoomCharges;
        private Label lblTotalCharges;
        private Label lblTax;
        private Label lblSubtotal;
        private Label lblAdditionalCharges;
        private Label lblRoomCharges;
    }
}
