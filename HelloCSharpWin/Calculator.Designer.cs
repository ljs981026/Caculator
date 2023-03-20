namespace HelloCSharpWin
{
    partial class Calculator
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
            HelloLabel = new Label();
            Sum1 = new TextBox();
            Sum2 = new TextBox();
            SumNumbers = new Button();
            SumResult = new TextBox();
            SuspendLayout();
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Cursor = Cursors.Hand;
            HelloLabel.Location = new Point(39, 23);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(107, 15);
            HelloLabel.TabIndex = 0;
            HelloLabel.Text = "여기를 클릭하세요";
            HelloLabel.Click += HelloLabel_Click;
            // 
            // Sum1
            // 
            Sum1.Location = new Point(39, 57);
            Sum1.Name = "Sum1";
            Sum1.Size = new Size(100, 23);
            Sum1.TabIndex = 1;
            // 
            // Sum2
            // 
            Sum2.Location = new Point(158, 57);
            Sum2.Name = "Sum2";
            Sum2.Size = new Size(100, 23);
            Sum2.TabIndex = 2;
            // 
            // SumNumbers
            // 
            SumNumbers.Location = new Point(276, 57);
            SumNumbers.Name = "SumNumbers";
            SumNumbers.Size = new Size(75, 23);
            SumNumbers.TabIndex = 3;
            SumNumbers.Text = "=";
            SumNumbers.UseVisualStyleBackColor = true;
            SumNumbers.Click += SumNumbers_Click;
            // 
            // SumResult
            // 
            SumResult.Location = new Point(366, 57);
            SumResult.Name = "SumResult";
            SumResult.Size = new Size(100, 23);
            SumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 349);
            Controls.Add(SumResult);
            Controls.Add(SumNumbers);
            Controls.Add(Sum2);
            Controls.Add(Sum1);
            Controls.Add(HelloLabel);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloLabel;
        private TextBox Sum1;
        private TextBox Sum2;
        private Button SumNumbers;
        private TextBox SumResult;
    }
}