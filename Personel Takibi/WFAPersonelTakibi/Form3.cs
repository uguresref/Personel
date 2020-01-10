using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace WFAPersonelTakibi
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            lblFirstName.Text = Form1.ad;
            lblLastName.Text = Form1.soyad;
            lblMail.Text = Form1.mail;
            lblBirthDate.Text = Form1.birth;
            lblAddress.Text = Form1.adres;
            lblPhone.Text = Form1.tel;

        }

        private void pcbImageUrl_Click(object sender, EventArgs e)
        {

        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
