using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Homework
{
    public partial class MainForm : Form
    {
        DataContext db;

        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("Admin panel hoşgeldiniz 'Veri Listesi' kısmından girilen verileri görebilirsiniz. 'Güncelle' kısmına girip girdiğiniz verilerin değerlerini değiştirebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db = new DataContext();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var usersList = context.Users
                    .Select(u => new
                    {
                        u.Id,
                        u.TC,
                        u.Ad,
                        u.Soyad,
                        u.Cinsiyet,
                        u.Sifre,
                        u.KayıtTarih
                    })
                    .ToList();
                dataGridView1.DataSource = usersList;
            }
            using (var context2 = new DataContext())
            {
                var usersList2 = context2.Users
                    .Select(u => new
                    {
                        u.Id,
                        u.TC,
                        u.Ad,
                        u.Soyad,
                        u.Cinsiyet,
                        u.Sifre,
                        u.KayıtTarih
                    })
                    .ToList();
                dataGridView2.DataSource = usersList2;
            }
            using (var context3 = new DataContext())
            {
                var usersList3 = context3.Logs
                    .Select(u => new
                    {
                        u.Id,
                        u.TC,
                        u.Sifre,
                        u.BeniHatırla,
                        u.SistemGirisTarih,
                        u.IPAdress
                    })
                    .ToList();
                dataGridView3.DataSource = usersList3;
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userıd = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                using (var db = new DataContext())
                {
                    var user = db.Users.Find(userıd);
                    if (user?.Photo != null)
                    {
                        using (var ms = new MemoryStream(user.Photo))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtbox_tc.Text = row.Cells["TC"].Value.ToString();
                txtbox_ad.Text = row.Cells["Ad"].Value.ToString();
                txtbox_soyad.Text = row.Cells["Soyad"].Value.ToString();
                txtbox_cinsiyet.Text = row.Cells["Cinsiyet"].Value.ToString();
                txtbox_sifre.Text = row.Cells["Sifre"].Value.ToString();
                if (DateTime.TryParse(row.Cells["KayıtTarih"].Value.ToString(), out DateTime kayitTarihi))
                {
                    dateTimePicker1.Value = kayitTarihi;
                }
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtbox_updatead.Clear();
            txtbox_updatesoyad.Clear();
            txtbox_updatetc.Clear();
            txtbox_updatesifre.Clear();
            txtbox_cinsiyet.Clear();
            radioButton1.Checked = false; radioButton2.Checked = false;
            pictureBox2.Image = null;
        }

        private void btn_resimsec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;
            if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "Kadın";
            }
            if (string.IsNullOrEmpty(cinsiyet))
            {
                MessageBox.Show("Lütfen cinsiyet seçin.");
                return;
            }
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\user\source\repos\Form Homework\Form Homework\Resources\guestedit-Photoroom.png");
            }
            if (string.IsNullOrEmpty(txtbox_updatetc.Text) || string.IsNullOrEmpty(txtbox_updatead.Text) || string.IsNullOrEmpty(txtbox_updatesoyad.Text) || string.IsNullOrEmpty(txtbox_updatesifre.Text))
            {
                MessageBox.Show("Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int userId = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;
            using (var db = new DataContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.TC = txtbox_updatetc.Text;
                    user.Ad = txtbox_updatead.Text;
                    user.Soyad = txtbox_updatesoyad.Text;
                    user.Cinsiyet = cinsiyet;
                    user.Sifre = txtbox_updatesifre.Text;
                    user.KayıtTarih = DateTime.Now;
                    if (pictureBox2.Image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                            user.Photo = ms.ToArray();
                        }
                    }
                    db.SaveChanges();
                    MainForm_Load(sender, e);
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clean_Click(sender, e);
                    txtbox_ad.Clear();
                    txtbox_sifre.Clear();
                    txtbox_soyad.Clear();
                    txtbox_tc.Clear();
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userıd = (int)dataGridView2.Rows[e.RowIndex].Cells["Id"].Value;
                using (var db = new DataContext())
                {
                    var user = db.Users.Find(userıd);
                    if (user?.Photo != null)
                    {
                        using (var ms = new MemoryStream(user.Photo))
                        {
                            pictureBox2.Image = Image.FromStream(ms);
                        }
                    }
                }
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtbox_updatetc.Text = row.Cells["TC"].Value.ToString();
                txtbox_updatead.Text = row.Cells["Ad"].Value.ToString();
                txtbox_updatesoyad.Text = row.Cells["Soyad"].Value.ToString();
                string cinsiyet = row.Cells["Cinsiyet"].Value.ToString();
                if (cinsiyet == "Erkek")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                txtbox_updatesifre.Text = row.Cells["Sifre"].Value.ToString();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_clean_Click(sender, e);
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            btn_clean_Click(sender, e);
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void btn_logsil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_id.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz ID'yi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int logId;
            if (!int.TryParse(txtbox_id.Text, out logId))
            {
                MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var logToDelete = db.Logs.FirstOrDefault(l => l.Id == logId);
            if (logToDelete != null)
            {
                db.Logs.Remove(logToDelete);
                db.SaveChanges();
                MainForm_Load(sender, e);
                MessageBox.Show($"ID: {logId} Kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbox_id.Clear();
            }
            else
            {
                MessageBox.Show($"ID: {logId} Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int logId = (int)dataGridView3.Rows[e.RowIndex].Cells["Id"].Value;
                txtbox_id.Text = logId.ToString();
            }
        }
    }
}
