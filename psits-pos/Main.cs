using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace psits_pos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            calculateMerch();
            calculateMerchDiscount();
        }

        private void paymentFor_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkbox only enabled if selected item is "merchandise"
            if (paymentFor_cb.SelectedIndex == 1) {
                lanyard_check.Enabled = true;
                polo_check.Enabled = true;
                shirt_check.Enabled = true;
                hoodieBlack_check.Enabled = true;
                hoodieWhite_check.Enabled = true;
                totebag1_check.Enabled = true;
                totebag2_check.Enabled = true;

            } 
        }

        public int calculateMerch() {
            int price = 0;

            //cummulative price for every item checked
            if (lanyard_check.Checked) {
                price += 125;

            } if (polo_check.Checked) {
                price += 459;

            } if (shirt_check.Checked) {
                price = 285;
            
            } if (hoodieBlack_check.Checked) {
                price += 785;
            
            } if (hoodieWhite_check.Checked) {
                price += 785;
                
            } if (totebag1_check.Checked) {
                price += 199;
            
            } if (totebag2_check.Checked) {
                price += 199;
            } 

            invoiceAmount_txt.Text = price.ToString();

            return price;
        }

        public double calculateMerchDiscount() {
            double discount = 0;

            //cummulative price for every item checked
            //officer discount of 50% per item
            if (lanyard_check.Checked) {
                discount += 125 * 0.5;

            } if (polo_check.Checked) {
                discount += 459 * 0.5;

            } if (shirt_check.Checked) {
                discount += 285 * 0.5;

            } if (hoodieBlack_check.Checked) {
                discount += 785 * 0.5;

            } if (hoodieWhite_check.Checked) {
                discount += 785 * 0.5;

            } if (totebag1_check.Checked) {
                discount += 199 * 0.5;

            } if (totebag2_check.Checked) {
                discount += 199 * 0.5;

            }

            invoiceDiscount_txt.Text = discount.ToString();

            return Math.Round(discount, 2); //returns rounded off discount
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            int paid = 0;
            double discountedPrice = 0, totalAmtDisc = 0, change = 0, priceAmt = 0, grandTotal = 0;

            if (officer_check.Checked)
            {
                //for officer discounts
                calculateMerchDiscount();
                discountedPrice = Double.Parse(invoiceDiscount_txt.Text);
                totalAmtDisc = calculateMerch() - discountedPrice;
                invoiceTotal_txt.Text = Math.Round(totalAmtDisc, 2).ToString(); //total price after dicounts

            }
            else {
                calculateMerch();
                priceAmt = Double.Parse(invoiceAmount_txt.Text);
                invoiceTotal_txt.Text = Math.Round(priceAmt, 2).ToString(); //total price without discounts
            }

            //grandtotal is the value taken from "Total" textbox regardless discounted or not
            grandTotal = Double.Parse(invoiceTotal_txt.Text);

            if (invoiceAmtPaid_txt.Text != null) {

                try
                {
                    paid = Int32.Parse(invoiceAmtPaid_txt.Text);

                    if (paid >= grandTotal)
                    {
                        change = paid - grandTotal;
                        invoiceChange_txt.Text = Math.Round(change, 2).ToString();
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Insufficient payment!");
                    invoiceAmtPaid_txt.Clear();
                }
            } else {
                MessageBox.Show("Please Enter Amount!");
                invoiceAmtPaid_txt.Clear();
            }
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            receiptPreview preview = new receiptPreview();
            this.Hide();
            preview.ShowDialog();
            this.Show();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //clear student info
            studFN_txt.Clear();
            studLN_txt.Clear();
            studCourse_cb.SelectedIndex = -1;
            studYear_cb.SelectedIndex = -1;
            officer_check.Checked = false;

            //invoice info clear
            paymentFor_cb.SelectedIndex = -1;
            invoiceAmount_txt.Clear();
            invoiceAmtPaid_txt.Clear();
            invoiceDiscount_txt.Clear();
            invoiceTotal_txt.Clear();
            invoiceChange_txt.Clear();

            //merch checkbox clear
            lanyard_check.Checked = false;
            polo_check.Checked = false;
            shirt_check.Checked = false;
            hoodieBlack_check.Checked = false;
            hoodieWhite_check.Checked = false;
            totebag1_check.Checked = false;
            totebag1_check.Checked = false;

            //oic 
            oic_cb.SelectedIndex = -1;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clears all student and invoice info and data grid view
        private void clearAll_btn_Click(object sender, EventArgs e)
        {
            
        }

    }
}