namespace Nesne_DönemProjesi
{
    partial class kullanicigirisekrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.radioButtonstandart = new System.Windows.Forms.RadioButton();
            this.radioButtonpremium = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULLANICI GİRİŞ EKRANI";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(264, 68);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(125, 27);
            this.kullaniciaditxt.TabIndex = 3;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(264, 134);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(125, 27);
            this.sifretxt.TabIndex = 4;
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.Location = new System.Drawing.Point(284, 273);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(204, 52);
            this.GirisYapBtn.TabIndex = 7;
            this.GirisYapBtn.Text = "GİRİŞ YAP";
            this.GirisYapBtn.UseVisualStyleBackColor = true;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // radioButtonstandart
            // 
            this.radioButtonstandart.AutoSize = true;
            this.radioButtonstandart.Location = new System.Drawing.Point(191, 180);
            this.radioButtonstandart.Name = "radioButtonstandart";
            this.radioButtonstandart.Size = new System.Drawing.Size(86, 24);
            this.radioButtonstandart.TabIndex = 8;
            this.radioButtonstandart.TabStop = true;
            this.radioButtonstandart.Text = "Standart";
            this.radioButtonstandart.UseVisualStyleBackColor = true;
            this.radioButtonstandart.CheckedChanged += new System.EventHandler(this.radioButtonstandart_CheckedChanged);
            // 
            // radioButtonpremium
            // 
            this.radioButtonpremium.AutoSize = true;
            this.radioButtonpremium.Location = new System.Drawing.Point(416, 180);
            this.radioButtonpremium.Name = "radioButtonpremium";
            this.radioButtonpremium.Size = new System.Drawing.Size(89, 24);
            this.radioButtonpremium.TabIndex = 9;
            this.radioButtonpremium.TabStop = true;
            this.radioButtonpremium.Text = "Premium";
            this.radioButtonpremium.UseVisualStyleBackColor = true;
            // 
            // kullanicigirisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nesne_DönemProjesi.Properties.Resources.bunukullan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonpremium);
            this.Controls.Add(this.radioButtonstandart);
            this.Controls.Add(this.GirisYapBtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kullanicigirisekrani";
            this.Text = "kullanicigirisekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kullaniciaditxt;
        private TextBox sifretxt;
        private Button GirisYapBtn;
        private RadioButton radioButtonstandart;
        private RadioButton radioButtonpremium;
    }
}