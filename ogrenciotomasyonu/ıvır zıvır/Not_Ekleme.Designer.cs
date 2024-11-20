namespace ogrenciotomasyonu.ıvır_zıvır
{
    partial class Not_Ekleme
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
            this.dataGridViewNotlar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotlar
            // 
            this.dataGridViewNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotlar.Location = new System.Drawing.Point(30, 63);
            this.dataGridViewNotlar.Name = "dataGridViewNotlar";
            this.dataGridViewNotlar.RowHeadersWidth = 51;
            this.dataGridViewNotlar.RowTemplate.Height = 24;
            this.dataGridViewNotlar.Size = new System.Drawing.Size(1145, 508);
            this.dataGridViewNotlar.TabIndex = 0;
            this.dataGridViewNotlar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotlar_CellEndEdit_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Not_Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewNotlar);
            this.Name = "Not_Ekleme";
            this.Text = "Not_Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotlar;
        private System.Windows.Forms.Button button1;
    }
}