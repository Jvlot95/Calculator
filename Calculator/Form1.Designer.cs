namespace Calculator
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comma = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.solution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comma
            // 
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comma.Location = new System.Drawing.Point(89, 300);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(70, 70);
            this.comma.TabIndex = 11;
            this.comma.Text = ",";
            this.comma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(263, 72);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 70);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(263, 148);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 70);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(339, 148);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 70);
            this.divide.TabIndex = 15;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(339, 72);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(70, 70);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(339, 300);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 70);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(263, 224);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(70, 70);
            this.percent.TabIndex = 18;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(13, 300);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(70, 70);
            this.zero.TabIndex = 19;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(165, 227);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 70);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(89, 227);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 70);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(13, 227);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 70);
            this.one.TabIndex = 22;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(13, 153);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 70);
            this.four.TabIndex = 23;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(13, 77);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 70);
            this.seven.TabIndex = 24;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(89, 77);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 70);
            this.eight.TabIndex = 25;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(165, 77);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 70);
            this.nine.TabIndex = 26;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(89, 153);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 70);
            this.five.TabIndex = 27;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(165, 153);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 70);
            this.six.TabIndex = 28;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            // 
            // solution
            // 
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution.Location = new System.Drawing.Point(339, 224);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(70, 70);
            this.solution.TabIndex = 29;
            this.solution.Text = "=";
            this.solution.UseVisualStyleBackColor = true;
            this.solution.Click += new System.EventHandler(this.solution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(422, 382);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button solution;
    }
}

