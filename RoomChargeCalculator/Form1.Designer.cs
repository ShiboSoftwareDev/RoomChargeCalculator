namespace RoomChargeCalculator
{
    partial class frmRoomChargeCalculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomChargeCalculator));
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
            tmrCurrentTiime = new System.Windows.Forms.Timer(components);
            txtError = new Label();
            grpRoomInformation.SuspendLayout();
            grpAdditionalCharges.SuspendLayout();
            s.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(298, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Peace Hotel";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(252, 56);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(77, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Today's Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(292, 93);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(37, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time:";
            // 
            // lblDateContent
            // 
            lblDateContent.AutoSize = true;
            lblDateContent.Location = new Point(359, 56);
            lblDateContent.Name = "lblDateContent";
            lblDateContent.Size = new Size(31, 15);
            lblDateContent.TabIndex = 3;
            lblDateContent.Text = "Date";
            // 
            // lblTimeContent
            // 
            lblTimeContent.AutoSize = true;
            lblTimeContent.Location = new Point(359, 93);
            lblTimeContent.Name = "lblTimeContent";
            lblTimeContent.Size = new Size(34, 15);
            lblTimeContent.TabIndex = 4;
            lblTimeContent.Text = "Time";
            // 
            // grpRoomInformation
            // 
            grpRoomInformation.Controls.Add(txtNightlyCharge);
            grpRoomInformation.Controls.Add(txtNights);
            grpRoomInformation.Controls.Add(lblNightlyCharge);
            grpRoomInformation.Controls.Add(lblNights);
            grpRoomInformation.Location = new Point(37, 137);
            grpRoomInformation.Name = "grpRoomInformation";
            grpRoomInformation.Size = new Size(269, 134);
            grpRoomInformation.TabIndex = 5;
            grpRoomInformation.TabStop = false;
            grpRoomInformation.Text = "Room Information";
            // 
            // txtNightlyCharge
            // 
            txtNightlyCharge.Location = new Point(108, 69);
            txtNightlyCharge.Name = "txtNightlyCharge";
            txtNightlyCharge.Size = new Size(100, 23);
            txtNightlyCharge.TabIndex = 3;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(109, 43);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(100, 23);
            txtNights.TabIndex = 2;
            // 
            // lblNightlyCharge
            // 
            lblNightlyCharge.AutoSize = true;
            lblNightlyCharge.Location = new Point(12, 72);
            lblNightlyCharge.Name = "lblNightlyCharge";
            lblNightlyCharge.Size = new Size(90, 15);
            lblNightlyCharge.TabIndex = 1;
            lblNightlyCharge.Text = "Nightly Charge:";
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Location = new Point(57, 46);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(45, 15);
            lblNights.TabIndex = 0;
            lblNights.Text = "Nights:";
            // 
            // grpAdditionalCharges
            // 
            grpAdditionalCharges.Controls.Add(txtMisc);
            grpAdditionalCharges.Controls.Add(txtPhone);
            grpAdditionalCharges.Controls.Add(txtRoomService);
            grpAdditionalCharges.Controls.Add(lblMisc);
            grpAdditionalCharges.Controls.Add(lblPhone);
            grpAdditionalCharges.Controls.Add(lblRoomService);
            grpAdditionalCharges.Location = new Point(338, 137);
            grpAdditionalCharges.Name = "grpAdditionalCharges";
            grpAdditionalCharges.Size = new Size(248, 134);
            grpAdditionalCharges.TabIndex = 6;
            grpAdditionalCharges.TabStop = false;
            grpAdditionalCharges.Text = "Additional Charges";
            // 
            // txtMisc
            // 
            txtMisc.Location = new Point(92, 84);
            txtMisc.Name = "txtMisc";
            txtMisc.Size = new Size(100, 23);
            txtMisc.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(92, 55);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtRoomService
            // 
            txtRoomService.Location = new Point(92, 26);
            txtRoomService.Name = "txtRoomService";
            txtRoomService.Size = new Size(100, 23);
            txtRoomService.TabIndex = 3;
            // 
            // lblMisc
            // 
            lblMisc.AutoSize = true;
            lblMisc.Location = new Point(51, 87);
            lblMisc.Name = "lblMisc";
            lblMisc.Size = new Size(35, 15);
            lblMisc.TabIndex = 2;
            lblMisc.Text = "Misc:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(21, 63);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Telephone:";
            // 
            // lblRoomService
            // 
            lblRoomService.AutoSize = true;
            lblRoomService.Location = new Point(4, 35);
            lblRoomService.Name = "lblRoomService";
            lblRoomService.Size = new Size(82, 15);
            lblRoomService.TabIndex = 0;
            lblRoomService.Text = "Room Service:";
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
            s.Location = new Point(37, 308);
            s.Name = "s";
            s.Size = new Size(549, 184);
            s.TabIndex = 7;
            s.TabStop = false;
            s.Text = "Total Charges";
            // 
            // txtTotalCharges
            // 
            txtTotalCharges.Location = new Point(293, 146);
            txtTotalCharges.Name = "txtTotalCharges";
            txtTotalCharges.ReadOnly = true;
            txtTotalCharges.Size = new Size(100, 23);
            txtTotalCharges.TabIndex = 9;
            txtTotalCharges.TabStop = false;
            txtTotalCharges.Text = "$0.00";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(293, 117);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 1;
            txtTax.TabStop = false;
            txtTax.Text = "$0.00";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(293, 88);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 5;
            txtSubtotal.TabStop = false;
            txtSubtotal.Text = "$0.00";
            // 
            // txtAdditionalCharges
            // 
            txtAdditionalCharges.Location = new Point(293, 59);
            txtAdditionalCharges.Name = "txtAdditionalCharges";
            txtAdditionalCharges.ReadOnly = true;
            txtAdditionalCharges.Size = new Size(100, 23);
            txtAdditionalCharges.TabIndex = 4;
            txtAdditionalCharges.TabStop = false;
            txtAdditionalCharges.Text = "$0.00";
            // 
            // txtRoomCharges
            // 
            txtRoomCharges.Location = new Point(293, 30);
            txtRoomCharges.Name = "txtRoomCharges";
            txtRoomCharges.ReadOnly = true;
            txtRoomCharges.Size = new Size(100, 23);
            txtRoomCharges.TabIndex = 3;
            txtRoomCharges.TabStop = false;
            txtRoomCharges.Text = "$0.00";
            // 
            // lblTotalCharges
            // 
            lblTotalCharges.AutoSize = true;
            lblTotalCharges.Location = new Point(181, 154);
            lblTotalCharges.Name = "lblTotalCharges";
            lblTotalCharges.Size = new Size(82, 15);
            lblTotalCharges.TabIndex = 4;
            lblTotalCharges.Text = "Total Charges:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(242, 120);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 3;
            lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(215, 91);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblAdditionalCharges
            // 
            lblAdditionalCharges.AutoSize = true;
            lblAdditionalCharges.Location = new Point(158, 62);
            lblAdditionalCharges.Name = "lblAdditionalCharges";
            lblAdditionalCharges.Size = new Size(111, 15);
            lblAdditionalCharges.TabIndex = 1;
            lblAdditionalCharges.Text = "Additional Charges:";
            // 
            // lblRoomCharges
            // 
            lblRoomCharges.AutoSize = true;
            lblRoomCharges.Location = new Point(181, 33);
            lblRoomCharges.Name = "lblRoomCharges";
            lblRoomCharges.Size = new Size(88, 15);
            lblRoomCharges.TabIndex = 0;
            lblRoomCharges.Text = "Room Charges:";
            // 
            // btnCalculateCharges
            // 
            btnCalculateCharges.Location = new Point(125, 498);
            btnCalculateCharges.Name = "btnCalculateCharges";
            btnCalculateCharges.Size = new Size(120, 23);
            btnCalculateCharges.TabIndex = 8;
            btnCalculateCharges.Text = "Calculate Charges";
            btnCalculateCharges.UseVisualStyleBackColor = true;
            btnCalculateCharges.Click += btnCalculateCharges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(279, 498);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(389, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tmrCurrentTiime
            // 
            tmrCurrentTiime.Enabled = true;
            tmrCurrentTiime.Interval = 1000;
            tmrCurrentTiime.Tick += timer1_Tick;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.ForeColor = Color.IndianRed;
            txtError.Location = new Point(223, 281);
            txtError.Name = "txtError";
            txtError.Size = new Size(0, 15);
            txtError.TabIndex = 11;
            // 
            // frmRoomChargeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(645, 543);
            Controls.Add(txtError);
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
            Name = "frmRoomChargeCalculator";
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
        private System.Windows.Forms.Timer tmrCurrentTiime;
        private Label txtError;
    }
}
