namespace Калькулятор
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
            button2 = new Button();
            btnCalc = new Button();
            btnPlus = new Button();
            button5 = new Button();
            button6 = new Button();
            btnMul = new Button();
            button8 = new Button();
            Disp = new TextBox();
            button9 = new Button();
            button11 = new Button();
            button10 = new Button();
            buttonC = new Button();
            button13 = new Button();
            button14 = new Button();
            btnMinus = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 166);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 130);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(48, 166);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(30, 30);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "=";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(84, 166);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(30, 30);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // button5
            // 
            button5.Location = new Point(84, 130);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 4;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(48, 94);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(120, 130);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(30, 30);
            btnMul.TabIndex = 6;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 130);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 7;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Disp
            // 
            Disp.Location = new Point(12, 12);
            Disp.Name = "Disp";
            Disp.Size = new Size(138, 25);
            Disp.TabIndex = 8;
            Disp.KeyPress += Disp_KeyPress;
            // 
            // button9
            // 
            button9.Location = new Point(12, 55);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 9;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.Location = new Point(84, 55);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 11;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(48, 55);
            button10.Name = "button10";
            button10.Size = new Size(30, 30);
            button10.TabIndex = 12;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.Red;
            buttonC.Location = new Point(120, 55);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(30, 30);
            buttonC.TabIndex = 13;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // button13
            // 
            button13.Location = new Point(12, 94);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 14;
            button13.Text = "4";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(84, 94);
            button14.Name = "button14";
            button14.Size = new Size(30, 30);
            button14.TabIndex = 15;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(120, 166);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 30);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(120, 94);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(30, 30);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(159, 202);
            Controls.Add(btnDiv);
            Controls.Add(btnMinus);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(buttonC);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(Disp);
            Controls.Add(button8);
            Controls.Add(btnMul);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnPlus);
            Controls.Add(btnCalc);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnCalc;
        private Button btnPlus;
        private Button button5;
        private Button button6;
        private Button btnMul;
        private Button button8;
        private TextBox Disp;
        private Button button9;
        private Button button11;
        private Button button10;
        private Button buttonC;
        private Button button13;
        private Button button14;
        private Button btnMinus;
        private Button btnDiv;
    }
}