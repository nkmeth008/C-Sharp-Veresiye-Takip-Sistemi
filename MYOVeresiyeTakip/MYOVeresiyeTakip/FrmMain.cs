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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KişileriListele();
        }

        private void btnKişiEkle_Click(object sender, EventArgs e)
        {
            FrmKisi k = new FrmKisi() { Text = "Kişi Ekle", StartPosition = FormStartPosition.CenterParent};
            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.KisiEkle(k.Ad, k.Soyad, k.Telefon, k.Mail);

                KişileriListele();
            }
        }

        public void KişileriListele()
        {
            BL.KişileriListele();
            lstKişiler.Items.Clear();
            foreach(Kisi k in BL.Kisiler)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    k.kid.ToString(),
                    k.Ad,
                    k.Soyad,
                    k.Telefon,
                    k.Mail
                });

                lstKişiler.Items.Add(item);
            }
        }

        private void lstKişiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKişiler.SelectedItems.Count == 0)
            {
                lstGirdiler.Items.Clear();
                return;
            }
            ListViewItem item = lstKişiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;

            KişiGirdileriniListele(kid);

            float borc_miktarı=  BL.KişiToplamBorcu(kid);
            toolStripStatusLabel2.Text = $"Toplam Borç: {borc_miktarı:C2}";
        }

        void KişiGirdileriniListele(string kid)
        {
            Kisi k= BL.Kisiler.Find(o => o.kid.ToString() == kid);
            lstGirdiler.Items.Clear();
            foreach (Girdi g in k.Girdiler)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    k.kid.ToString(),
                    g.plaka.ToString(),
                    g.GunlukFiyat.ToString(),
                    g.Durum,
                });

                lstGirdiler.Items.Add(item);
            }

        }

        private void borçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKişiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstKişiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;

            FrmGirdi g = new FrmGirdi() { Text = "Girdi", Borc = true, StartPosition = FormStartPosition.CenterParent };
            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiEkle(kid, g.Miktar, g.Tarih, g.Durum);

                KişiGirdileriniListele(kid);
            }
        }

        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKişiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstKişiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;

            FrmGirdi g = new FrmGirdi() { Text = "Girdi", Borc = false, StartPosition = FormStartPosition.CenterParent };
            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiEkle(kid, -g.Miktar, g.Tarih, g.Durum);

                KişiGirdileriniListele(kid);
            }

        }

        private void btnKişiDüzenle_Click(object sender, EventArgs e)
        {
            if (lstKişiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstKişiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;

            FrmKisi f = new FrmKisi() { Text = "Kişi Düzenle", StartPosition = FormStartPosition.CenterParent };
            f.Ad = item.SubItems[1].Text;
            f.Soyad = item.SubItems[2].Text;
            f.Telefon = item.SubItems[3].Text;
            f.Mail = item.SubItems[4].Text;

            if(f.ShowDialog() == DialogResult.OK)
            {
                BL.KişiDüzenle(kid, f.Ad, f.Soyad, f.Telefon, f.Mail);

                KişileriListele();
            }
        }

        private void btnKişiSil_Click(object sender, EventArgs e)
        {
            if (lstKişiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstKişiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;

            DialogResult res= MessageBox.Show("Seçili Kişi Silinsin mi?", "Silmeyi onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                BL.KişiSil(kid);
                KişileriListele();
            }

        }

        private void btnGirdiİptal_Click(object sender, EventArgs e)
        {
            if (lstGirdiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstGirdiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;
            string gid = item.SubItems[1].Text;

            DialogResult res = MessageBox.Show("Seçili girdi Silinsin mi?", "Silmeyi onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                BL.GirdiSil(kid, plaka);

                KişiGirdileriniListele(kid);
            }

        }

        private void btnGirdiDüzenle_Click(object sender, EventArgs e)
        {
            if (lstGirdiler.SelectedItems.Count == 0) return;
            ListViewItem item = lstGirdiler.SelectedItems[0];
            string kid = item.SubItems[0].Text;
            string plaka = item.SubItems[1].Text;
            float mik = float.Parse(item.SubItems[2].Text);

            FrmGirdi g = new FrmGirdi() { Text = "Girdi Düzenle", StartPosition = FormStartPosition.CenterParent, Borc = mik>0 };
            g.Miktar = mik;
            g.Tarih = DateTime.Parse(item.SubItems[3].Text);
            g.Durum = item.SubItems[4].Text;

            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiDüzenle(kid, plaka, g.Miktar, g.Tarih, g.Aciklama);

                KişiGirdileriniListele(kid);

            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<Kisi> _kisiler = BL.KişileriFiltrele(toolStripTextBox1.Text);

            lstKişiler.Items.Clear();
            foreach (Kisi k in _kisiler)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    k.kid.ToString(),
                    k.Ad,
                    k.Soyad,
                    k.Telefon,
                    k.Mail
                });

                lstKişiler.Items.Add(item);
            }
        }
    }
}
