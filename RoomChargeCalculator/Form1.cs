using System.Xml;

namespace RoomChargeCalculator
{
    public partial class frmRoomChargeCalculator : Form
    {
        private double taxPercent = 0.1;
        private string doubleToDollar(double Input){
            return "$" + Input.ToString("0.00");
        }
        private double additionalCharge = 0;
        private double roomCharge = 0;
        private double tax = 0;
        private double subTotal = 0;
        private double total = 0;
        private Color oldColor;
        public frmRoomChargeCalculator()
        {
            InitializeComponent();
            lblTimeContent.Text = DateTime.Now.ToLongTimeString();
            lblDateContent.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.ToLongDateString();
            oldColor = txtRoomCharges.BackColor;
            this.KeyPreview = true; 
            this.KeyDown += new KeyEventHandler(frmRoomChargeCalculator_keyDown);
        }
   

        private void frmRoomChargeCalculator_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculateCharges.PerformClick();
                e.Handled = true; 
            }
        }

        private void btnCalculateCharges_Click(object sender, EventArgs e)
        {
            bool valid = false;
            try
            {
                double nights = double.Parse(txtNights.Text);
                double nightlyCharge = double.Parse(txtNightlyCharge.Text);
                double roomCharges = nights * nightlyCharge;
                txtRoomCharges.Text = doubleToDollar(roomCharges);
                this.roomCharge = roomCharges;
                txtRoomCharges.BackColor = Color.LightGreen;
                valid = true;
            }
            catch (Exception ex)
            {
                txtRoomCharges.Text = doubleToDollar(0);
                txtRoomCharges.BackColor = Color.IndianRed;
                this.roomCharge = 0;
                txtError.Text = "Please Fill in the room information correctly" + '\n';
            }
            finally
            {
            }
            try
            {
                double phone = double.Parse(txtPhone.Text);
                double misc = double.Parse(txtMisc.Text);
                double roomServie = double.Parse(txtRoomService.Text);
                txtAdditionalCharges.Text = doubleToDollar(phone + misc + roomServie);
                txtAdditionalCharges.BackColor = Color.LightGreen;
                this.additionalCharge = phone + misc + roomServie;
            }
            catch (Exception ex)
            {
                //txtAdditionalCharges.Text = doubleToDollar(0);
                //txtAdditionalCharges.BackColor = Color.IndianRed;
                this.additionalCharge = 0;
                //txtError.Text = "Please fill in additional charges currectly" + '\n';
            }
            if (valid)
                txtError.Text = "";
            this.subTotal = this.roomCharge + this.additionalCharge;
            txtSubtotal.Text = doubleToDollar(this.subTotal);
            this.tax = this.subTotal * this.taxPercent;
            txtTax.Text = doubleToDollar(this.tax);
            this.total = this.subTotal + this.tax;
            txtTotalCharges.Text = doubleToDollar(total);

        }

        private void resetDollars(Control control)
        {
            control.Text = doubleToDollar(0);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNights.Text = "";
            txtNightlyCharge.Text = "";
            txtPhone.Text = "";
            txtMisc.Text = "";
            txtRoomService.Text = "";

            resetDollars(txtRoomCharges);
            resetDollars(txtAdditionalCharges);
            resetDollars(txtSubtotal);
            resetDollars(txtTax);
            resetDollars(txtTotalCharges);

            txtRoomCharges.BackColor = this.oldColor;
            //txtAdditionalCharges.BackColor = this.oldColor;

            this.roomCharge = 0;
            this.additionalCharge = 0;
            this.subTotal = 0;
            this.tax = 0;
            this.total = 0;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeContent.Text = DateTime.Now.ToLongTimeString();
            lblDateContent.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.ToLongDateString();
        }
    }
}
