namespace KutuphaneProjesi
{
    partial class formAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAnaSayfa));
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdunc
            // 
            this.btnOdunc.Image = global::KutuphaneProjesi.Properties.Resources.odunc;
            this.btnOdunc.Location = new System.Drawing.Point(296, 170);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(155, 115);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnTur
            // 
            this.btnTur.Image = global::KutuphaneProjesi.Properties.Resources.islem;
            this.btnTur.Location = new System.Drawing.Point(95, 170);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(155, 115);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Image = global::KutuphaneProjesi.Properties.Resources.ogrenci;
            this.btnOgrenci.Location = new System.Drawing.Point(296, 28);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(155, 115);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Image = global::KutuphaneProjesi.Properties.Resources.kitap;
            this.btnKitap.Location = new System.Drawing.Point(95, 28);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(155, 115);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 310);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Projesi";
            this.Load += new System.EventHandler(this.formAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
    }
}

