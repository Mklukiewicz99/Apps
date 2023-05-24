namespace Calculator_WinForms
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
            tbScreen = new TextBox();
            Btn0 = new Button();
            BtnDot = new Button();
            BtnClear = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            BtnDiv = new Button();
            BtnMul = new Button();
            BtnMinus = new Button();
            BtnPlus = new Button();
            BtnEqual = new Button();
            SuspendLayout();
            // 
            // tbScreen
            // 
            tbScreen.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbScreen.Location = new Point(15, 9);
            tbScreen.Multiline = true;
            tbScreen.Name = "tbScreen";
            tbScreen.Size = new Size(482, 52);
            tbScreen.TabIndex = 0;
            tbScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // Btn0
            // 
            Btn0.BackColor = SystemColors.ActiveCaption;
            Btn0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn0.Location = new Point(15, 339);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(75, 73);
            Btn0.TabIndex = 1;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += OnBtnNumberClick;
            // 
            // BtnDot
            // 
            BtnDot.BackColor = SystemColors.ActiveCaption;
            BtnDot.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDot.Location = new Point(96, 339);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(75, 73);
            BtnDot.TabIndex = 2;
            BtnDot.Text = ".";
            BtnDot.UseVisualStyleBackColor = false;
            BtnDot.Click += OnBtnNumberClick;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Firebrick;
            BtnClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClear.Location = new Point(177, 339);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 73);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += OnBtnClearClick;
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.ActiveCaption;
            Btn1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1.Location = new Point(15, 260);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 73);
            Btn1.TabIndex = 4;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += OnBtnNumberClick;
            // 
            // Btn2
            // 
            Btn2.BackColor = SystemColors.ActiveCaption;
            Btn2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn2.Location = new Point(96, 260);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 73);
            Btn2.TabIndex = 5;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += OnBtnNumberClick;
            // 
            // Btn3
            // 
            Btn3.BackColor = SystemColors.ActiveCaption;
            Btn3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn3.Location = new Point(177, 260);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 73);
            Btn3.TabIndex = 6;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += OnBtnNumberClick;
            // 
            // Btn4
            // 
            Btn4.BackColor = SystemColors.ActiveCaption;
            Btn4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4.Location = new Point(15, 181);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 73);
            Btn4.TabIndex = 7;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += OnBtnNumberClick;
            // 
            // Btn5
            // 
            Btn5.BackColor = SystemColors.ActiveCaption;
            Btn5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn5.Location = new Point(96, 181);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 73);
            Btn5.TabIndex = 8;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += OnBtnNumberClick;
            // 
            // Btn6
            // 
            Btn6.BackColor = SystemColors.ActiveCaption;
            Btn6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn6.Location = new Point(177, 181);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 73);
            Btn6.TabIndex = 9;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += OnBtnNumberClick;
            // 
            // Btn7
            // 
            Btn7.BackColor = SystemColors.ActiveCaption;
            Btn7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn7.Location = new Point(15, 102);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 73);
            Btn7.TabIndex = 10;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += OnBtnNumberClick;
            // 
            // Btn8
            // 
            Btn8.BackColor = SystemColors.ActiveCaption;
            Btn8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn8.Location = new Point(96, 102);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(75, 73);
            Btn8.TabIndex = 11;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += OnBtnNumberClick;
            // 
            // Btn9
            // 
            Btn9.BackColor = SystemColors.ActiveCaption;
            Btn9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Btn9.Location = new Point(177, 102);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 73);
            Btn9.TabIndex = 12;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += OnBtnNumberClick;
            // 
            // BtnDiv
            // 
            BtnDiv.BackColor = Color.DarkGreen;
            BtnDiv.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDiv.Location = new Point(316, 102);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(75, 73);
            BtnDiv.TabIndex = 13;
            BtnDiv.Text = "/";
            BtnDiv.UseVisualStyleBackColor = false;
            BtnDiv.Click += OnBtnOperationClick;
            // 
            // BtnMul
            // 
            BtnMul.BackColor = Color.DarkGreen;
            BtnMul.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMul.Location = new Point(316, 181);
            BtnMul.Name = "BtnMul";
            BtnMul.Size = new Size(75, 73);
            BtnMul.TabIndex = 14;
            BtnMul.Text = "*";
            BtnMul.UseVisualStyleBackColor = false;
            BtnMul.Click += OnBtnOperationClick;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = Color.DarkGreen;
            BtnMinus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMinus.Location = new Point(316, 260);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(75, 73);
            BtnMinus.TabIndex = 15;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += OnBtnOperationClick;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.DarkGreen;
            BtnPlus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPlus.Location = new Point(316, 339);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(75, 73);
            BtnPlus.TabIndex = 16;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += OnBtnOperationClick;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = Color.DarkGreen;
            BtnEqual.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEqual.Location = new Point(422, 124);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(75, 266);
            BtnEqual.TabIndex = 17;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += OnBtnResultClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(530, 446);
            Controls.Add(BtnEqual);
            Controls.Add(BtnPlus);
            Controls.Add(BtnMinus);
            Controls.Add(BtnMul);
            Controls.Add(BtnDiv);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnClear);
            Controls.Add(BtnDot);
            Controls.Add(Btn0);
            Controls.Add(tbScreen);
            Name = "Form1";
            Text = "Form1";           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbScreen;
        private Button Btn0;
        private Button BtnDot;
        private Button BtnClear;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnDiv;
        private Button BtnMul;
        private Button BtnMinus;
        private Button BtnPlus;
        private Button BtnEqual;
    }
}