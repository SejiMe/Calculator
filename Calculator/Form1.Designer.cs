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
            TextDisplay = new TextBox();
            Btn1 = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn0 = new Button();
            BtnAdd = new Button();
            BtnSub = new Button();
            BtnDivide = new Button();
            BtnMultiply = new Button();
            BtnEquals = new Button();
            BtnClear = new Button();
            BtnDel = new Button();
            SuspendLayout();
            // 
            // TextDisplay
            // 
            TextDisplay.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TextDisplay.Location = new Point(41, 24);
            TextDisplay.MaxLength = 1000;
            TextDisplay.Multiline = true;
            TextDisplay.Name = "TextDisplay";
            TextDisplay.ReadOnly = true;
            TextDisplay.Size = new Size(280, 41);
            TextDisplay.TabIndex = 0;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(41, 72);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 40);
            Btn1.TabIndex = 1;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(246, 72);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 40);
            Btn3.TabIndex = 2;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(144, 72);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 40);
            Btn2.TabIndex = 3;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(41, 124);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 40);
            Btn4.TabIndex = 4;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(144, 124);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 40);
            Btn5.TabIndex = 5;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(246, 124);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 40);
            Btn6.TabIndex = 6;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(246, 179);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 40);
            Btn9.TabIndex = 9;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(144, 179);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(75, 40);
            Btn8.TabIndex = 8;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(41, 179);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 40);
            Btn7.TabIndex = 7;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(144, 234);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(75, 40);
            Btn0.TabIndex = 10;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(339, 124);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 40);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSub
            // 
            BtnSub.Location = new Point(339, 179);
            BtnSub.Name = "BtnSub";
            BtnSub.Size = new Size(75, 40);
            BtnSub.TabIndex = 12;
            BtnSub.Text = "-";
            BtnSub.UseVisualStyleBackColor = true;
            BtnSub.Click += BtnSub_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.Location = new Point(339, 234);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(75, 40);
            BtnDivide.TabIndex = 13;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            BtnDivide.Click += BtnDivide_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.Location = new Point(246, 234);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(75, 40);
            BtnMultiply.TabIndex = 14;
            BtnMultiply.Text = "X";
            BtnMultiply.UseVisualStyleBackColor = true;
            BtnMultiply.Click += BtnMultiply_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.Location = new Point(41, 234);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(75, 40);
            BtnEquals.TabIndex = 15;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = true;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(339, 71);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 40);
            BtnClear.TabIndex = 16;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnDel
            // 
            BtnDel.Location = new Point(339, 24);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(75, 40);
            BtnDel.TabIndex = 17;
            BtnDel.Text = "Del";
            BtnDel.UseVisualStyleBackColor = true;
            BtnDel.Click += BtnDel_Click;
            // 
            // Form1
            // 
            AcceptButton = BtnEquals;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 306);
            Controls.Add(BtnDel);
            Controls.Add(BtnClear);
            Controls.Add(BtnEquals);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnDivide);
            Controls.Add(BtnSub);
            Controls.Add(BtnAdd);
            Controls.Add(Btn0);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(Btn1);
            Controls.Add(TextDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextDisplay;
        private Button Btn1;
        private Button Btn3;
        private Button Btn2;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button Btn0;
        private Button BtnAdd;
        private Button BtnSub;
        private Button BtnDivide;
        private Button BtnMultiply;
        private Button BtnEquals;
        private Button BtnClear;
        private Button BtnDel;
    }
}