namespace WinFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPoprawnosc = new System.Windows.Forms.TextBox();
            this.lPoprawnosc = new System.Windows.Forms.Label();
            this.bSprawdzPoprawnosc = new System.Windows.Forms.Button();
            this.tbCalyIBAN = new System.Windows.Forms.TextBox();
            this.lCalyIBAN = new System.Windows.Forms.Label();
            this.bGenerujIBAN = new System.Windows.Forms.Button();
            this.tbIBANnieznany = new System.Windows.Forms.TextBox();
            this.lIBANnieznany = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPoprawnosc);
            this.panel1.Controls.Add(this.lPoprawnosc);
            this.panel1.Controls.Add(this.bSprawdzPoprawnosc);
            this.panel1.Controls.Add(this.tbCalyIBAN);
            this.panel1.Controls.Add(this.lCalyIBAN);
            this.panel1.Controls.Add(this.bGenerujIBAN);
            this.panel1.Controls.Add(this.tbIBANnieznany);
            this.panel1.Controls.Add(this.lIBANnieznany);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 450);
            this.panel1.TabIndex = 0;
            // 
            // tbPoprawnosc
            // 
            this.tbPoprawnosc.Location = new System.Drawing.Point(316, 246);
            this.tbPoprawnosc.Name = "tbPoprawnosc";
            this.tbPoprawnosc.ReadOnly = true;
            this.tbPoprawnosc.Size = new System.Drawing.Size(291, 27);
            this.tbPoprawnosc.TabIndex = 7;
            // 
            // lPoprawnosc
            // 
            this.lPoprawnosc.AutoSize = true;
            this.lPoprawnosc.Location = new System.Drawing.Point(216, 246);
            this.lPoprawnosc.Name = "lPoprawnosc";
            this.lPoprawnosc.Size = new System.Drawing.Size(84, 20);
            this.lPoprawnosc.TabIndex = 6;
            this.lPoprawnosc.Text = "Poprawny?!";
            // 
            // bSprawdzPoprawnosc
            // 
            this.bSprawdzPoprawnosc.Location = new System.Drawing.Point(316, 188);
            this.bSprawdzPoprawnosc.Name = "bSprawdzPoprawnosc";
            this.bSprawdzPoprawnosc.Size = new System.Drawing.Size(181, 29);
            this.bSprawdzPoprawnosc.TabIndex = 5;
            this.bSprawdzPoprawnosc.Text = "Sprawdź poprawność";
            this.bSprawdzPoprawnosc.UseVisualStyleBackColor = true;
            this.bSprawdzPoprawnosc.Click += new System.EventHandler(this.bSprawdzPoprawnosc_Click);
            // 
            // tbCalyIBAN
            // 
            this.tbCalyIBAN.Location = new System.Drawing.Point(316, 132);
            this.tbCalyIBAN.Name = "tbCalyIBAN";
            this.tbCalyIBAN.ReadOnly = true;
            this.tbCalyIBAN.Size = new System.Drawing.Size(291, 27);
            this.tbCalyIBAN.TabIndex = 4;
            // 
            // lCalyIBAN
            // 
            this.lCalyIBAN.AutoSize = true;
            this.lCalyIBAN.Location = new System.Drawing.Point(214, 132);
            this.lCalyIBAN.Name = "lCalyIBAN";
            this.lCalyIBAN.Size = new System.Drawing.Size(86, 20);
            this.lCalyIBAN.TabIndex = 3;
            this.lCalyIBAN.Text = "Cały numer:";
            // 
            // bGenerujIBAN
            // 
            this.bGenerujIBAN.Location = new System.Drawing.Point(316, 78);
            this.bGenerujIBAN.Name = "bGenerujIBAN";
            this.bGenerujIBAN.Size = new System.Drawing.Size(184, 29);
            this.bGenerujIBAN.TabIndex = 2;
            this.bGenerujIBAN.Text = "Generuj cały IBAN";
            this.bGenerujIBAN.UseVisualStyleBackColor = true;
            this.bGenerujIBAN.Click += new System.EventHandler(this.bGenerujIBAN_Click);
            this.bGenerujIBAN.MouseHover += new System.EventHandler(this.bGenerujIBAN_MouseHover);
            // 
            // tbIBANnieznany
            // 
            this.tbIBANnieznany.Location = new System.Drawing.Point(316, 26);
            this.tbIBANnieznany.MaxLength = 28;
            this.tbIBANnieznany.Name = "tbIBANnieznany";
            this.tbIBANnieznany.Size = new System.Drawing.Size(294, 27);
            this.tbIBANnieznany.TabIndex = 1;
            this.tbIBANnieznany.TextChanged += new System.EventHandler(this.tbIBANnieznany_TextChanged);
            this.tbIBANnieznany.MouseLeave += new System.EventHandler(this.tbIBANnieznany_MouseLeave);
            // 
            // lIBANnieznany
            // 
            this.lIBANnieznany.AutoSize = true;
            this.lIBANnieznany.Location = new System.Drawing.Point(28, 26);
            this.lIBANnieznany.Name = "lIBANnieznany";
            this.lIBANnieznany.Size = new System.Drawing.Size(272, 20);
            this.lIBANnieznany.TabIndex = 0;
            this.lIBANnieznany.Text = "IBAN z nieznanymi cyframi kontrolnymi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "IBAN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bGenerujIBAN;
        private TextBox tbIBANnieznany;
        private Label lIBANnieznany;
        private Button bSprawdzPoprawnosc;
        private TextBox tbCalyIBAN;
        private Label lCalyIBAN;
        private Label lPoprawnosc;
        private TextBox tbPoprawnosc;
    }
}