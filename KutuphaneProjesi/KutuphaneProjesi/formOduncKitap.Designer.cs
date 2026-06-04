namespace KutuphaneProjesi
{
    partial class formOduncKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOduncKitap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.gridOduncKitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.comboKitap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtAramaOgrenci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOduncKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboKitap);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAramaOgrenci);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Kitap Arama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapAl);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnKitapVer);
            this.groupBox3.Location = new System.Drawing.Point(417, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 138);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Image = global::KutuphaneProjesi.Properties.Resources.guncelle;
            this.btnKitapAl.Location = new System.Drawing.Point(259, 19);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(105, 105);
            this.btnKitapAl.TabIndex = 2;
            this.btnKitapAl.Text = "Kitap Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::KutuphaneProjesi.Properties.Resources.sil;
            this.btnSil.Location = new System.Drawing.Point(138, 19);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 105);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Image = global::KutuphaneProjesi.Properties.Resources.kaydet;
            this.btnKitapVer.Location = new System.Drawing.Point(16, 19);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(105, 105);
            this.btnKitapVer.TabIndex = 0;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // gridOduncKitaplar
            // 
            this.gridOduncKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOduncKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOduncKitaplar.Location = new System.Drawing.Point(12, 358);
            this.gridOduncKitaplar.Name = "gridOduncKitaplar";
            this.gridOduncKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOduncKitaplar.Size = new System.Drawing.Size(792, 387);
            this.gridOduncKitaplar.TabIndex = 8;
            this.gridOduncKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOduncKitaplar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(103, 27);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(189, 20);
            this.txtNo.TabIndex = 2;
            // 
            // comboKitap
            // 
            this.comboKitap.FormattingEnabled = true;
            this.comboKitap.Location = new System.Drawing.Point(103, 66);
            this.comboKitap.Name = "comboKitap";
            this.comboKitap.Size = new System.Drawing.Size(189, 21);
            this.comboKitap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(467, 19);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(302, 96);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // txtAramaOgrenci
            // 
            this.txtAramaOgrenci.Location = new System.Drawing.Point(103, 62);
            this.txtAramaOgrenci.Name = "txtAramaOgrenci";
            this.txtAramaOgrenci.Size = new System.Drawing.Size(189, 20);
            this.txtAramaOgrenci.TabIndex = 0;
            this.txtAramaOgrenci.TextChanged += new System.EventHandler(this.txtAramaOgrenci_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci Adı:";
            // 
            // formOduncKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 766);
            this.Controls.Add(this.gridOduncKitaplar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formOduncKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitap İşlemleri";
            this.Load += new System.EventHandler(this.formOduncKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOduncKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.DataGridView gridOduncKitaplar;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboKitap;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAramaOgrenci;
    }
}