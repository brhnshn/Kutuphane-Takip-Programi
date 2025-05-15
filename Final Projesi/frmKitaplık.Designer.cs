namespace Final_Projesi
{
    partial class frmKitaplık
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitaplık));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.numSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.kutuphanelikDataSet = new Final_Projesi.KutuphanelikDataSet();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter = new Final_Projesi.KutuphanelikDataSetTableAdapters.KitaplarTableAdapter();
            this.numYil = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanelikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(307, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(307, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayın Evi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(636, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yıl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(572, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(880, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tür";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(398, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 22);
            this.txtAd.TabIndex = 3;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(398, 104);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(161, 22);
            this.txtYayinevi.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(114, 104);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(161, 22);
            this.txtYazar.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(114, 61);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Roman",
            "Matematik",
            "Bilim Kurgu",
            "Biyografi",
            "Şiir",
            "Felsefe",
            "Tarih",
            "Fantastik",
            "Çocuk"});
            this.comboTur.Location = new System.Drawing.Point(922, 63);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(161, 24);
            this.comboTur.TabIndex = 7;
            this.comboTur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numSayfaSayisi
            // 
            this.numSayfaSayisi.Location = new System.Drawing.Point(682, 102);
            this.numSayfaSayisi.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numSayfaSayisi.Name = "numSayfaSayisi";
            this.numSayfaSayisi.Size = new System.Drawing.Size(161, 22);
            this.numSayfaSayisi.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(365, 158);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 35);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(458, 158);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(97, 35);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(561, 158);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 35);
            this.btnYeni.TabIndex = 11;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(648, 158);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 35);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 305);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(1158, 379);
            this.dgvKitaplar.TabIndex = 18;
            this.dgvKitaplar.SelectionChanged += new System.EventHandler(this.dgvKitaplar_SelectionChanged);
            // 
            // kutuphanelikDataSet
            // 
            this.kutuphanelikDataSet.DataSetName = "KutuphanelikDataSet";
            this.kutuphanelikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphanelikDataSet;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // numYil
            // 
            this.numYil.Location = new System.Drawing.Point(683, 64);
            this.numYil.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numYil.Name = "numYil";
            this.numYil.Size = new System.Drawing.Size(160, 22);
            this.numYil.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(866, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(922, 104);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(161, 22);
            this.txtISBN.TabIndex = 8;
            this.txtISBN.Text = "";
            // 
            // frmKitaplık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1182, 696);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numYil);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numSayfaSayisi);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitaplık";
            this.Text = "Kütüphane Takip  ";
            this.Load += new System.EventHandler(this.frmKitaplık_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanelikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.NumericUpDown numSayfaSayisi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private KutuphanelikDataSet kutuphanelikDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KutuphanelikDataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.NumericUpDown numYil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtISBN;
    }
}

