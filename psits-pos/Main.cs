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

                try {
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
                            MessageBox.Show("Insufficient payment!" + "\n" + ex);
                            invoiceAmtPaid_txt.Clear();
                        }
                    }

                } catch (Exception ex) {
                    MessageBox.Show("Enter payment!" + "\n" + ex);
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

        //store into db from student information
        public void storeStudentInfo() 
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql1 = "SELECT * FROM student_info_file";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql1, thisConnection);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(thisAdapter);
            thisConnection.Open();
            DataSet thisSet = new DataSet();
            thisAdapter.Fill(thisSet, "student_info_file");
            DataRow thisRow = thisSet.Tables["student_info_file"].NewRow();

            try
            {
                thisRow["stud_idNUm"] = studIdNum_txt.Text;
                thisRow["stud_invoiceCode"] = invoiceCode_txt.Text;
                thisRow["stud_lastName"] = studLN_txt.Text;
                thisRow["stud_firstName"] = studFN_txt.Text;
                thisRow["stud_course"] = studCourse_cb.Text;
                thisRow["stud_year"] = studYear_cb.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter student information!" + "\n" + ex);
            }

            thisConnection.Close();
        }

        //store into db from student information
        public void storeInvoiceInfo() 
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql2 = "SELECT * FROM invoice_info_file";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql2, thisConnection);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(thisAdapter);
            thisConnection.Open();
            DataSet thisSet = new DataSet();
            thisAdapter.Fill(thisSet, "invoice_info_file");
            DataRow thisRow = thisSet.Tables["invoice_info_file"].NewRow();

            try
            {
                thisRow["invoice_code"] = invoiceCode_txt.Text;
                thisRow["invoice_date"] = invoiceDate_dtp.Value;
                thisRow["invoice_studName"] = studFN_txt.Text + " " + studLN_txt.Text;
                thisRow["invoice_type"] = paymentFor_cb.Text;
                thisRow["invoice_amount"] = invoiceAmount_txt.Text;
                thisRow["invoice_amountPaid"] = invoiceAmtPaid_txt.Text;
                thisRow["invoice_amountTotal"] = invoiceTotal_txt.Text;
                thisRow["invoice_change"] = invoiceChange_txt.Text;
                thisRow["invoice_oic"] = oic_cb.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter invoice information!" + "\n" + ex);
            }

            thisConnection.Close();
        }
        //displays info in table
        public void displayTable() {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            //to display in table
            bool found = false;
            string invoiceCode = "";
            string invoiceDate = "";
            string studentName = "";
            string paymentType = "";
            string totalAmount = "";
            string officeInCharge = "";

            string sql3 = "SELECT * FROM invoice_info_file WHERE invoice_code = '" + invoiceCode_txt.Text + "'";

            OleDbCommand thisCommand = new OleDbCommand(sql3, thisConnection);
            thisConnection.Open();
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                if (thisReader["invoice_code"].ToString().Trim() == invoiceCode_txt.Text.Trim())
                {
                    found = true;
                    invoiceCode = thisReader["invoice_code"].ToString();
                    invoiceDate = thisReader["invoice_date"].ToString();
                    studentName = thisReader["invoice_studName"].ToString();
                    paymentType = thisReader["invoice_type"].ToString();
                    totalAmount = thisReader["invoice_amountTotal"].ToString();
                    officeInCharge = thisReader["invoice_oic"].ToString();
                    break;
                }
            }
            int r = invoiceHistory_table.Rows.Add();
            if (found == true)
            {
                invoiceHistory_table.Rows[r].Cells["h_invoiceCode"].Value = invoiceCode;
                invoiceHistory_table.Rows[r].Cells["h_invoiceDate"].Value = invoiceDate;
                invoiceHistory_table.Rows[r].Cells["h_studentName"].Value = studentName;
                invoiceHistory_table.Rows[r].Cells["h_paymentType"].Value = paymentType;
                invoiceHistory_table.Rows[r].Cells["h_totalAmount"].Value = totalAmount;
                invoiceHistory_table.Rows[r].Cells["h_oic"].Value = officeInCharge;
            }
            else
            {
                MessageBox.Show("Invoice code not found!");
            }

            thisConnection.Close();
            thisReader.Close();
        }

        //checks for duplicate entries
        public void checkDupeInvoice() {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string sql4 = "SELECT * FROM invoice_info_file";

            OleDbCommand thisCommand = new OleDbCommand(sql4, thisConnection);
            thisConnection.Open();

            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql4, thisConnection);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(thisAdapter);

            DataSet thisSet = new DataSet();
            thisAdapter.Fill(thisSet, "invoice_info_file");
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            DataRow thisRow = thisSet.Tables["invoice_info_file"].NewRow();
            try
            {
                thisRow["invoice_code"] = invoiceCode_txt.Text;
                thisRow["invoice_date"] = invoiceDate_dtp.Value;
                thisRow["invoice_studName"] = studFN_txt.Text + " " + studLN_txt.Text;
                thisRow["invoice_type"] = paymentFor_cb.Text;
                thisRow["invoice_amount"] = invoiceAmount_txt.Text;
                thisRow["invoice_amountPaid"] = invoiceAmtPaid_txt.Text;
                thisRow["invoice_amountTotal"] = invoiceTotal_txt.Text;
                thisRow["invoice_change"] = invoiceChange_txt.Text;
                thisRow["invoice_oic"] = oic_cb.Text;
                thisSet.Tables["invoice_info_file"].Rows.Add(thisRow);
                thisAdapter.Update(thisSet, "invoice_info_file");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicate Entries!" + "\n" + ex);
            }

            thisConnection.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            storeStudentInfo();
            storeInvoiceInfo();
            displayTable();
            
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
            studIdNum_txt.Clear();
            studFN_txt.Clear();
            studLN_txt.Clear();
            studCourse_cb.SelectedIndex = -1;
            studYear_cb.SelectedIndex = -1;
            officer_check.Checked = false;

            //invoice info clear
            invoiceCode_txt.Clear();
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