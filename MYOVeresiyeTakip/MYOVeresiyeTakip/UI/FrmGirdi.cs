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
    public partial class FrmGirdi : Form
    {
        public FrmGirdi()
        {
            InitializeComponent();
        }

        bool borc = true;
        public bool Borc
        {
            get { return borc; }
            set { borc = value;
                if (borc)
                {
                    lblDurum.Text = "Borç Giriliyor";
                    lblDurum.BackColor = Color.Tomato;
                }
                else
                {
                    lblDurum.Text = "Ödeme Giriliyor";
                    lblDurum.BackColor = Color.YellowGreen;
                }
            }
        }
        public float Miktar { get { return (float)numericUpDown1.Value; } set { numericUpDown1.Value = (decimal)value; } }

        public DateTime Tarih { get { return dateTimePicker1.Value; } set { dateTimePicker1.Value = value; } }

        public string Durum { get { return textBox1.Text; } set { textBox1.Text = value; } }


        private void Tamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void İptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void FrmGirdi_Load(object sender, EventArgs e)
        {

        }
    }
}
