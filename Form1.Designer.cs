namespace Nesne_DönemProjesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.kullanicigirisibtn = new System.Windows.Forms.Button();
            this.yoneticigirisibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film Kütüphanesi Yönetim Sistemine Hoşgeldiniz!";
            // 
            // kullanicigirisibtn
            // 
            this.kullanicigirisibtn.Location = new System.Drawing.Point(243, 146);
            this.kullanicigirisibtn.Name = "kullanicigirisibtn";
            this.kullanicigirisibtn.Size = new System.Drawing.Size(319, 70);
            this.kullanicigirisibtn.TabIndex = 5;
            this.kullanicigirisibtn.Text = "Kullanıcı Girişi";
            this.kullanicigirisibtn.UseVisualStyleBackColor = true;
            this.kullanicigirisibtn.Click += new System.EventHandler(this.kullanicigirisibtn_Click);
            // 
            // yoneticigirisibtn
            // 
            this.yoneticigirisibtn.Location = new System.Drawing.Point(243, 259);
            this.yoneticigirisibtn.Name = "yoneticigirisibtn";
            this.yoneticigirisibtn.Size = new System.Drawing.Size(319, 65);
            this.yoneticigirisibtn.TabIndex = 6;
            this.yoneticigirisibtn.Text = "Yönetici Girişi";
            this.yoneticigirisibtn.UseVisualStyleBackColor = true;
            this.yoneticigirisibtn.Click += new System.EventHandler(this.yoneticigirisibtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yoneticigirisibtn);
            this.Controls.Add(this.kullanicigirisibtn);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Button kullanicigirisibtn;
        private Button yoneticigirisibtn;
    }
}