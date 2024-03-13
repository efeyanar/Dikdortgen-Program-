namespace Dikdörtgen_Alanı_ve_Çevresi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kisa = new System.Windows.Forms.TextBox();
            this.uzun = new System.Windows.Forms.TextBox();
            this.alan = new System.Windows.Forms.RadioButton();
            this.cevre = new System.Windows.Forms.RadioButton();
            this.buton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzun Kenarı Giriniz (Santimetre):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kısa Kenarı Giriniz (Santimetre) :";
            // 
            // kisa
            // 
            this.kisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisa.Location = new System.Drawing.Point(435, 117);
            this.kisa.Multiline = true;
            this.kisa.Name = "kisa";
            this.kisa.Size = new System.Drawing.Size(162, 29);
            this.kisa.TabIndex = 2;
            // 
            // uzun
            // 
            this.uzun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uzun.Location = new System.Drawing.Point(435, 60);
            this.uzun.Multiline = true;
            this.uzun.Name = "uzun";
            this.uzun.Size = new System.Drawing.Size(162, 29);
            this.uzun.TabIndex = 2;
            this.uzun.TextChanged += new System.EventHandler(this.uzun_TextChanged);
            // 
            // alan
            // 
            this.alan.AutoSize = true;
            this.alan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alan.Location = new System.Drawing.Point(72, 174);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(173, 33);
            this.alan.TabIndex = 3;
            this.alan.TabStop = true;
            this.alan.Text = "Alan Hesapla";
            this.alan.UseVisualStyleBackColor = true;
            this.alan.CheckedChanged += new System.EventHandler(this.alan_CheckedChanged);
            // 
            // cevre
            // 
            this.cevre.AutoSize = true;
            this.cevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevre.Location = new System.Drawing.Point(259, 174);
            this.cevre.Name = "cevre";
            this.cevre.Size = new System.Drawing.Size(190, 33);
            this.cevre.TabIndex = 4;
            this.cevre.TabStop = true;
            this.cevre.Text = "Çevre Hesapla";
            this.cevre.UseVisualStyleBackColor = true;
            // 
            // buton
            // 
            this.buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton.Location = new System.Drawing.Point(73, 226);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(129, 54);
            this.buton.TabIndex = 5;
            this.buton.Text = "Hesapla";
            this.buton.UseVisualStyleBackColor = true;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(263, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "_________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buton);
            this.Controls.Add(this.cevre);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.uzun);
            this.Controls.Add(this.kisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kisa;
        private System.Windows.Forms.TextBox uzun;
        private System.Windows.Forms.RadioButton alan;
        private System.Windows.Forms.RadioButton cevre;
        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.Label label3;
    }
}

