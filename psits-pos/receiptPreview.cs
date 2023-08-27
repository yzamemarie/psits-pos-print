using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace psits_pos
{
    public partial class receiptPreview : Form
    {
        PrintDocument pd;
        PrintPreviewDialog ppd;
        int receiptLength;
        public receiptPreview()
        {
            InitializeComponent();
        }

        public void changeReceiptLength() { 
            int rowCount = 0;
            receiptLength = 0;

            //rowCount = DataGridView.Rows.Count;
            receiptLength = rowCount * 15;
            receiptLength = receiptLength + 500;

        }

        //prints receipt 
        private void print_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
