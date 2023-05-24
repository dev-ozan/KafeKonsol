namespace KafeKonsol
{
    partial class UrunlerForm
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
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.label2 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(738, 27);
            this.label1.Name = "label1";
            this.label1.Size = new Size(173, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(964, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(191, 50);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(738, 92);
            this.label2.Name = "label2";
            this.label2.Size = new Size(200, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birim Fiyat :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new Point(964, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(191, 50);
            this.numericUpDown1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(747, 164);
            button1.Name = "button1";
            button1.Size = new Size(408, 64);
            button1.TabIndex = 11;
            button1.Text = "Ürünleri Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(720, 449);
            dataGridView1.TabIndex = 12;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 486);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(this.numericUpDown1);
            Controls.Add(this.label2);
            Controls.Add(this.textBox1);
            Controls.Add(this.label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UrunlerForm";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
    }
}