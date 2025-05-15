using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Final_Projesi
{
    public partial class frmKitaplık: Form
    {
        public frmKitaplık()
        {
            InitializeComponent();
        }



        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sahin\\source\\repos\\Final Projesi\\Final Projesi\\Kutuphanelik.accdb";
        OleDbCommand cmd;
        OleDbConnection connection;
        DataTable dt;
        OleDbDataAdapter adapter;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmKitaplık_Load(object sender, EventArgs e)
        {
            KitapGetir();
            
            // TODO: This line of code loads data into the 'kutuphanelikDataSet.Kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kutuphanelikDataSet.Kitaplar);

        }
        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {

            txtID.Text = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            txtYazar.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtYayinevi.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();
            numYil.Value = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells[4].Value);
            numSayfaSayisi.Value = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells[5].Value);
            comboTur.Text = dgvKitaplar.CurrentRow.Cells[6].Value.ToString();
            txtISBN.Text = dgvKitaplar.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yazar = txtYazar.Text;
            string ad = txtAd.Text;
            string yayinevi = txtYayinevi.Text;
            string tür = comboTur.SelectedItem?.ToString();
            string ISBN = txtISBN.Text;
            int yil = (int)numYil.Value;
            int sayfaSayisi = (int)numSayfaSayisi.Value;

            if (ad == string.Empty || yazar == string.Empty || yayinevi == string.Empty ||
                tür == null || yil <= 0 || sayfaSayisi <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            connection = new OleDbConnection(connectionString);
            string query = "insert into Kitaplar (adi, yazarAdi, yayinevi, yil, tür, sayfaSayisi, ISBN) values " +
                "(@ad, @yazar, @yayinevi, @yil, @tür, @sayfasayisi, @ISBN)";
            cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@yayinevi", yayinevi);
            cmd.Parameters.AddWithValue("@yil", yil);
            cmd.Parameters.AddWithValue("@tür", tür);
            cmd.Parameters.AddWithValue("@sayfasayisi", sayfaSayisi);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitapGetir();

            MessageBox.Show("Yeni kayıt başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string yazar = txtYazar.Text;
            string ad = txtAd.Text;
            string yayinevi = txtYayinevi.Text;
            string tür = comboTur.SelectedItem?.ToString();
            int yil = (int)numYil.Value;
            int sayfaSayisi = (int)numSayfaSayisi.Value;
            string ISBN = txtISBN.Text;

            if (ad == string.Empty || yazar == string.Empty || yayinevi == string.Empty ||
                tür == null || yil <= 0 || sayfaSayisi <= 0 || ISBN == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connection = new OleDbConnection(connectionString);
            string query = "update Kitaplar set " +
                "adi=@ad, yazarAdi=@yazar, yayinevi=@yayinevi, ISBN=@ISBN, yil=@yil, tür=@tür, sayfaSayisi=@sayfasayisi " +
                "where id=@id";
            cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@yayinevi", yayinevi);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@yil", yil);
            cmd.Parameters.AddWithValue("@tür", tür);
            cmd.Parameters.AddWithValue("@sayfasayisi", sayfaSayisi);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitapGetir();
            MessageBox.Show("Kayıt başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
            string query = "delete from Kitaplar where id=@id";
            cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitapGetir();
            MessageBox.Show("Kayıt başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            dgvKitaplar.ClearSelection();
            txtYayinevi.Clear();
            txtYazar.Clear();
            txtAd.Clear();
            txtISBN.Clear();
            numSayfaSayisi.Value = numSayfaSayisi.Minimum;
            comboTur.SelectedIndex = -1;
            numYil.Value = numYil.Minimum;
        }

        void KitapGetir()
        {
            connection = new OleDbConnection(connectionString);
            dt = new DataTable();
            adapter = new OleDbDataAdapter("select * from Kitaplar order by id", connection);
            connection.Open();
            adapter.Fill(dt);
            dgvKitaplar.DataSource = dt;
            connection.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

