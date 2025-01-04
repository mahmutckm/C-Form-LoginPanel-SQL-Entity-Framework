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
    public partial class Register : Form
    {
        DataContext db;
        public Register()
        {
            InitializeComponent();
            db = new DataContext();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtbox_registerad.Clear();
            txtbox_registertc.Clear();
            txtbox_registersifre.Clear();
            txtbox_registersifre2.Clear();
            txtbox_registersoyad.Clear();
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
            chkbox_sifregoster.Checked = false;
            pictureBox1.Image = null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void chkbox_sifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_sifregoster.Checked)
            {
                txtbox_registersifre.PasswordChar = '\0';
                txtbox_registersifre2.PasswordChar = '\0';
            }
            else
            {
                txtbox_registersifre2.PasswordChar = '*';
                txtbox_registersifre.PasswordChar = '*';
            }
        }

        private void btn_resim_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtbox_registerad.Text) || string.IsNullOrEmpty(txtbox_registersoyad.Text) || string.IsNullOrEmpty(txtbox_registertc.Text) || string.IsNullOrEmpty(txtbox_registersifre.Text) || string.IsNullOrEmpty(txtbox_registersifre2.Text))
            {
                MessageBox.Show("Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                MessageBox.Show("Lütfen cinsiyet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbox_registersifre.Text != txtbox_registersifre2.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var kullanıcı = db.Users.Where(i => i.TC == txtbox_registertc.Text).FirstOrDefault();
            if (kullanıcı != null)
            {
                MessageBox.Show("Kayıtlı kullanıcı.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\user\source\repos\Form Homework\Form Homework\Resources\guestedit-Photoroom.png");
            }
            using var addphoto = new MemoryStream();
            pictureBox1.Image.Save(addphoto, System.Drawing.Imaging.ImageFormat.Png);
            Users users = new Users();
            users.TC = txtbox_registertc.Text;
            users.Ad = txtbox_registerad.Text;
            users.Soyad = txtbox_registersoyad.Text;
            users.Sifre = txtbox_registersifre.Text;
            users.Cinsiyet = cinsiyet;
            users.Photo = addphoto.ToArray();
            users.KayıtTarih=DateTime.Now;
            db.Users.Add(users);
            int registercontrol = db.SaveChanges();
            if (registercontrol > 0)
            {
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_clean_Click(sender, e);
                LoginPanel loginPanel = new LoginPanel();
                this.Hide();
                loginPanel.Show();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
