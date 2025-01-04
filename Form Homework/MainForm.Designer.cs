namespace Form_Homework
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtbox_tc = new TextBox();
            txtbox_ad = new TextBox();
            txtbox_soyad = new TextBox();
            txtbox_sifre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtbox_cinsiyet = new TextBox();
            label10 = new Label();
            btn_back = new Button();
            tabPage2 = new TabPage();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label11 = new Label();
            btn_back1 = new Button();
            btn_resimsec = new Button();
            btn_clean = new Button();
            btn_update = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            txtbox_updatesifre = new TextBox();
            label8 = new Label();
            txtbox_updatesoyad = new TextBox();
            label9 = new Label();
            txtbox_updatead = new TextBox();
            txtbox_updatetc = new TextBox();
            tabPage3 = new TabPage();
            btn_logsil = new Button();
            txtbox_id = new TextBox();
            label12 = new Label();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(914, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 320);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 258);
            label2.Name = "label2";
            label2.Size = new Size(44, 24);
            label2.TabIndex = 3;
            label2.Text = "TC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 301);
            label3.Name = "label3";
            label3.Size = new Size(42, 24);
            label3.TabIndex = 4;
            label3.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 341);
            label4.Name = "label4";
            label4.Size = new Size(76, 24);
            label4.TabIndex = 5;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 418);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 6;
            label5.Text = "Şifre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(20, 457);
            label6.Name = "label6";
            label6.Size = new Size(124, 24);
            label6.TabIndex = 7;
            label6.Text = "Kayıt Tarihi:";
            // 
            // txtbox_tc
            // 
            txtbox_tc.Location = new Point(150, 255);
            txtbox_tc.Name = "txtbox_tc";
            txtbox_tc.Size = new Size(157, 27);
            txtbox_tc.TabIndex = 9;
            // 
            // txtbox_ad
            // 
            txtbox_ad.Location = new Point(150, 298);
            txtbox_ad.Name = "txtbox_ad";
            txtbox_ad.Size = new Size(157, 27);
            txtbox_ad.TabIndex = 10;
            // 
            // txtbox_soyad
            // 
            txtbox_soyad.Location = new Point(150, 338);
            txtbox_soyad.Name = "txtbox_soyad";
            txtbox_soyad.Size = new Size(157, 27);
            txtbox_soyad.TabIndex = 11;
            // 
            // txtbox_sifre
            // 
            txtbox_sifre.Location = new Point(150, 415);
            txtbox_sifre.Name = "txtbox_sifre";
            txtbox_sifre.Size = new Size(157, 27);
            txtbox_sifre.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "  dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(150, 457);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1330, 601);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.BackgroundImage = Properties.Resources.mountains_6865752_1280;
            tabPage1.Controls.Add(txtbox_cinsiyet);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(btn_back);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtbox_sifre);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtbox_soyad);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtbox_ad);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtbox_tc);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1322, 568);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Veri Listesi";
            // 
            // txtbox_cinsiyet
            // 
            txtbox_cinsiyet.Location = new Point(150, 377);
            txtbox_cinsiyet.Name = "txtbox_cinsiyet";
            txtbox_cinsiyet.Size = new Size(157, 27);
            txtbox_cinsiyet.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(20, 380);
            label10.Name = "label10";
            label10.Size = new Size(93, 24);
            label10.TabIndex = 16;
            label10.Text = "Cinsiyet:";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Image = Properties.Resources.backedit_Photoroom;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(3, 503);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(135, 59);
            btn_back.TabIndex = 15;
            btn_back.Text = "            Geri dön";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.BackgroundImage = Properties.Resources.mountains_6865752_1280;
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(btn_back1);
            tabPage2.Controls.Add(btn_resimsec);
            tabPage2.Controls.Add(btn_clean);
            tabPage2.Controls.Add(btn_update);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtbox_updatesifre);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtbox_updatesoyad);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtbox_updatead);
            tabPage2.Controls.Add(txtbox_updatetc);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1322, 568);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Güncelle";
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.White;
            radioButton2.Image = Properties.Resources.editkadın_Photoroom;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(254, 417);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 30);
            radioButton2.TabIndex = 32;
            radioButton2.TabStop = true;
            radioButton2.Text = "    Kadın";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.White;
            radioButton1.Image = Properties.Resources.erkekedit_Photoroom;
            radioButton1.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton1.Location = new Point(152, 417);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 30);
            radioButton1.TabIndex = 31;
            radioButton1.TabStop = true;
            radioButton1.Text = "      Erkek";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(22, 417);
            label11.Name = "label11";
            label11.Size = new Size(93, 24);
            label11.TabIndex = 30;
            label11.Text = "Cinsiyet:";
            // 
            // btn_back1
            // 
            btn_back1.BackColor = Color.White;
            btn_back1.Image = Properties.Resources.backedit_Photoroom;
            btn_back1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back1.Location = new Point(6, 503);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(135, 59);
            btn_back1.TabIndex = 29;
            btn_back1.Text = "            Geri dön";
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // btn_resimsec
            // 
            btn_resimsec.BackColor = Color.White;
            btn_resimsec.Image = Properties.Resources.editphoto;
            btn_resimsec.ImageAlign = ContentAlignment.MiddleLeft;
            btn_resimsec.Location = new Point(1015, 385);
            btn_resimsec.Name = "btn_resimsec";
            btn_resimsec.Size = new Size(158, 56);
            btn_resimsec.TabIndex = 28;
            btn_resimsec.Text = "       Resim Seç";
            btn_resimsec.UseVisualStyleBackColor = false;
            btn_resimsec.Click += btn_resimsec_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.White;
            btn_clean.Image = Properties.Resources.edit2_Photoroom1;
            btn_clean.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clean.Location = new Point(425, 385);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(158, 61);
            btn_clean.TabIndex = 27;
            btn_clean.Text = "Temizle";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.White;
            btn_update.Image = Properties.Resources.update_Photoroom;
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(425, 314);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(158, 62);
            btn_update.TabIndex = 26;
            btn_update.Text = "     Güncelle";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 289);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 17;
            label1.Text = "TC:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(24, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(795, 250);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(918, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(313, 320);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(24, 332);
            label7.Name = "label7";
            label7.Size = new Size(42, 24);
            label7.TabIndex = 18;
            label7.Text = "Ad:";
            // 
            // txtbox_updatesifre
            // 
            txtbox_updatesifre.Location = new Point(152, 453);
            txtbox_updatesifre.Name = "txtbox_updatesifre";
            txtbox_updatesifre.Size = new Size(157, 27);
            txtbox_updatesifre.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(22, 375);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 19;
            label8.Text = "Soyad:";
            // 
            // txtbox_updatesoyad
            // 
            txtbox_updatesoyad.Location = new Point(154, 372);
            txtbox_updatesoyad.Name = "txtbox_updatesoyad";
            txtbox_updatesoyad.Size = new Size(157, 27);
            txtbox_updatesoyad.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(22, 456);
            label9.Name = "label9";
            label9.Size = new Size(61, 24);
            label9.TabIndex = 20;
            label9.Text = "Şifre:";
            // 
            // txtbox_updatead
            // 
            txtbox_updatead.Location = new Point(154, 329);
            txtbox_updatead.Name = "txtbox_updatead";
            txtbox_updatead.Size = new Size(157, 27);
            txtbox_updatead.TabIndex = 23;
            // 
            // txtbox_updatetc
            // 
            txtbox_updatetc.Location = new Point(154, 286);
            txtbox_updatetc.MaxLength = 11;
            txtbox_updatetc.Name = "txtbox_updatetc";
            txtbox_updatetc.Size = new Size(157, 27);
            txtbox_updatetc.TabIndex = 22;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_logsil);
            tabPage3.Controls.Add(txtbox_id);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1322, 568);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_logsil
            // 
            btn_logsil.BackColor = Color.White;
            btn_logsil.ForeColor = Color.Black;
            btn_logsil.Location = new Point(237, 280);
            btn_logsil.Name = "btn_logsil";
            btn_logsil.Size = new Size(94, 46);
            btn_logsil.TabIndex = 3;
            btn_logsil.Text = "Log Sil";
            btn_logsil.UseVisualStyleBackColor = false;
            btn_logsil.Click += btn_logsil_Click;
            // 
            // txtbox_id
            // 
            txtbox_id.Location = new Point(70, 290);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(125, 27);
            txtbox_id.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(30, 290);
            label12.Name = "label12";
            label12.Size = new Size(34, 24);
            label12.TabIndex = 1;
            label12.Text = "Id:";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(8, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1215, 245);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.mountains_6865752_1280;
            ClientSize = new Size(1259, 595);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtbox_tc;
        private TextBox txtbox_ad;
        private TextBox txtbox_soyad;
        private TextBox txtbox_sifre;
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_clean;
        private Button btn_update;
        private Label label1;
        private DataGridView dataGridView2;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox txtbox_updatesifre;
        private Label label8;
        private TextBox txtbox_updatesoyad;
        private Label label9;
        private TextBox txtbox_updatead;
        private TextBox txtbox_updatetc;
        private Button btn_resimsec;
        private Button btn_back;
        private Button btn_back1;
        private TextBox txtbox_cinsiyet;
        private Label label10;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label11;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Button btn_logsil;
        private TextBox txtbox_id;
        private Label label12;
    }
}