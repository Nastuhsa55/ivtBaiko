﻿namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sinus = new System.Windows.Forms.Button();
            this.logarithm = new System.Windows.Forms.Button();
            this.TwoToThePowerOf = new System.Windows.Forms.Button();
            this.XToThePowerOfTwo = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.RemainderOfTheDivision = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.ModuleOfX = new System.Windows.Forms.Button();
            this.Arcsine = new System.Windows.Forms.Button();
            this.Arccosine = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.DecimalLogarithm = new System.Windows.Forms.Button();
            this.HyperbolicCosine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Yellow;
            this.plus.Location = new System.Drawing.Point(123, 159);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(66, 26);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.buttonClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Yellow;
            this.minus.Location = new System.Drawing.Point(123, 191);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(66, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.buttonClick);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.Yellow;
            this.multiplication.Location = new System.Drawing.Point(199, 159);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(63, 26);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.buttonClick);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Yellow;
            this.division.Location = new System.Drawing.Point(199, 191);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(63, 23);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.buttonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 6;
            // 
            // sinus
            // 
            this.sinus.BackColor = System.Drawing.Color.Yellow;
            this.sinus.Location = new System.Drawing.Point(123, 128);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(66, 23);
            this.sinus.TabIndex = 7;
            this.sinus.Text = "sin";
            this.sinus.UseVisualStyleBackColor = false;
            this.sinus.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // logarithm
            // 
            this.logarithm.BackColor = System.Drawing.Color.Yellow;
            this.logarithm.Location = new System.Drawing.Point(199, 128);
            this.logarithm.Name = "logarithm";
            this.logarithm.Size = new System.Drawing.Size(63, 25);
            this.logarithm.TabIndex = 8;
            this.logarithm.Text = "log";
            this.logarithm.UseVisualStyleBackColor = false;
            this.logarithm.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // TwoToThePowerOf
            // 
            this.TwoToThePowerOf.BackColor = System.Drawing.Color.Yellow;
            this.TwoToThePowerOf.Location = new System.Drawing.Point(41, 128);
            this.TwoToThePowerOf.Name = "TwoToThePowerOf";
            this.TwoToThePowerOf.Size = new System.Drawing.Size(63, 23);
            this.TwoToThePowerOf.TabIndex = 9;
            this.TwoToThePowerOf.Text = "2^x";
            this.TwoToThePowerOf.UseVisualStyleBackColor = false;
            this.TwoToThePowerOf.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // XToThePowerOfTwo
            // 
            this.XToThePowerOfTwo.BackColor = System.Drawing.Color.Yellow;
            this.XToThePowerOfTwo.Location = new System.Drawing.Point(41, 159);
            this.XToThePowerOfTwo.Name = "XToThePowerOfTwo";
            this.XToThePowerOfTwo.Size = new System.Drawing.Size(63, 26);
            this.XToThePowerOfTwo.TabIndex = 10;
            this.XToThePowerOfTwo.Text = "x^2";
            this.XToThePowerOfTwo.UseVisualStyleBackColor = false;
            this.XToThePowerOfTwo.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.Yellow;
            this.Square.Location = new System.Drawing.Point(41, 191);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(63, 23);
            this.Square.TabIndex = 11;
            this.Square.Text = "square ";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // RemainderOfTheDivision
            // 
            this.RemainderOfTheDivision.BackColor = System.Drawing.Color.Yellow;
            this.RemainderOfTheDivision.Location = new System.Drawing.Point(41, 220);
            this.RemainderOfTheDivision.Name = "RemainderOfTheDivision";
            this.RemainderOfTheDivision.Size = new System.Drawing.Size(63, 23);
            this.RemainderOfTheDivision.TabIndex = 12;
            this.RemainderOfTheDivision.Text = "%";
            this.RemainderOfTheDivision.UseVisualStyleBackColor = false;
            this.RemainderOfTheDivision.Click += new System.EventHandler(this.buttonClick);
            // 
            // Cosinus
            // 
            this.Cosinus.BackColor = System.Drawing.Color.Yellow;
            this.Cosinus.Location = new System.Drawing.Point(123, 220);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(66, 23);
            this.Cosinus.TabIndex = 13;
            this.Cosinus.Text = "cos";
            this.Cosinus.UseVisualStyleBackColor = false;
            this.Cosinus.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Tangent
            // 
            this.Tangent.BackColor = System.Drawing.Color.Yellow;
            this.Tangent.Location = new System.Drawing.Point(199, 220);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(63, 23);
            this.Tangent.TabIndex = 14;
            this.Tangent.Text = "Tg";
            this.Tangent.UseVisualStyleBackColor = false;
            this.Tangent.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // ModuleOfX
            // 
            this.ModuleOfX.BackColor = System.Drawing.Color.Yellow;
            this.ModuleOfX.Location = new System.Drawing.Point(41, 249);
            this.ModuleOfX.Name = "ModuleOfX";
            this.ModuleOfX.Size = new System.Drawing.Size(63, 23);
            this.ModuleOfX.TabIndex = 15;
            this.ModuleOfX.Text = "|x|";
            this.ModuleOfX.UseVisualStyleBackColor = false;
            this.ModuleOfX.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Arcsine
            // 
            this.Arcsine.BackColor = System.Drawing.Color.Yellow;
            this.Arcsine.Location = new System.Drawing.Point(123, 249);
            this.Arcsine.Name = "Arcsine";
            this.Arcsine.Size = new System.Drawing.Size(66, 23);
            this.Arcsine.TabIndex = 16;
            this.Arcsine.Text = "asin";
            this.Arcsine.UseVisualStyleBackColor = false;
            this.Arcsine.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Arccosine
            // 
            this.Arccosine.BackColor = System.Drawing.Color.Yellow;
            this.Arccosine.Location = new System.Drawing.Point(199, 249);
            this.Arccosine.Name = "Arccosine";
            this.Arccosine.Size = new System.Drawing.Size(63, 23);
            this.Arccosine.TabIndex = 17;
            this.Arccosine.Text = "acos";
            this.Arccosine.UseVisualStyleBackColor = false;
            this.Arccosine.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Arctangent
            // 
            this.Arctangent.BackColor = System.Drawing.Color.Yellow;
            this.Arctangent.Location = new System.Drawing.Point(41, 278);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(63, 23);
            this.Arctangent.TabIndex = 18;
            this.Arctangent.Text = "atan";
            this.Arctangent.UseVisualStyleBackColor = false;
            this.Arctangent.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // DecimalLogarithm
            // 
            this.DecimalLogarithm.BackColor = System.Drawing.Color.Yellow;
            this.DecimalLogarithm.Location = new System.Drawing.Point(123, 278);
            this.DecimalLogarithm.Name = "DecimalLogarithm";
            this.DecimalLogarithm.Size = new System.Drawing.Size(66, 23);
            this.DecimalLogarithm.TabIndex = 19;
            this.DecimalLogarithm.Text = "log10";
            this.DecimalLogarithm.UseVisualStyleBackColor = false;
            this.DecimalLogarithm.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // HyperbolicCosine
            // 
            this.HyperbolicCosine.BackColor = System.Drawing.Color.Yellow;
            this.HyperbolicCosine.Location = new System.Drawing.Point(199, 278);
            this.HyperbolicCosine.Name = "HyperbolicCosine";
            this.HyperbolicCosine.Size = new System.Drawing.Size(63, 23);
            this.HyperbolicCosine.TabIndex = 20;
            this.HyperbolicCosine.Text = "cosh";
            this.HyperbolicCosine.UseVisualStyleBackColor = false;
            this.HyperbolicCosine.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(298, 326);
            this.Controls.Add(this.HyperbolicCosine);
            this.Controls.Add(this.DecimalLogarithm);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.Arccosine);
            this.Controls.Add(this.Arcsine);
            this.Controls.Add(this.ModuleOfX);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.RemainderOfTheDivision);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.XToThePowerOfTwo);
            this.Controls.Add(this.TwoToThePowerOf);
            this.Controls.Add(this.logarithm);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sinus;
        private System.Windows.Forms.Button logarithm;
        private System.Windows.Forms.Button TwoToThePowerOf;
        private System.Windows.Forms.Button XToThePowerOfTwo;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button RemainderOfTheDivision;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button ModuleOfX;
        private System.Windows.Forms.Button Arcsine;
        private System.Windows.Forms.Button Arccosine;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button DecimalLogarithm;
        private System.Windows.Forms.Button HyperbolicCosine;
    }
}

