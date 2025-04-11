using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontapkiemtracuoiki
{
    public partial class Dinhdang : Form
    {
        public Dinhdang()
        {
            InitializeComponent();
        }
  
        private void Dinhdang_Load(object sender, EventArgs e)
        {

        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtnhapten.Text; 
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRED":
                    lblLaptrinh.ForeColor = Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    break;
                case "radGREEN":
                    {
                        lblLaptrinh.ForeColor= Color.Green;
                        txtnhapten.ForeColor= Color.Green;
                        break;
                    }
                case "radBLUE":
                    {
                        lblLaptrinh.ForeColor=Color.Blue;
                        txtnhapten.ForeColor=Color.Blue;
                        break;
                    }
           
            }   
        }
    }
}
