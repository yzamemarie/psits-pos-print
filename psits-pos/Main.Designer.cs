namespace psits_pos
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studInfo_groupbox = new System.Windows.Forms.GroupBox();
            this.studType_check = new System.Windows.Forms.CheckBox();
            this.studYear_cb = new System.Windows.Forms.ComboBox();
            this.studYear_lbl = new System.Windows.Forms.Label();
            this.studCourse_cb = new System.Windows.Forms.ComboBox();
            this.studCourse_lbl = new System.Windows.Forms.Label();
            this.studLN_txt = new System.Windows.Forms.TextBox();
            this.studLN_lbl = new System.Windows.Forms.Label();
            this.studFN_txt = new System.Windows.Forms.TextBox();
            this.studFN_lbl = new System.Windows.Forms.Label();
            this.invoiceBox_groupbox = new System.Windows.Forms.GroupBox();
            this.invoiceChange_lbl = new System.Windows.Forms.Label();
            this.invoiceChange_txt = new System.Windows.Forms.TextBox();
            this.invoiceTotal_txt = new System.Windows.Forms.TextBox();
            this.invoiceTotal_lbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.invoiceDiscount_txt = new System.Windows.Forms.TextBox();
            this.invoiceDiscount_lbl = new System.Windows.Forms.Label();
            this.invoiceAmtPaid_txt = new System.Windows.Forms.TextBox();
            this.invoiceAmtPaid_lbl = new System.Windows.Forms.Label();
            this.invoiceAmount_txt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentType_lbl = new System.Windows.Forms.Label();
            this.invoiceDate_lbl = new System.Windows.Forms.Label();
            this.invoiceDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.preview_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.clearAll_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.invoiceHistory_dgv = new System.Windows.Forms.DataGridView();
            this.invoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studInfo_groupbox.SuspendLayout();
            this.invoiceBox_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceHistory_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Code :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(113, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 23);
            this.textBox1.TabIndex = 1;
            // 
            // studInfo_groupbox
            // 
            this.studInfo_groupbox.Controls.Add(this.studType_check);
            this.studInfo_groupbox.Controls.Add(this.studYear_cb);
            this.studInfo_groupbox.Controls.Add(this.studYear_lbl);
            this.studInfo_groupbox.Controls.Add(this.studCourse_cb);
            this.studInfo_groupbox.Controls.Add(this.studCourse_lbl);
            this.studInfo_groupbox.Controls.Add(this.studLN_txt);
            this.studInfo_groupbox.Controls.Add(this.studLN_lbl);
            this.studInfo_groupbox.Controls.Add(this.studFN_txt);
            this.studInfo_groupbox.Controls.Add(this.studFN_lbl);
            this.studInfo_groupbox.Location = new System.Drawing.Point(17, 57);
            this.studInfo_groupbox.Name = "studInfo_groupbox";
            this.studInfo_groupbox.Size = new System.Drawing.Size(361, 154);
            this.studInfo_groupbox.TabIndex = 2;
            this.studInfo_groupbox.TabStop = false;
            this.studInfo_groupbox.Text = "Student Information";
            // 
            // studType_check
            // 
            this.studType_check.AutoSize = true;
            this.studType_check.Location = new System.Drawing.Point(266, 88);
            this.studType_check.Name = "studType_check";
            this.studType_check.Size = new System.Drawing.Size(62, 19);
            this.studType_check.TabIndex = 10;
            this.studType_check.Text = "Officer";
            this.studType_check.UseVisualStyleBackColor = true;
            // 
            // studYear_cb
            // 
            this.studYear_cb.FormattingEnabled = true;
            this.studYear_cb.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "ACT"});
            this.studYear_cb.Location = new System.Drawing.Point(99, 116);
            this.studYear_cb.Name = "studYear_cb";
            this.studYear_cb.Size = new System.Drawing.Size(143, 23);
            this.studYear_cb.TabIndex = 9;
            // 
            // studYear_lbl
            // 
            this.studYear_lbl.AutoSize = true;
            this.studYear_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studYear_lbl.Location = new System.Drawing.Point(53, 118);
            this.studYear_lbl.Name = "studYear_lbl";
            this.studYear_lbl.Size = new System.Drawing.Size(40, 17);
            this.studYear_lbl.TabIndex = 8;
            this.studYear_lbl.Text = "Year :";
            // 
            // studCourse_cb
            // 
            this.studCourse_cb.FormattingEnabled = true;
            this.studCourse_cb.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "ACT"});
            this.studCourse_cb.Location = new System.Drawing.Point(99, 85);
            this.studCourse_cb.Name = "studCourse_cb";
            this.studCourse_cb.Size = new System.Drawing.Size(143, 23);
            this.studCourse_cb.TabIndex = 7;
            // 
            // studCourse_lbl
            // 
            this.studCourse_lbl.AutoSize = true;
            this.studCourse_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studCourse_lbl.Location = new System.Drawing.Point(37, 88);
            this.studCourse_lbl.Name = "studCourse_lbl";
            this.studCourse_lbl.Size = new System.Drawing.Size(56, 17);
            this.studCourse_lbl.TabIndex = 6;
            this.studCourse_lbl.Text = "Course :";
            // 
            // studLN_txt
            // 
            this.studLN_txt.Location = new System.Drawing.Point(99, 53);
            this.studLN_txt.Name = "studLN_txt";
            this.studLN_txt.Size = new System.Drawing.Size(242, 23);
            this.studLN_txt.TabIndex = 5;
            // 
            // studLN_lbl
            // 
            this.studLN_lbl.AutoSize = true;
            this.studLN_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studLN_lbl.Location = new System.Drawing.Point(15, 56);
            this.studLN_lbl.Name = "studLN_lbl";
            this.studLN_lbl.Size = new System.Drawing.Size(77, 17);
            this.studLN_lbl.TabIndex = 4;
            this.studLN_lbl.Text = "Last Name :";
            // 
            // studFN_txt
            // 
            this.studFN_txt.Location = new System.Drawing.Point(99, 22);
            this.studFN_txt.Name = "studFN_txt";
            this.studFN_txt.Size = new System.Drawing.Size(242, 23);
            this.studFN_txt.TabIndex = 3;
            // 
            // studFN_lbl
            // 
            this.studFN_lbl.AutoSize = true;
            this.studFN_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studFN_lbl.Location = new System.Drawing.Point(15, 25);
            this.studFN_lbl.Name = "studFN_lbl";
            this.studFN_lbl.Size = new System.Drawing.Size(78, 17);
            this.studFN_lbl.TabIndex = 2;
            this.studFN_lbl.Text = "First Name :";
            // 
            // invoiceBox_groupbox
            // 
            this.invoiceBox_groupbox.Controls.Add(this.invoiceChange_lbl);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceChange_txt);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceTotal_txt);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceTotal_lbl);
            this.invoiceBox_groupbox.Controls.Add(this.progressBar1);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceDiscount_txt);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceDiscount_lbl);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceAmtPaid_txt);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceAmtPaid_lbl);
            this.invoiceBox_groupbox.Controls.Add(this.invoiceAmount_txt);
            this.invoiceBox_groupbox.Controls.Add(this.comboBox1);
            this.invoiceBox_groupbox.Controls.Add(this.paymentType_lbl);
            this.invoiceBox_groupbox.Location = new System.Drawing.Point(17, 232);
            this.invoiceBox_groupbox.Name = "invoiceBox_groupbox";
            this.invoiceBox_groupbox.Size = new System.Drawing.Size(361, 257);
            this.invoiceBox_groupbox.TabIndex = 3;
            this.invoiceBox_groupbox.TabStop = false;
            this.invoiceBox_groupbox.Text = "Invoice Information";
            // 
            // invoiceChange_lbl
            // 
            this.invoiceChange_lbl.AutoSize = true;
            this.invoiceChange_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invoiceChange_lbl.Location = new System.Drawing.Point(69, 219);
            this.invoiceChange_lbl.Name = "invoiceChange_lbl";
            this.invoiceChange_lbl.Size = new System.Drawing.Size(71, 17);
            this.invoiceChange_lbl.TabIndex = 23;
            this.invoiceChange_lbl.Text = "Change : ₱";
            // 
            // invoiceChange_txt
            // 
            this.invoiceChange_txt.Enabled = false;
            this.invoiceChange_txt.Location = new System.Drawing.Point(146, 216);
            this.invoiceChange_txt.Name = "invoiceChange_txt";
            this.invoiceChange_txt.Size = new System.Drawing.Size(141, 23);
            this.invoiceChange_txt.TabIndex = 22;
            // 
            // invoiceTotal_txt
            // 
            this.invoiceTotal_txt.Enabled = false;
            this.invoiceTotal_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.invoiceTotal_txt.Location = new System.Drawing.Point(146, 184);
            this.invoiceTotal_txt.Name = "invoiceTotal_txt";
            this.invoiceTotal_txt.Size = new System.Drawing.Size(141, 24);
            this.invoiceTotal_txt.TabIndex = 20;
            // 
            // invoiceTotal_lbl
            // 
            this.invoiceTotal_lbl.AutoSize = true;
            this.invoiceTotal_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.invoiceTotal_lbl.Location = new System.Drawing.Point(83, 187);
            this.invoiceTotal_lbl.Name = "invoiceTotal_lbl";
            this.invoiceTotal_lbl.Size = new System.Drawing.Size(57, 17);
            this.invoiceTotal_lbl.TabIndex = 19;
            this.invoiceTotal_lbl.Text = "Total : ₱";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(37, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 10);
            this.progressBar1.TabIndex = 18;
            // 
            // invoiceDiscount_txt
            // 
            this.invoiceDiscount_txt.Enabled = false;
            this.invoiceDiscount_txt.Location = new System.Drawing.Point(146, 133);
            this.invoiceDiscount_txt.Name = "invoiceDiscount_txt";
            this.invoiceDiscount_txt.Size = new System.Drawing.Size(141, 23);
            this.invoiceDiscount_txt.TabIndex = 17;
            // 
            // invoiceDiscount_lbl
            // 
            this.invoiceDiscount_lbl.AutoSize = true;
            this.invoiceDiscount_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invoiceDiscount_lbl.Location = new System.Drawing.Point(63, 136);
            this.invoiceDiscount_lbl.Name = "invoiceDiscount_lbl";
            this.invoiceDiscount_lbl.Size = new System.Drawing.Size(77, 17);
            this.invoiceDiscount_lbl.TabIndex = 16;
            this.invoiceDiscount_lbl.Text = "Discount : ₱";
            // 
            // invoiceAmtPaid_txt
            // 
            this.invoiceAmtPaid_txt.Location = new System.Drawing.Point(146, 101);
            this.invoiceAmtPaid_txt.Name = "invoiceAmtPaid_txt";
            this.invoiceAmtPaid_txt.Size = new System.Drawing.Size(141, 23);
            this.invoiceAmtPaid_txt.TabIndex = 15;
            // 
            // invoiceAmtPaid_lbl
            // 
            this.invoiceAmtPaid_lbl.AutoSize = true;
            this.invoiceAmtPaid_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invoiceAmtPaid_lbl.Location = new System.Drawing.Point(88, 104);
            this.invoiceAmtPaid_lbl.Name = "invoiceAmtPaid_lbl";
            this.invoiceAmtPaid_lbl.Size = new System.Drawing.Size(52, 17);
            this.invoiceAmtPaid_lbl.TabIndex = 14;
            this.invoiceAmtPaid_lbl.Text = "Paid : ₱";
            // 
            // invoiceAmount_txt
            // 
            this.invoiceAmount_txt.Enabled = false;
            this.invoiceAmount_txt.Location = new System.Drawing.Point(146, 69);
            this.invoiceAmount_txt.Name = "invoiceAmount_txt";
            this.invoiceAmount_txt.Size = new System.Drawing.Size(141, 23);
            this.invoiceAmount_txt.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Membership Fee (1st sem)",
            "Merchandise",
            "Intramurals Shirt"});
            this.comboBox1.Location = new System.Drawing.Point(106, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // paymentType_lbl
            // 
            this.paymentType_lbl.AutoSize = true;
            this.paymentType_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentType_lbl.Location = new System.Drawing.Point(15, 27);
            this.paymentType_lbl.Name = "paymentType_lbl";
            this.paymentType_lbl.Size = new System.Drawing.Size(85, 17);
            this.paymentType_lbl.TabIndex = 4;
            this.paymentType_lbl.Text = "Payment for :";
            // 
            // invoiceDate_lbl
            // 
            this.invoiceDate_lbl.AutoSize = true;
            this.invoiceDate_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invoiceDate_lbl.Location = new System.Drawing.Point(388, 19);
            this.invoiceDate_lbl.Name = "invoiceDate_lbl";
            this.invoiceDate_lbl.Size = new System.Drawing.Size(42, 17);
            this.invoiceDate_lbl.TabIndex = 4;
            this.invoiceDate_lbl.Text = "Date :";
            // 
            // invoiceDate_dtp
            // 
            this.invoiceDate_dtp.Location = new System.Drawing.Point(436, 16);
            this.invoiceDate_dtp.Name = "invoiceDate_dtp";
            this.invoiceDate_dtp.Size = new System.Drawing.Size(200, 23);
            this.invoiceDate_dtp.TabIndex = 5;
            // 
            // preview_btn
            // 
            this.preview_btn.Location = new System.Drawing.Point(17, 541);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(176, 32);
            this.preview_btn.TabIndex = 6;
            this.preview_btn.Text = "PREVIEW PRINT";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Officer-in-Charge :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mary Therese Colina",
            "Vhea Therese Valmoria",
            "Joshua Jakosalem",
            "Sherwill Mae Alivio",
            "Dean Barquio",
            "Tricia Doria",
            "Jashmine Verdida",
            "Ken Angelo Ardiente",
            "Eman Bryndt Baliong",
            "---1st Year Rep---",
            "Alexis Joseph Tan",
            "Daniel Stephen Alvarez",
            "Ysabel Marie Colina"});
            this.comboBox2.Location = new System.Drawing.Point(139, 498);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 23);
            this.comboBox2.TabIndex = 24;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(199, 541);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(179, 32);
            this.search_btn.TabIndex = 25;
            this.search_btn.Text = "SEARCH INVOICES";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // clearAll_btn
            // 
            this.clearAll_btn.Location = new System.Drawing.Point(139, 583);
            this.clearAll_btn.Name = "clearAll_btn";
            this.clearAll_btn.Size = new System.Drawing.Size(116, 32);
            this.clearAll_btn.TabIndex = 26;
            this.clearAll_btn.Text = "CLEAR ALL";
            this.clearAll_btn.UseVisualStyleBackColor = true;
            this.clearAll_btn.Click += new System.EventHandler(this.clearAll_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(17, 583);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(116, 32);
            this.clear_btn.TabIndex = 27;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(262, 583);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(116, 32);
            this.exit_btn.TabIndex = 28;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // invoiceHistory_dgv
            // 
            this.invoiceHistory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceHistory_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceCode,
            this.lastName,
            this.firstName,
            this.paymentType,
            this.totalAmount,
            this.officerInCharge});
            this.invoiceHistory_dgv.Location = new System.Drawing.Point(388, 61);
            this.invoiceHistory_dgv.Name = "invoiceHistory_dgv";
            this.invoiceHistory_dgv.RowTemplate.Height = 25;
            this.invoiceHistory_dgv.Size = new System.Drawing.Size(611, 554);
            this.invoiceHistory_dgv.TabIndex = 29;
            // 
            // invoiceCode
            // 
            this.invoiceCode.HeaderText = "Invoice Code";
            this.invoiceCode.Name = "invoiceCode";
            this.invoiceCode.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // paymentType
            // 
            this.paymentType.HeaderText = "Payment Type";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "Total";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // officerInCharge
            // 
            this.officerInCharge.HeaderText = "OIC";
            this.officerInCharge.Name = "officerInCharge";
            this.officerInCharge.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.invoiceHistory_dgv);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.clearAll_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.invoiceDate_dtp);
            this.Controls.Add(this.invoiceDate_lbl);
            this.Controls.Add(this.invoiceBox_groupbox);
            this.Controls.Add(this.studInfo_groupbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "PSITS-B POS UWU";
            this.studInfo_groupbox.ResumeLayout(false);
            this.studInfo_groupbox.PerformLayout();
            this.invoiceBox_groupbox.ResumeLayout(false);
            this.invoiceBox_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceHistory_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox studInfo_groupbox;
        private CheckBox studType_check;
        private ComboBox studYear_cb;
        private Label studYear_lbl;
        private ComboBox studCourse_cb;
        private Label studCourse_lbl;
        private TextBox studLN_txt;
        private Label studLN_lbl;
        private TextBox studFN_txt;
        private Label studFN_lbl;
        private GroupBox invoiceBox_groupbox;
        private Label invoiceDate_lbl;
        private DateTimePicker invoiceDate_dtp;
        private ComboBox comboBox1;
        private Label paymentType_lbl;
        private TextBox invoiceAmount_txt;
        private TextBox invoiceAmtPaid_txt;
        private Label invoiceAmtPaid_lbl;
        private ProgressBar progressBar1;
        private TextBox invoiceDiscount_txt;
        private Label invoiceDiscount_lbl;
        private TextBox invoiceTotal_txt;
        private Label invoiceTotal_lbl;
        private TextBox invoiceChange_txt;
        private Label invoiceChange_lbl;
        private Button preview_btn;
        private Label label2;
        private ComboBox comboBox2;
        private Button search_btn;
        private Button clearAll_btn;
        private Button clear_btn;
        private Button exit_btn;
        private DataGridView invoiceHistory_dgv;
        private DataGridViewTextBoxColumn invoiceCode;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn paymentType;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn officerInCharge;
    }
}