namespace Nesne_DönemProjesi
{
    partial class YöneticiEkrani
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.filmeklebtn = new System.Windows.Forms.Button();
            this.degerlendirmepuanitxt = new System.Windows.Forms.TextBox();
            this.yayinyilitxt = new System.Windows.Forms.TextBox();
            this.filmturutxt = new System.Windows.Forms.TextBox();
            this.oyunculartxt = new System.Windows.Forms.TextBox();
            this.yonetmentxt = new System.Windows.Forms.TextBox();
            this.filmaditxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.raporalbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Nesne_DönemProjesi.Properties.Resources.bunukullan;
            this.tabPage1.Controls.Add(this.listelebtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.guncellebtn);
            this.tabPage1.Controls.Add(this.filmeklebtn);
            this.tabPage1.Controls.Add(this.degerlendirmepuanitxt);
            this.tabPage1.Controls.Add(this.yayinyilitxt);
            this.tabPage1.Controls.Add(this.filmturutxt);
            this.tabPage1.Controls.Add(this.oyunculartxt);
            this.tabPage1.Controls.Add(this.yonetmentxt);
            this.tabPage1.Controls.Add(this.filmaditxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film Ekleme ve Güncelleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(559, 159);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(121, 33);
            this.listelebtn.TabIndex = 21;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(763, 187);
            this.dataGridView1.TabIndex = 20;
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(315, 160);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(170, 32);
            this.guncellebtn.TabIndex = 18;
            this.guncellebtn.Text = "GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // filmeklebtn
            // 
            this.filmeklebtn.Location = new System.Drawing.Point(130, 163);
            this.filmeklebtn.Name = "filmeklebtn";
            this.filmeklebtn.Size = new System.Drawing.Size(166, 29);
            this.filmeklebtn.TabIndex = 17;
            this.filmeklebtn.Text = "EKLE";
            this.filmeklebtn.UseVisualStyleBackColor = true;
            this.filmeklebtn.Click += new System.EventHandler(this.filmeklebtn_Click);
            // 
            // degerlendirmepuanitxt
            // 
            this.degerlendirmepuanitxt.Location = new System.Drawing.Point(559, 110);
            this.degerlendirmepuanitxt.Name = "degerlendirmepuanitxt";
            this.degerlendirmepuanitxt.Size = new System.Drawing.Size(125, 27);
            this.degerlendirmepuanitxt.TabIndex = 16;
            // 
            // yayinyilitxt
            // 
            this.yayinyilitxt.Location = new System.Drawing.Point(559, 77);
            this.yayinyilitxt.Name = "yayinyilitxt";
            this.yayinyilitxt.Size = new System.Drawing.Size(125, 27);
            this.yayinyilitxt.TabIndex = 15;
            // 
            // filmturutxt
            // 
            this.filmturutxt.Location = new System.Drawing.Point(559, 44);
            this.filmturutxt.Name = "filmturutxt";
            this.filmturutxt.Size = new System.Drawing.Size(125, 27);
            this.filmturutxt.TabIndex = 14;
            // 
            // oyunculartxt
            // 
            this.oyunculartxt.Location = new System.Drawing.Point(180, 106);
            this.oyunculartxt.Name = "oyunculartxt";
            this.oyunculartxt.Size = new System.Drawing.Size(125, 27);
            this.oyunculartxt.TabIndex = 13;
            // 
            // yonetmentxt
            // 
            this.yonetmentxt.Location = new System.Drawing.Point(180, 75);
            this.yonetmentxt.Name = "yonetmentxt";
            this.yonetmentxt.Size = new System.Drawing.Size(125, 27);
            this.yonetmentxt.TabIndex = 12;
            // 
            // filmaditxt
            // 
            this.filmaditxt.Location = new System.Drawing.Point(180, 44);
            this.filmaditxt.Name = "filmaditxt";
            this.filmaditxt.Size = new System.Drawing.Size(125, 27);
            this.filmaditxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(378, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Değerlendirme Puanı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(378, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yayın Yılı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(372, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Film Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Oyuncular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yönetmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(251, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Ekleme ve Güncelleme Ekranı";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Nesne_DönemProjesi.Properties.Resources.bunukullan;
            this.tabPage2.Controls.Add(this.raporalbtn);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film İstatistikleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // raporalbtn
            // 
            this.raporalbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raporalbtn.Location = new System.Drawing.Point(336, 310);
            this.raporalbtn.Name = "raporalbtn";
            this.raporalbtn.Size = new System.Drawing.Size(157, 40);
            this.raporalbtn.TabIndex = 4;
            this.raporalbtn.Text = "RAPOR AL";
            this.raporalbtn.UseVisualStyleBackColor = true;
            this.raporalbtn.Click += new System.EventHandler(this.raporalbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(440, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 224);
            this.listBox1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(507, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "En Çok Değerlendirilen Türler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(370, 224);
            this.dataGridView2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(28, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Puanı En Yüksek Filmler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "Yeni Bir Film Eklendi! HEMEN İNCELE!";
            this.notifyIcon1.BalloonTipTitle = "Hey Merhaba!";
            this.notifyIcon1.Text = "Yeni Bir Film Eklendi!";
            this.notifyIcon1.Visible = true;
            // 
            // YöneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "YöneticiEkrani";
            this.Text = "YöneticiEkrani2";
            this.Load += new System.EventHandler(this.YöneticiEkrani2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button guncellebtn;
        private Button filmeklebtn;
        private TextBox degerlendirmepuanitxt;
        private TextBox yayinyilitxt;
        private TextBox filmturutxt;
        private TextBox oyunculartxt;
        private TextBox yonetmentxt;
        private TextBox filmaditxt;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Label label1;
        private Button listelebtn;
        private Button raporalbtn;
        private ListBox listBox1;
        private Label label10;
        private DataGridView dataGridView2;
        private Label label9;
        private NotifyIcon notifyIcon1;
    }
}