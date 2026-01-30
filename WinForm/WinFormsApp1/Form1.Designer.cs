namespace WinFormsApp1
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnSubstract = new Button();
            btnProduct = new Button();
            btnQuotien = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Paytone One", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(809, 48);
            label1.TabIndex = 0;
            label1.Text = "MY CALCULATOR";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 1;
            label2.Text = "Number 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(28, 148);
            label3.Name = "label3";
            label3.Size = new Size(121, 31);
            label3.TabIndex = 2;
            label3.Text = "Number 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(28, 217);
            label4.Name = "label4";
            label4.Size = new Size(80, 31);
            label4.TabIndex = 3;
            label4.Text = "Result";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = Color.FromArgb(224, 224, 224);
            txtNum1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(192, 72);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(471, 38);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.FromArgb(224, 224, 224);
            txtNum2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(192, 141);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(471, 38);
            txtNum2.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(224, 224, 224);
            txtResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(192, 210);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(471, 38);
            txtResult.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(25, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 51);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubstract.ForeColor = Color.Red;
            btnSubstract.Location = new Point(180, 290);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(139, 51);
            btnSubstract.TabIndex = 7;
            btnSubstract.Text = "&Substract";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.Red;
            btnProduct.Location = new Point(335, 290);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(139, 51);
            btnProduct.TabIndex = 7;
            btnProduct.Text = "Produc&t";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnQuotien
            // 
            btnQuotien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuotien.ForeColor = Color.Red;
            btnQuotien.Location = new Point(490, 290);
            btnQuotien.Name = "btnQuotien";
            btnQuotien.Size = new Size(139, 51);
            btnQuotien.TabIndex = 7;
            btnQuotien.Text = "&Quotien";
            btnQuotien.UseVisualStyleBackColor = true;
            btnQuotien.Click += btnQuotien_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(645, 290);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 51);
            btnClose.TabIndex = 7;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(809, 371);
            Controls.Add(btnClose);
            Controls.Add(btnQuotien);
            Controls.Add(btnProduct);
            Controls.Add(btnSubstract);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 255, 192);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSubstract;
        private Button btnProduct;
        private Button btnQuotien;
        private Button btnClose;
    }
}
