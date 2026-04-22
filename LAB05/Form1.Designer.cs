namespace LAB05
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
            label1 = new Label();
            label2 = new Label();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            label3 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 49);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Первое число:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 90);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Второе число:";
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(427, 46);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(181, 27);
            txtFirstNumber.TabIndex = 2;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(427, 90);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(181, 27);
            txtSecondNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(288, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(400, 160);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(97, 32);
            btnSub.TabIndex = 5;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(512, 160);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(96, 32);
            btnMult.TabIndex = 6;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(625, 160);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(97, 32);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(427, 209);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(181, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 282);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 9;
            label3.Text = "Результат:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Lime;
            lblResult.Location = new Point(459, 282);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 35);
            lblResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Калькулятор V1.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnClear;
        private Label label3;
        private Label lblResult;
    }
}
