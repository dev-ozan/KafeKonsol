namespace KafeKonsol
{
    partial class SiparisForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 8);
            label1.Name = "label1";
            label1.Size = new Size(94, 45);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 8);
            label2.Name = "label2";
            label2.Size = new Size(92, 45);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.BackColor = Color.LightCoral;
            label3.Location = new Point(804, 169);
            label3.Name = "label3";
            label3.Size = new Size(459, 409);
            label3.TabIndex = 2;
            label3.Text = "00";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1165, 613);
            label4.Name = "label4";
            label4.Size = new Size(83, 45);
            label4.TabIndex = 3;
            label4.Text = "0.00";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(828, 613);
            label5.Name = "label5";
            label5.Size = new Size(241, 45);
            label5.TabIndex = 4;
            label5.Text = "Odeme Tutarı :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(804, 18);
            label6.Name = "label6";
            label6.Size = new Size(223, 45);
            label6.TabIndex = 5;
            label6.Text = "Masa Seçimi :";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(433, 72);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 50);
            numericUpDown2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(617, 72);
            button1.Name = "button1";
            button1.Size = new Size(139, 50);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(1005, 80);
            button2.Name = "button2";
            button2.Size = new Size(258, 53);
            button2.TabIndex = 9;
            button2.Text = "Taşı";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(804, 786);
            button3.Name = "button3";
            button3.Size = new Size(475, 83);
            button3.TabIndex = 10;
            button3.Text = "Anasayfaya Dön";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(804, 684);
            button4.Name = "button4";
            button4.Size = new Size(218, 82);
            button4.TabIndex = 11;
            button4.Text = "Sipariş İptal";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(1052, 685);
            button5.Name = "button5";
            button5.Size = new Size(227, 81);
            button5.TabIndex = 12;
            button5.Text = "Ödeme Al";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(700, 710);
            dataGridView1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 53);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(804, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 53);
            comboBox2.TabIndex = 15;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1462, 917);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(1488, 988);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Siparişler";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}