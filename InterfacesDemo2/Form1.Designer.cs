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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ddlSekil = new ComboBox();
            btnKoseliHesapla = new Button();
            tbYukseklik = new TextBox();
            tbTaban = new TextBox();
            groupBox2 = new GroupBox();
            cbPi = new CheckBox();
            btnKosesizHesapla = new Button();
            tbYaricap = new TextBox();
            label3 = new Label();
            lSonuc = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Taban";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Yükseklik";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlSekil);
            groupBox1.Controls.Add(btnKoseliHesapla);
            groupBox1.Controls.Add(tbYukseklik);
            groupBox1.Controls.Add(tbTaban);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Köşeli";
            // 
            // ddlSekil
            // 
            ddlSekil.FormattingEnabled = true;
            ddlSekil.Location = new Point(22, 109);
            ddlSekil.Name = "ddlSekil";
            ddlSekil.Size = new Size(81, 23);
            ddlSekil.TabIndex = 4;
            // 
            // btnKoseliHesapla
            // 
            btnKoseliHesapla.Location = new Point(109, 109);
            btnKoseliHesapla.Name = "btnKoseliHesapla";
            btnKoseliHesapla.Size = new Size(75, 23);
            btnKoseliHesapla.TabIndex = 3;
            btnKoseliHesapla.Text = "Hesapla";
            btnKoseliHesapla.UseVisualStyleBackColor = true;
            btnKoseliHesapla.Click += btnKoseliHesapla_Click;
            // 
            // tbYukseklik
            // 
            tbYukseklik.Location = new Point(84, 58);
            tbYukseklik.Name = "tbYukseklik";
            tbYukseklik.Size = new Size(100, 23);
            tbYukseklik.TabIndex = 1;
            // 
            // tbTaban
            // 
            tbTaban.Location = new Point(85, 25);
            tbTaban.Name = "tbTaban";
            tbTaban.Size = new Size(100, 23);
            tbTaban.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPi);
            groupBox2.Controls.Add(btnKosesizHesapla);
            groupBox2.Controls.Add(tbYaricap);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(214, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 140);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Köşesiz";
            // 
            // cbPi
            // 
            cbPi.AutoSize = true;
            cbPi.Location = new Point(85, 57);
            cbPi.Name = "cbPi";
            cbPi.Size = new Size(66, 19);
            cbPi.TabIndex = 4;
            cbPi.Text = "Pi Uzun";
            cbPi.UseVisualStyleBackColor = true;
            // 
            // btnKosesizHesapla
            // 
            btnKosesizHesapla.Location = new Point(110, 109);
            btnKosesizHesapla.Name = "btnKosesizHesapla";
            btnKosesizHesapla.Size = new Size(75, 23);
            btnKosesizHesapla.TabIndex = 3;
            btnKosesizHesapla.Text = "Hesapla";
            btnKosesizHesapla.UseVisualStyleBackColor = true;
            btnKosesizHesapla.Click += btnKosesizHesapla_Click;
            // 
            // tbYaricap
            // 
            tbYaricap.Location = new Point(85, 25);
            tbYaricap.Name = "tbYaricap";
            tbYaricap.Size = new Size(100, 23);
            tbYaricap.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 28);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Yarı Çap";
            // 
            // lSonuc
            // 
            lSonuc.AutoSize = true;
            lSonuc.Location = new Point(12, 155);
            lSonuc.Name = "lSonuc";
            lSonuc.Size = new Size(43, 15);
            lSonuc.TabIndex = 3;
            lSonuc.Text = "lSonuc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 215);
            Controls.Add(lSonuc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnKoseliHesapla;
        private TextBox tbYukseklik;
        private TextBox tbTaban;
        private GroupBox groupBox2;
        private Button btnKosesizHesapla;
        private TextBox tbYaricap;
        private Label label3;
        private Label lSonuc;
        private CheckBox cbPi;
        private ComboBox ddlSekil;
    }
}