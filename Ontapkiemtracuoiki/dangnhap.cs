using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontapkiemtracuoiki
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void hỆTHÔNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                mainform mainform = new mainform();
                this.Hide();
                mainform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("incorrect user or passwork", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            this.CancelButton = btnexit;
        }
    }
}
