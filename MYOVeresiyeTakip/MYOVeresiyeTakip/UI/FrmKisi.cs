using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYOVeresiyeTakip
{
    public partial class FrmKisi : Form
    {
        public FrmKisi()
        {
            InitializeComponent();
        }

        public string Ad { get { return txtAd.Text; } set { txtAd.Text = value;} }
        public string Soyad { get { return txtSoy.Text; } set { txtSoy.Text = value; } }

        public string Telefon { get { return txtTel.Text; } set { txtTel.Text = value; } }

        public string Mail { get { return txtMail.Text; } set { txtMail.Text = value; } }


        private void Tamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void İptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
