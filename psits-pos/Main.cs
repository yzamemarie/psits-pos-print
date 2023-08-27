using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psits_pos
{
    public partial class Main : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Desktop\psits-pos\psits_pos_db.accdb";

        public Main()
        {
            InitializeComponent();
            //calculateMerch();
            //calculateMerchDiscount();
        }

        private void invoiceAmtPaid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool found = false;

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
                else
                {
                    calculateMerch();
                    priceAmt = Double.Parse(invoiceAmount_txt.Text);
                    invoiceTotal_txt.Text = Math.Round(priceAmt, 2).ToString(); //total price without discounts
                }

                //grandtotal is the value taken from "Total" textbox regardless discounted or not
                grandTotal = Double.Parse(invoiceTotal_txt.Text);

                if (invoiceAmtPaid_txt.Text != null)
                {

                    try
                    {
                        paid = Int32.Parse(invoiceAmtPaid_txt.Text);

                        if (paid >= grandTotal)
                        {
                            change = paid - grandTotal;
                            invoiceChange_txt.Text = Math.Round(change, 2).ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insufficient payment!");
                        invoiceAmtPaid_txt.Clear();
                    }
                }

                if (found == false)
                {
                    MessageBox.Show("Please Enter Amount!");
                    invoiceAmtPaid_txt.Clear();
                }
            }

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

        private void find_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            //store into db from student information
            string sql1 = "SELECT * FROM student_info_file";
            OleDbDataAdapter thisAdapter1 = new OleDbDataAdapter(sql1, thisConnection);
            OleDbCommandBuilder commandBuilder1 = new OleDbCommandBuilder(thisAdapter1);
            DataSet thisSet1 = new DataSet();
            thisAdapter1.Fill(thisSet1, "student_info_file");
            DataRow thisRow1 = thisSet1.Tables["student_info_file"].NewRow();

            try
            {
                thisRow1["stud_idNUm"] = studIdNum_txt.Text;
                thisRow1["stud_lastName"] = studLN_txt.Text;
                thisRow1["stud_firstName"] = studFN_txt.Text;
                thisRow1["stud_course"] = studCourse_cb.Text;
                thisRow1["stud_year"] = studYear_cb.Text;

                if (officer_check.Checked)
                {
                    thisRow1["stud_type"] = "Officer";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter student information!");
            }

            //store into db from student information
            string sql2 = "SELECT * FROM invoice_info_file";
            OleDbDataAdapter thisAdapter2 = new OleDbDataAdapter(sql1, thisConnection);
            OleDbCommandBuilder commandBuilder2 = new OleDbCommandBuilder(thisAdapter2);
            DataSet thisSet2 = new DataSet();
            thisAdapter1.Fill(thisSet2, "invoice_info_file");
            DataRow thisRow2 = thisSet2.Tables["invoice_info_file"].NewRow();

            try
            {
                thisRow2["invoice_code"] = generateInvoiceCode();
                thisRow2["invoice_date"] = invoiceDate_dtp.Value;
                thisRow2["invoice_type"] = paymentFor_cb.Text;
                thisRow2["invoice_amount"] = invoiceAmount_txt.Text;
                thisRow2["invoice_amountPaid"] = invoiceAmtPaid_txt.Text;
                thisRow2["invoice_amountTotal"] = invoiceTotal_txt.Text;
                thisRow2["invoice_change"] = invoiceChange_txt.Text;
                thisRow2["invoice_oic"] = oic_cb.Text;

                if (officer_check.Checked)
                {
                    thisRow1["invoice_discount"] = "Yes";
                }
                else
                {
                    thisRow1["invoice_discount"] = "No";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter invoice information!");
            }

            thisConnection.Close();
        }

        //previews receipt after entering information
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

        public string generateInvoiceCode() {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder invoiceCode = new StringBuilder();

            for (int i = 0; i < chars.Length; i++)
            {
                int randomIndex = random.Next(chars.Length);
                char randomChar = chars[randomIndex];
                invoiceCode.Append(randomChar);
            }

            return invoiceCode.ToString();
        }

    }
}