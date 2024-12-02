namespace CalculatorApplication
{
    partial class FrmCalculator
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
            LFN = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            txtBoxInput2 = new TextBox();
            label1 = new Label();
            lblDisplayTotal = new Label();
            BtnEqual = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // LFN
            // 
            LFN.AutoSize = true;
            LFN.Location = new Point(13, 23);
            LFN.Margin = new Padding(4, 0, 4, 0);
            LFN.Name = "LFN";
            LFN.Size = new Size(180, 19);
            LFN.TabIndex = 0;
            LFN.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Location = new Point(209, 20);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(227, 26);
            txtBoxInput1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "/", "+", "*", "-" });
            cbOperator.Location = new Point(257, 61);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 2;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Location = new Point(209, 98);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(227, 26);
            txtBoxInput2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 19);
            label1.TabIndex = 3;
            label1.Text = "Enter Second Number:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(209, 137);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(63, 19);
            lblDisplayTotal.TabIndex = 5;
            lblDisplayTotal.Text = "______";
            // 
            // BtnEqual
            // 
            BtnEqual.Font = new Font("Consolas", 14F);
            BtnEqual.Location = new Point(257, 168);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(121, 29);
            BtnEqual.TabIndex = 6;
            BtnEqual.Text = "Calculate";
            BtnEqual.UseVisualStyleBackColor = true;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 137);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 7;
            label2.Text = "Answer:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 323);
            Controls.Add(label2);
            Controls.Add(BtnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(txtBoxInput2);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(LFN);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LFN;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private TextBox txtBoxInput2;
        private Label label1;
        private Label lblDisplayTotal;
        private Button BtnEqual;
        private Label label2;
    }
}
