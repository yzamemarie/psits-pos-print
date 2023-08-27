namespace psits_pos
{
    partial class receiptPreview
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
            this.print_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(29, 366);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(200, 44);
            this.print_btn.TabIndex = 7;
            this.print_btn.Text = "PRINT RECEIPT";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 8;
            // 
            // receiptPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.print_btn);
            this.Name = "receiptPreview";
            this.Text = "PSITS-B POS -- RECEIPT PREVIEW";
            this.ResumeLayout(false);

        }

        #endregion

        private Button print_btn;
        private Panel panel1;
    }
}