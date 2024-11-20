namespace ogrenciotomasyonu.ıvır_zıvır
{
    partial class Profil
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtdogumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(348, 129);
            this.txtad.Name = "txtad";
            this.txtad.ReadOnly = true;
            this.txtad.Size = new System.Drawing.Size(141, 22);
            this.txtad.TabIndex = 60;
            this.txtad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(261, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "E-mail";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(348, 170);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.ReadOnly = true;
            this.txtsoyad.Size = new System.Drawing.Size(141, 22);
            this.txtsoyad.TabIndex = 61;
            this.txtsoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(287, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Soyad";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(348, 255);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(166, 22);
            this.txtemail.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(177, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "Doğum Tarihi";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(13, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 27);
            this.button5.TabIndex = 66;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtdogumtarihi
            // 
            this.txtdogumtarihi.Location = new System.Drawing.Point(348, 312);
            this.txtdogumtarihi.Mask = "00/00/0000";
            this.txtdogumtarihi.Name = "txtdogumtarihi";
            this.txtdogumtarihi.ReadOnly = true;
            this.txtdogumtarihi.Size = new System.Drawing.Size(100, 22);
            this.txtdogumtarihi.TabIndex = 67;
            this.txtdogumtarihi.ValidatingType = typeof(System.DateTime);
            this.txtdogumtarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtdogumtarihi_MaskInputRejected);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(348, 216);
            this.txttel.Mask = "(999) 000-0000";
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.Size = new System.Drawing.Size(141, 22);
            this.txttel.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "label6";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(688, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtdogumtarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtemail);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox txtdogumtarihi;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.Label label6;
    }
}