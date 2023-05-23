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
            dataGridView1 = new DataGridView();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.label2 = new Label();
            this.textBox3 = new TextBox();
            this.label3 = new Label();
            this.textBox4 = new TextBox();
            this.label4 = new Label();
            this.label5 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(681, 387);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(738, 27);
            this.label1.Name = "label1";
            this.label1.Size = new Size(164, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ekle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(922, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(200, 50);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(922, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(200, 50);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(738, 92);
            this.label2.Name = "label2";
            this.label2.Size = new Size(164, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Ekle";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(922, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(200, 50);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(738, 159);
            this.label3.Name = "label3";
            this.label3.Size = new Size(164, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Ekle";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(922, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(200, 50);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(738, 226);
            this.label4.Name = "label4";
            this.label4.Size = new Size(164, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(738, 292);
            this.label5.Name = "label5";
            this.label5.Size = new Size(164, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Ekle";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new Point(922, 290);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(200, 50);
            this.numericUpDown1.TabIndex = 10;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 486);
            Controls.Add(this.numericUpDown1);
            Controls.Add(this.label5);
            Controls.Add(this.textBox4);
            Controls.Add(this.label4);
            Controls.Add(this.textBox3);
            Controls.Add(this.label3);
            Controls.Add(this.textBox2);
            Controls.Add(this.label2);
            Controls.Add(this.textBox1);
            Controls.Add(this.label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UrunlerForm";
            Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
    }
}