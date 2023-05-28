namespace InterfacesDemo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTaban = new System.Windows.Forms.TextBox();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bKosesizHesapla = new System.Windows.Forms.Button();
            this.btnKoseliHesapla = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taban";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yükseklik";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKoseliHesapla);
            this.groupBox1.Controls.Add(this.tbYukseklik);
            this.groupBox1.Controls.Add(this.tbTaban);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Köşeli";
            // 
            // tbTaban
            // 
            this.tbTaban.Location = new System.Drawing.Point(85, 25);
            this.tbTaban.Name = "tbTaban";
            this.tbTaban.Size = new System.Drawing.Size(100, 23);
            this.tbTaban.TabIndex = 1;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(84, 58);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(100, 23);
            this.tbYukseklik.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bKosesizHesapla);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Köşesiz";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yarı Çap";
            // 
            // bKosesizHesapla
            // 
            this.bKosesizHesapla.Location = new System.Drawing.Point(110, 109);
            this.bKosesizHesapla.Name = "bKosesizHesapla";
            this.bKosesizHesapla.Size = new System.Drawing.Size(75, 23);
            this.bKosesizHesapla.TabIndex = 3;
            this.bKosesizHesapla.Text = "Hesapla";
            this.bKosesizHesapla.UseVisualStyleBackColor = true;
            this.bKosesizHesapla.Click += new System.EventHandler(this.bKosesizHesapla_Click);
            // 
            // btnKoseliHesapla
            // 
            this.btnKoseliHesapla.Location = new System.Drawing.Point(109, 109);
            this.btnKoseliHesapla.Name = "btnKoseliHesapla";
            this.btnKoseliHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnKoseliHesapla.TabIndex = 3;
            this.btnKoseliHesapla.Text = "Hesapla";
            this.btnKoseliHesapla.UseVisualStyleBackColor = true;
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.Location = new System.Drawing.Point(12, 155);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(43, 15);
            this.lSonuc.TabIndex = 3;
            this.lSonuc.Text = "lSonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 215);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnKoseliHesapla;
        private TextBox tbYukseklik;
        private TextBox tbTaban;
        private GroupBox groupBox2;
        private Button bKosesizHesapla;
        private TextBox textBox2;
        private Label label3;
        private Label lSonuc;
    }
}