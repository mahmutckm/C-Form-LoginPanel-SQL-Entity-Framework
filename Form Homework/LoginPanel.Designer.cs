namespace Form_Homework
{
    partial class LoginPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtbox_tc = new TextBox();
            txtbox_password = new TextBox();
            btn_login = new Button();
            btn_clean = new Button();
            btn_register = new Button();
            lbl_changepass = new Label();
            chkbox_showpassword = new CheckBox();
            checkBox1 = new CheckBox();
            lbl_time = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(265, 115);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(265, 167);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtbox_tc
            // 
            txtbox_tc.Location = new Point(346, 112);
            txtbox_tc.MaxLength = 11;
            txtbox_tc.Name = "txtbox_tc";
            txtbox_tc.Size = new Size(194, 27);
            txtbox_tc.TabIndex = 2;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(346, 167);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.PasswordChar = '*';
            txtbox_password.Size = new Size(194, 27);
            txtbox_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.Image = Properties.Resources.edit_Photoroom;
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(274, 261);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(158, 61);
            btn_login.TabIndex = 4;
            btn_login.Text = "Giriş";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.White;
            btn_clean.Image = Properties.Resources.edit2_Photoroom;
            btn_clean.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clean.Location = new Point(438, 261);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(158, 61);
            btn_clean.TabIndex = 5;
            btn_clean.Text = "Temizle";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.White;
            btn_register.Image = Properties.Resources.registeredit_Photoroom;
            btn_register.ImageAlign = ContentAlignment.MiddleLeft;
            btn_register.Location = new Point(12, 357);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(158, 64);
            btn_register.TabIndex = 6;
            btn_register.Text = "Kayıt Ol";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_changepass
            // 
            lbl_changepass.AutoSize = true;
            lbl_changepass.BackColor = Color.White;
            lbl_changepass.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_changepass.Image = Properties.Resources.şifreunuttumedit_Photoroom;
            lbl_changepass.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_changepass.Location = new Point(458, 213);
            lbl_changepass.Name = "lbl_changepass";
            lbl_changepass.Size = new Size(114, 16);
            lbl_changepass.TabIndex = 7;
            lbl_changepass.Text = "    Şifremi unuttum";
            lbl_changepass.Click += lbl_changepass_Click;
            // 
            // chkbox_showpassword
            // 
            chkbox_showpassword.AutoSize = true;
            chkbox_showpassword.BackColor = Color.White;
            chkbox_showpassword.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkbox_showpassword.Image = Properties.Resources.editpass_Photoroom;
            chkbox_showpassword.ImageAlign = ContentAlignment.MiddleLeft;
            chkbox_showpassword.Location = new Point(546, 174);
            chkbox_showpassword.Name = "chkbox_showpassword";
            chkbox_showpassword.Size = new Size(111, 20);
            chkbox_showpassword.TabIndex = 8;
            chkbox_showpassword.Text = "    Şifre göster";
            chkbox_showpassword.TextAlign = ContentAlignment.MiddleRight;
            chkbox_showpassword.UseVisualStyleBackColor = false;
            chkbox_showpassword.CheckedChanged += chkbox_showpassword_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Location = new Point(346, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Beni hatırla";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.BackColor = Color.Transparent;
            lbl_time.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_time.Location = new Point(715, 9);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(108, 32);
            lbl_time.TabIndex = 10;
            lbl_time.Text = "ZAMAN";
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4e1c96_XpSHdkYZ6H;
            ClientSize = new Size(835, 433);
            Controls.Add(lbl_time);
            Controls.Add(checkBox1);
            Controls.Add(chkbox_showpassword);
            Controls.Add(lbl_changepass);
            Controls.Add(btn_register);
            Controls.Add(btn_clean);
            Controls.Add(btn_login);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_tc);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginPanel";
            Text = "Login Panel";
            Load += LoginPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbox_tc;
        private TextBox txtbox_password;
        private Button btn_login;
        private Button btn_clean;
        private Button btn_register;
        private Label lbl_changepass;
        private CheckBox chkbox_showpassword;
        private CheckBox checkBox1;
        private Label lbl_time;
    }
}
