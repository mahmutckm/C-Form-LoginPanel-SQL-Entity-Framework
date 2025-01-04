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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtbox_tc.Clear();
            txtbox_sifre.Clear();
            txtbox_sifre2.Clear();
            checkBox1.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbox_sifre.PasswordChar = '\0';
                txtbox_sifre2.PasswordChar = '\0';
            }
            else
            {
                txtbox_sifre.PasswordChar = '*';
                txtbox_sifre2.PasswordChar = '*';
            }
        }
        private void btn_changepass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_tc.Text) || string.IsNullOrEmpty(txtbox_sifre.Text) || string.IsNullOrEmpty(txtbox_sifre2.Text))
            {
                MessageBox.Show("Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbox_sifre.Text != txtbox_sifre2.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.TC == txtbox_tc.Text);
                if (user != null)
                {
                    user.Sifre = txtbox_sifre.Text;
                    context.SaveChanges();
                    MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPanel loginPanel = new LoginPanel();
                    this.Hide();
                    loginPanel.Show();
                }
                else
                {
                    MessageBox.Show("TC kimlik numarası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
