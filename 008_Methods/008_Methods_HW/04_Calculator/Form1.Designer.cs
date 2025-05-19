namespace Calculator
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
            textBoxX = new TextBox();
            label1 = new Label();
            radioButtonDivide = new RadioButton();
            Calculate = new Button();
            label2 = new Label();
            textBoxY = new TextBox();
            label3 = new Label();
            radioButtonPower = new RadioButton();
            radioButtonConcatenate = new RadioButton();
            radioButtonModulo = new RadioButton();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(18, 53);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(123, 31);
            textBoxX.TabIndex = 0;
            textBoxX.TextAlign = HorizontalAlignment.Center;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter X (int)";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // radioButtonDivide
            // 
            radioButtonDivide.AutoSize = true;
            radioButtonDivide.Location = new Point(18, 109);
            radioButtonDivide.Name = "radioButtonDivide";
            radioButtonDivide.Size = new Size(75, 29);
            radioButtonDivide.TabIndex = 2;
            radioButtonDivide.TabStop = true;
            radioButtonDivide.Text = "X / Y";
            radioButtonDivide.UseVisualStyleBackColor = true;
            radioButtonDivide.CheckedChanged += radioButtonDivide_CheckedChanged;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(387, 118);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(125, 55);
            Calculate.TabIndex = 3;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Enter Y (int)";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(167, 53);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(123, 31);
            textBoxY.TabIndex = 4;
            textBoxY.TextAlign = HorizontalAlignment.Center;
            textBoxY.TextChanged += textBoxY_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 9);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Result";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButtonPower
            // 
            radioButtonPower.AutoSize = true;
            radioButtonPower.Location = new Point(18, 144);
            radioButtonPower.Name = "radioButtonPower";
            radioButtonPower.Size = new Size(80, 29);
            radioButtonPower.TabIndex = 8;
            radioButtonPower.TabStop = true;
            radioButtonPower.Text = "X ^ Y";
            radioButtonPower.UseVisualStyleBackColor = true;
            radioButtonPower.CheckedChanged += radioButtonPower_CheckedChanged;
            // 
            // radioButtonConcatenate
            // 
            radioButtonConcatenate.AutoSize = true;
            radioButtonConcatenate.Location = new Point(167, 109);
            radioButtonConcatenate.Name = "radioButtonConcatenate";
            radioButtonConcatenate.Size = new Size(108, 29);
            radioButtonConcatenate.TabIndex = 10;
            radioButtonConcatenate.TabStop = true;
            radioButtonConcatenate.Text = "\"X\" + \"Y\"";
            radioButtonConcatenate.UseVisualStyleBackColor = true;
            radioButtonConcatenate.CheckedChanged += radioButtonConcatenate_CheckedChanged;
            // 
            // radioButtonModulo
            // 
            radioButtonModulo.AutoSize = true;
            radioButtonModulo.Location = new Point(167, 144);
            radioButtonModulo.Name = "radioButtonModulo";
            radioButtonModulo.Size = new Size(83, 29);
            radioButtonModulo.TabIndex = 9;
            radioButtonModulo.TabStop = true;
            radioButtonModulo.Text = "X % Y";
            radioButtonModulo.UseVisualStyleBackColor = true;
            radioButtonModulo.CheckedChanged += radioButtonModulo_CheckedChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(316, 53);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(266, 31);
            textBoxResult.TabIndex = 11;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 200);
            Controls.Add(textBoxResult);
            Controls.Add(radioButtonConcatenate);
            Controls.Add(radioButtonModulo);
            Controls.Add(radioButtonPower);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxY);
            Controls.Add(Calculate);
            Controls.Add(radioButtonDivide);
            Controls.Add(label1);
            Controls.Add(textBoxX);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private Label label1;
        private RadioButton radioButtonDivide;
        private Button Calculate;
        private Label label2;
        private TextBox textBoxY;
        private Label label3;
        private RadioButton radioButtonPower;
        private RadioButton radioButtonConcatenate;
        private RadioButton radioButtonModulo;
        private TextBox textBoxResult;
    }
}
