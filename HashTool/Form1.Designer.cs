namespace HashTool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.hashbox = new System.Windows.Forms.TextBox();
            this.decryptbox = new System.Windows.Forms.TextBox();
            this.encodebut = new System.Windows.Forms.Button();
            this.hashtypecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decodebut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(13, 22);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(153, 20);
            this.passwordbox.TabIndex = 0;
            // 
            // hashbox
            // 
            this.hashbox.Location = new System.Drawing.Point(172, 22);
            this.hashbox.Multiline = true;
            this.hashbox.Name = "hashbox";
            this.hashbox.Size = new System.Drawing.Size(620, 257);
            this.hashbox.TabIndex = 1;
            // 
            // decryptbox
            // 
            this.decryptbox.Location = new System.Drawing.Point(172, 300);
            this.decryptbox.Multiline = true;
            this.decryptbox.Name = "decryptbox";
            this.decryptbox.Size = new System.Drawing.Size(620, 257);
            this.decryptbox.TabIndex = 2;
            // 
            // encodebut
            // 
            this.encodebut.Location = new System.Drawing.Point(13, 76);
            this.encodebut.Name = "encodebut";
            this.encodebut.Size = new System.Drawing.Size(153, 23);
            this.encodebut.TabIndex = 3;
            this.encodebut.Text = "Encode";
            this.encodebut.UseVisualStyleBackColor = true;
            this.encodebut.Click += new System.EventHandler(this.encodebut_Click);
            // 
            // hashtypecombo
            // 
            this.hashtypecombo.FormattingEnabled = true;
            this.hashtypecombo.Items.AddRange(new object[] {
            "Base64",
            "Hex",
            "MD5",
            "SHA256"});
            this.hashtypecombo.Location = new System.Drawing.Point(13, 49);
            this.hashtypecombo.Name = "hashtypecombo";
            this.hashtypecombo.Size = new System.Drawing.Size(153, 21);
            this.hashtypecombo.TabIndex = 4;
            this.hashtypecombo.Text = "Hash Type";
            this.hashtypecombo.SelectedIndexChanged += new System.EventHandler(this.hashtypecombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decrypted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Passowrd Hash";
            // 
            // decodebut
            // 
            this.decodebut.Location = new System.Drawing.Point(13, 105);
            this.decodebut.Name = "decodebut";
            this.decodebut.Size = new System.Drawing.Size(153, 23);
            this.decodebut.TabIndex = 8;
            this.decodebut.Text = "Decode";
            this.decodebut.UseVisualStyleBackColor = true;
            this.decodebut.Click += new System.EventHandler(this.decodebut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.decodebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashtypecombo);
            this.Controls.Add(this.encodebut);
            this.Controls.Add(this.decryptbox);
            this.Controls.Add(this.hashbox);
            this.Controls.Add(this.passwordbox);
            this.Name = "Form1";
            this.Text = "HashTool | By Rocsych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox hashbox;
        private System.Windows.Forms.TextBox decryptbox;
        private System.Windows.Forms.Button encodebut;
        private System.Windows.Forms.ComboBox hashtypecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decodebut;
    }
}

