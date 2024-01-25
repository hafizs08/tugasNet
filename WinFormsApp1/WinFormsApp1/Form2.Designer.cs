namespace WinFormsApp1
{
    partial class Form2
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Entry data";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Nama";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(390, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 95);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "Usia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 66);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 6;
            label5.Text = "Tgl Masuk Kerja";
            // 
            // button1
            // 
            button1.Location = new Point(366, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(390, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(122, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}