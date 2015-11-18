using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marks
{
    public partial class frmMarks : Form
    {
        int total = 0;
        int numberOfNumbers = 0;
        public frmMarks()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            numberOfNumbers = numberOfNumbers + 1;
            total = total + Convert.ToInt32(txtEnter.Text);
            lstMarks.Items.Add(Convert.ToInt32(txtEnter.Text));
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            this.lblAverage.Text = "The Average is: " + Convert.ToString(total / numberOfNumbers);
        }
    }
}
