
namespace MYOVeresiyeTakip
{
    partial class FrmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKişiEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKişiDüzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKişiSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstKişiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstGirdiler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Açıklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.borçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGirdiİptal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGirdiDüzenle = new System.Windows.Forms.ToolStripButton();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKişiEkle,
            this.toolStripSeparator1,
            this.btnKişiDüzenle,
            this.toolStripSeparator2,
            this.btnKişiSil,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(467, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKişiEkle
            // 
            this.btnKişiEkle.Image = global::MYOVeresiyeTakip.Properties.Resources.account_add;
            this.btnKişiEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKişiEkle.Name = "btnKişiEkle";
            this.btnKişiEkle.Size = new System.Drawing.Size(53, 51);
            this.btnKişiEkle.Text = "Kişi Ekle";
            this.btnKişiEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKişiEkle.Click += new System.EventHandler(this.btnKişiEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnKişiDüzenle
            // 
            this.btnKişiDüzenle.Image = global::MYOVeresiyeTakip.Properties.Resources.account_edit;
            this.btnKişiDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKişiDüzenle.Name = "btnKişiDüzenle";
            this.btnKişiDüzenle.Size = new System.Drawing.Size(74, 51);
            this.btnKişiDüzenle.Text = "Kişi Düzenle";
            this.btnKişiDüzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKişiDüzenle.Click += new System.EventHandler(this.btnKişiDüzenle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnKişiSil
            // 
            this.btnKişiSil.Image = global::MYOVeresiyeTakip.Properties.Resources.account_cancel;
            this.btnKişiSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKişiSil.Name = "btnKişiSil";
            this.btnKişiSil.Size = new System.Drawing.Size(44, 51);
            this.btnKişiSil.Text = "Kişi Sil";
            this.btnKişiSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKişiSil.Click += new System.EventHandler(this.btnKişiSil_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 54);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 51);
            this.toolStripLabel1.Text = "Filtre:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(804, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "Toplam Borç:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstKişiler);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstGirdiler);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(911, 411);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 2;
            // 
            // lstKişiler
            // 
            this.lstKişiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader12});
            this.lstKişiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKişiler.FullRowSelect = true;
            this.lstKişiler.GridLines = true;
            this.lstKişiler.HideSelection = false;
            this.lstKişiler.Location = new System.Drawing.Point(0, 54);
            this.lstKişiler.Name = "lstKişiler";
            this.lstKişiler.Size = new System.Drawing.Size(467, 357);
            this.lstKişiler.TabIndex = 1;
            this.lstKişiler.UseCompatibleStateImageBehavior = false;
            this.lstKişiler.View = System.Windows.Forms.View.Details;
            this.lstKişiler.SelectedIndexChanged += new System.EventHandler(this.lstKişiler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 38;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 52;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 43;
            // 
            // lstGirdiler
            // 
            this.lstGirdiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.Miktar,
            this.Tarih,
            this.Açıklama,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstGirdiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGirdiler.FullRowSelect = true;
            this.lstGirdiler.GridLines = true;
            this.lstGirdiler.HideSelection = false;
            this.lstGirdiler.Location = new System.Drawing.Point(0, 54);
            this.lstGirdiler.Name = "lstGirdiler";
            this.lstGirdiler.Size = new System.Drawing.Size(440, 357);
            this.lstGirdiler.TabIndex = 2;
            this.lstGirdiler.UseCompatibleStateImageBehavior = false;
            this.lstGirdiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KiralamaID";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Plaka";
            this.columnHeader7.Width = 42;
            // 
            // Miktar
            // 
            this.Miktar.Text = "Tutar";
            this.Miktar.Width = 38;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Marka";
            this.Tarih.Width = 43;
            // 
            // Açıklama
            // 
            this.Açıklama.Text = "Model";
            this.Açıklama.Width = 43;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btnGirdiİptal,
            this.toolStripSeparator5,
            this.btnGirdiDüzenle});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(440, 54);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borçEkleToolStripMenuItem,
            this.ödemeYapToolStripMenuItem});
            this.toolStripButton4.Image = global::MYOVeresiyeTakip.Properties.Resources.format_accounting_add;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 51);
            this.toolStripButton4.Text = "Araç Ekle";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // borçEkleToolStripMenuItem
            // 
            this.borçEkleToolStripMenuItem.Name = "borçEkleToolStripMenuItem";
            this.borçEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borçEkleToolStripMenuItem.Text = "Borç Ekle";
            this.borçEkleToolStripMenuItem.Click += new System.EventHandler(this.borçEkleToolStripMenuItem_Click);
            // 
            // ödemeYapToolStripMenuItem
            // 
            this.ödemeYapToolStripMenuItem.Name = "ödemeYapToolStripMenuItem";
            this.ödemeYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ödemeYapToolStripMenuItem.Text = "Ödeme Yap";
            this.ödemeYapToolStripMenuItem.Click += new System.EventHandler(this.ödemeYapToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnGirdiİptal
            // 
            this.btnGirdiİptal.Image = global::MYOVeresiyeTakip.Properties.Resources.format_accounting_cancel;
            this.btnGirdiİptal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGirdiİptal.Name = "btnGirdiİptal";
            this.btnGirdiİptal.Size = new System.Drawing.Size(61, 51);
            this.btnGirdiİptal.Text = "Araç İptal";
            this.btnGirdiİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGirdiİptal.Click += new System.EventHandler(this.btnGirdiİptal_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // btnGirdiDüzenle
            // 
            this.btnGirdiDüzenle.Image = global::MYOVeresiyeTakip.Properties.Resources.format_accounting_edit;
            this.btnGirdiDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGirdiDüzenle.Name = "btnGirdiDüzenle";
            this.btnGirdiDüzenle.Size = new System.Drawing.Size(80, 51);
            this.btnGirdiDüzenle.Text = "Araç Düzenle";
            this.btnGirdiDüzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGirdiDüzenle.Click += new System.EventHandler(this.btnGirdiDüzenle_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Yakıt";
            this.columnHeader8.Width = 38;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Renk";
            this.columnHeader9.Width = 45;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "KasaTipi";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TC";
            this.columnHeader11.Width = 44;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adres";
            this.columnHeader12.Width = 51;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 433);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmMain";
            this.Text = "MYO Veresiye Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKişiEkle;
        private System.Windows.Forms.ToolStripButton btnKişiDüzenle;
        private System.Windows.Forms.ToolStripButton btnKişiSil;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstKişiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstGirdiler;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Açıklama;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnGirdiİptal;
        private System.Windows.Forms.ToolStripButton btnGirdiDüzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem borçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

