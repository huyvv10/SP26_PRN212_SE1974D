namespace WinFormsStudentMan
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(142, 121);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(245, 121);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(142, 216);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(142, 259);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Java";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(142, 303);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Python";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 216);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Skills";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 34);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 8;
            label3.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 82);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 166);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Birthdate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 350);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 92);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 353);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 12;
            label6.Text = "Other";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(522, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 389);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 465);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label6;
        private GroupBox groupBox1;
    }
}
