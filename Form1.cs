using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_fromater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r=(RadioButton)sender;
            switch(r.Name)
            {
                case "radRed":
                    lbLapTrinh.ForeColor = Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lbLapTrinh.ForeColor = Color.Green;
                    txtnhapten.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lbLapTrinh.ForeColor = Color.Blue;
                    txtnhapten.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lbLapTrinh.ForeColor = Color.Black;
                    txtnhapten.ForeColor = Color.Black;
                    break;

            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r=(CheckBox)sender;    
            switch (r.Name)
            {
                case "chkBold":
                    lbLapTrinh.Font=new Font(lbLapTrinh.Font.Name,lbLapTrinh.Font.Size,lbLapTrinh.Font.Style^FontStyle.Bold);
                    break;
                case "chkNghien":
                    lbLapTrinh.Font = new Font(lbLapTrinh.Font.Name, lbLapTrinh.Font.Size, lbLapTrinh.Font.Style ^ FontStyle.Italic);
                    break;
                case "chkUnderline":
                    lbLapTrinh.Font = new Font(lbLapTrinh.Font.Name, lbLapTrinh.Font.Size, lbLapTrinh.Font.Style ^ FontStyle.Underline);
                    break;

            }
        }
    }
}
