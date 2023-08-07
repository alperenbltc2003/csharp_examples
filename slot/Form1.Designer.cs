namespace slot
{
    partial class Form9
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_kaybetme = new System.Windows.Forms.Label();
            this.lbl_kazanma = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.btn_bahis = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // lbl_kaybetme
            // 
            this.lbl_kaybetme.AutoSize = true;
            this.lbl_kaybetme.Location = new System.Drawing.Point(15, 222);
            this.lbl_kaybetme.Name = "lbl_kaybetme";
            this.lbl_kaybetme.Size = new System.Drawing.Size(35, 13);
            this.lbl_kaybetme.TabIndex = 18;
            this.lbl_kaybetme.Text = "label4";
            // 
            // lbl_kazanma
            // 
            this.lbl_kazanma.AutoSize = true;
            this.lbl_kazanma.Location = new System.Drawing.Point(15, 203);
            this.lbl_kazanma.Name = "lbl_kazanma";
            this.lbl_kazanma.Size = new System.Drawing.Size(35, 13);
            this.lbl_kazanma.TabIndex = 17;
            this.lbl_kazanma.Text = "label3";
            this.lbl_kazanma.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Location = new System.Drawing.Point(15, 30);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(35, 13);
            this.lbl_durum.TabIndex = 16;
            this.lbl_durum.Text = "label2";
            this.lbl_durum.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Location = new System.Drawing.Point(15, 8);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(35, 13);
            this.lbl_slot.TabIndex = 15;
            this.lbl_slot.Text = "label1";
            this.lbl_slot.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_oyna
            // 
            this.btn_oyna.Location = new System.Drawing.Point(290, 271);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(75, 23);
            this.btn_oyna.TabIndex = 11;
            this.btn_oyna.Text = "button2";
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(281, 245);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 20);
            this.txt_miktar.TabIndex = 20;
            // 
            // btn_bahis
            // 
            this.btn_bahis.Location = new System.Drawing.Point(18, 271);
            this.btn_bahis.Name = "btn_bahis";
            this.btn_bahis.Size = new System.Drawing.Size(75, 23);
            this.btn_bahis.TabIndex = 21;
            this.btn_bahis.Text = "button2";
            this.btn_bahis.UseVisualStyleBackColor = true;
            this.btn_bahis.Click += new System.EventHandler(this.btn_bahis_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::slot.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(265, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::slot.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(138, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::slot.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(18, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bahis);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_kaybetme);
            this.Controls.Add(this.lbl_kazanma);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_slot);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_oyna);
            this.Name = "Form9";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_kaybetme;
        private System.Windows.Forms.Label lbl_kazanma;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button btn_bahis;
    }
}

