using System;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using Microsoft.VisualBasic.Logging;

namespace Form_Homework
{
    public partial class LoginPanel : Form
    {
        DataContext db;
        public int hak = 3;
        private readonly System.Windows.Forms.Timer timer;
        public LoginPanel()
        {
            InitializeComponent();
            db = new DataContext();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timer.Interval = 1000;
            timer.Start();
        }
       
        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtbox_password.Clear();
            txtbox_tc.Clear();
            chkbox_showpassword.Checked = false;
        }

        private void lbl_changepass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            this.Hide();
            changePassword.Show();
        }
        private void chkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_showpassword.Checked)
            {
                txtbox_password.PasswordChar = '\0';
            }
            else
            {
                txtbox_password.PasswordChar = '*';
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_tc.Text) || string.IsNullOrEmpty(txtbox_password.Text))
            {
                MessageBox.Show("Alanlarý Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tc = txtbox_tc.Text;
            string sifre = txtbox_password.Text;
            var kullanýcý = db.Users.FirstOrDefault(i => i.TC == tc && i.Sifre == sifre);
            if (kullanýcý == null)
            {
                hak--;
                if (hak == 0)
                {
                    MessageBox.Show("Üç kere hatalý giriþ yaptýðýnýz için sistem 10 saniye kilitlendi lütfen bekleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_clean.Enabled = false;
                    btn_login.Enabled = false;
                    btn_register.Enabled = false;
                    chkbox_showpassword.Enabled = false;
                    lbl_changepass.Enabled = false;
                    Thread.Sleep(10000);
                    btn_clean_Click(sender, e);
                    hak = 3;
                    btn_clean.Enabled = true;
                    btn_login.Enabled = true;
                    btn_register.Enabled = true;
                    chkbox_showpassword.Enabled = true;
                    lbl_changepass.Enabled = true;
                    return;
                }
                MessageBox.Show("Giriþ Bilgileri Hatalý! Kalan hak=> " + hak, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_clean_Click(sender, e);
            }
            else
            {
                string ipAddress = GetLocalIPAddress();
                Logs logs = new Logs();
                logs.TC = tc;
                logs.Sifre = sifre;
                logs.SistemGirisTarih=DateTime.Now;
                logs.BeniHatýrla = checkBox1.Checked ? 1 : 0;
                logs.IPAdress= ipAddress;
                db.Logs.Add(logs);
                db.SaveChanges();
                MessageBox.Show("Giriþ Baþarýlý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Hoþgeldin " + kullanýcý.Ad, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(1000);
                this.Hide();
                MainForm form = new MainForm();
                form.Show();
            }
        }
        private void LoginPanel_Load(object sender, EventArgs e)
        {
            var lastLog = db.Logs.OrderByDescending(l => l.Id).FirstOrDefault();
            if (lastLog != null && lastLog.BeniHatýrla == 1)
            {
                txtbox_tc.Text = lastLog.TC;
                txtbox_password.Text = lastLog.Sifre;
            }
        }
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
