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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Location = new Point(544, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Seacrh";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 63);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 83);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Usia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Tgl Masuk Kerja";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(120, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(168, 83);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(385, 83);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(385, 104);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(120, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 71);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 10;
            label4.Text = "s/d";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 91);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 11;
            label5.Text = "s/d";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 112);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 12;
            label6.Text = "s/d";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 162);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 13;
            label7.Text = "Hasil Filter Data (Grid)";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(51, 332);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(132, 331);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 128);
            button4.Location = new Point(213, 331);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Location = new Point(294, 331);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "3";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nama Karyawan", "Usia", "Tgl Masuk Kerja" });
            comboBox1.Location = new Point(66, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 18;
            comboBox1.ValueMember = "3";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(201, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(321, 180);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown2);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
