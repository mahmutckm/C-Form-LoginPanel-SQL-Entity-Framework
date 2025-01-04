namespace Form_Homework
{
    partial class Register
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtbox_registertc = new TextBox();
            txtbox_registerad = new TextBox();
            txtbox_registersoyad = new TextBox();
            txtbox_registersifre = new TextBox();
            txtbox_registersifre2 = new TextBox();
            btn_register = new Button();
            btn_clean = new Button();
            btn_back = new Button();
            btn_resim = new Button();
            chkbox_sifregoster = new CheckBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(510, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 1;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 24);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(37, 140);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 3;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(37, 220);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 4;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(37, 267);
            label5.Name = "label5";
            label5.Size = new Size(128, 24);
            label5.TabIndex = 5;
            label5.Text = "Tekrar Şifre:";
            // 
            // txtbox_registertc
            // 
            txtbox_registertc.Location = new Point(194, 32);
            txtbox_registertc.MaxLength = 11;
            txtbox_registertc.Name = "txtbox_registertc";
            txtbox_registertc.Size = new Size(162, 27);
            txtbox_registertc.TabIndex = 6;
            // 
            // txtbox_registerad
            // 
            txtbox_registerad.Location = new Point(194, 86);
            txtbox_registerad.Name = "txtbox_registerad";
            txtbox_registerad.Size = new Size(162, 27);
            txtbox_registerad.TabIndex = 7;
            // 
            // txtbox_registersoyad
            // 
            txtbox_registersoyad.Location = new Point(194, 137);
            txtbox_registersoyad.Name = "txtbox_registersoyad";
            txtbox_registersoyad.Size = new Size(162, 27);
            txtbox_registersoyad.TabIndex = 8;
            // 
            // txtbox_registersifre
            // 
            txtbox_registersifre.Location = new Point(194, 217);
            txtbox_registersifre.Name = "txtbox_registersifre";
            txtbox_registersifre.PasswordChar = '*';
            txtbox_registersifre.Size = new Size(162, 27);
            txtbox_registersifre.TabIndex = 9;
            // 
            // txtbox_registersifre2
            // 
            txtbox_registersifre2.Location = new Point(195, 264);
            txtbox_registersifre2.Name = "txtbox_registersifre2";
            txtbox_registersifre2.PasswordChar = '*';
            txtbox_registersifre2.Size = new Size(162, 27);
            txtbox_registersifre2.TabIndex = 10;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.White;
            btn_register.Image = Properties.Resources.registeredit_Photoroom;
            btn_register.ImageAlign = ContentAlignment.MiddleLeft;
            btn_register.Location = new Point(114, 311);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(147, 61);
            btn_register.TabIndex = 11;
            btn_register.Text = "     Kayıt Ol";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.White;
            btn_clean.Image = Properties.Resources.edit2_Photoroom1;
            btn_clean.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clean.Location = new Point(267, 311);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(147, 61);
            btn_clean.TabIndex = 12;
            btn_clean.Text = "     Temizle";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Image = Properties.Resources.backedit_Photoroom;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(-2, 377);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(136, 58);
            btn_back.TabIndex = 13;
            btn_back.Text = "          Geri dön";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_resim
            // 
            btn_resim.BackColor = Color.White;
            btn_resim.Image = Properties.Resources.editphoto;
            btn_resim.ImageAlign = ContentAlignment.MiddleLeft;
            btn_resim.Location = new Point(600, 360);
            btn_resim.Name = "btn_resim";
            btn_resim.Size = new Size(147, 61);
            btn_resim.TabIndex = 14;
            btn_resim.Text = "          Resim Seç";
            btn_resim.UseVisualStyleBackColor = false;
            btn_resim.Click += btn_resim_Click;
            // 
            // chkbox_sifregoster
            // 
            chkbox_sifregoster.AutoSize = true;
            chkbox_sifregoster.BackColor = Color.White;
            chkbox_sifregoster.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkbox_sifregoster.Image = Properties.Resources.editpass_Photoroom;
            chkbox_sifregoster.ImageAlign = ContentAlignment.MiddleLeft;
            chkbox_sifregoster.Location = new Point(377, 266);
            chkbox_sifregoster.Name = "chkbox_sifregoster";
            chkbox_sifregoster.Size = new Size(111, 20);
            chkbox_sifregoster.TabIndex = 15;
            chkbox_sifregoster.Text = "    Şifre göster";
            chkbox_sifregoster.UseVisualStyleBackColor = false;
            chkbox_sifregoster.CheckedChanged += chkbox_sifregoster_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(36, 182);
            label6.Name = "label6";
            label6.Size = new Size(93, 24);
            label6.TabIndex = 16;
            label6.Text = "Cinsiyet:";
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.White;
            radioButton1.Image = Properties.Resources.erkekedit_Photoroom;
            radioButton1.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton1.Location = new Point(193, 175);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 33);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "      Erkek";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.White;
            radioButton2.Image = Properties.Resources.editkadın_Photoroom;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(302, 175);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 33);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "     Kadın";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4e1c96_XpSHdkYZ6H;
            ClientSize = new Size(835, 433);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(chkbox_sifregoster);
            Controls.Add(btn_resim);
            Controls.Add(btn_back);
            Controls.Add(btn_clean);
            Controls.Add(btn_register);
            Controls.Add(txtbox_registersifre2);
            Controls.Add(txtbox_registersifre);
            Controls.Add(txtbox_registersoyad);
            Controls.Add(txtbox_registerad);
            Controls.Add(txtbox_registertc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            Text = "Register Panel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtbox_registertc;
        private TextBox txtbox_registerad;
        private TextBox txtbox_registersoyad;
        private TextBox txtbox_registersifre;
        private TextBox txtbox_registersifre2;
        private Button btn_register;
        private Button btn_clean;
        private Button btn_back;
        private Button btn_resim;
        private CheckBox chkbox_sifregoster;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}