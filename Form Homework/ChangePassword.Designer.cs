namespace Form_Homework
{
    partial class ChangePassword
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbox_tc = new TextBox();
            txtbox_sifre = new TextBox();
            txtbox_sifre2 = new TextBox();
            btn_changepass = new Button();
            btn_clean = new Button();
            btn_back = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(260, 91);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(260, 129);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(260, 169);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 2;
            label3.Text = "Tekrar Şifre:";
            // 
            // txtbox_tc
            // 
            txtbox_tc.Location = new Point(395, 88);
            txtbox_tc.MaxLength = 11;
            txtbox_tc.Name = "txtbox_tc";
            txtbox_tc.Size = new Size(176, 27);
            txtbox_tc.TabIndex = 3;
            // 
            // txtbox_sifre
            // 
            txtbox_sifre.Location = new Point(395, 126);
            txtbox_sifre.Name = "txtbox_sifre";
            txtbox_sifre.PasswordChar = '*';
            txtbox_sifre.Size = new Size(175, 27);
            txtbox_sifre.TabIndex = 4;
            // 
            // txtbox_sifre2
            // 
            txtbox_sifre2.Location = new Point(394, 166);
            txtbox_sifre2.Name = "txtbox_sifre2";
            txtbox_sifre2.PasswordChar = '*';
            txtbox_sifre2.Size = new Size(176, 27);
            txtbox_sifre2.TabIndex = 5;
            // 
            // btn_changepass
            // 
            btn_changepass.BackColor = Color.White;
            btn_changepass.Image = Properties.Resources.editşifredeğiştir;
            btn_changepass.ImageAlign = ContentAlignment.MiddleLeft;
            btn_changepass.Location = new Point(278, 236);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(173, 61);
            btn_changepass.TabIndex = 6;
            btn_changepass.Text = "           Şifre değiştir";
            btn_changepass.UseVisualStyleBackColor = false;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.White;
            btn_clean.Image = Properties.Resources.edit2_Photoroom1;
            btn_clean.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clean.Location = new Point(469, 236);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(173, 61);
            btn_clean.TabIndex = 7;
            btn_clean.Text = "    Temizle";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Image = Properties.Resources.backedit;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(12, 360);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(173, 61);
            btn_back.TabIndex = 8;
            btn_back.Text = "          Geri dön";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.Image = Properties.Resources.editpass_Photoroom;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(598, 168);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 20);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "    Şifre göster";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4e1c96_XpSHdkYZ6H;
            ClientSize = new Size(835, 433);
            Controls.Add(checkBox1);
            Controls.Add(btn_back);
            Controls.Add(btn_clean);
            Controls.Add(btn_changepass);
            Controls.Add(txtbox_sifre2);
            Controls.Add(txtbox_sifre);
            Controls.Add(txtbox_tc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChangePassword";
            Text = "Change Password Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbox_tc;
        private TextBox txtbox_sifre;
        private TextBox txtbox_sifre2;
        private Button btn_changepass;
        private Button btn_clean;
        private Button btn_back;
        private CheckBox checkBox1;
    }
}