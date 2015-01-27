namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.leftPlusLabel = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.rightPlusLabel = new System.Windows.Forms.Label();
            this.equalSign = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rightSubtractLabel = new System.Windows.Forms.Label();
            this.minusSign = new System.Windows.Forms.Label();
            this.leftSubtractLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rightMulLabel = new System.Windows.Forms.Label();
            this.mulSign = new System.Windows.Forms.Label();
            this.leftMulLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.rightDivLabel = new System.Windows.Forms.Label();
            this.divLabel = new System.Windows.Forms.Label();
            this.leftDivLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.Location = new System.Drawing.Point(165, 9);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(101, 25);
            this.timeText.TabIndex = 1;
            this.timeText.Text = "Time Left";
            this.timeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPlusLabel
            // 
            this.leftPlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPlusLabel.Location = new System.Drawing.Point(50, 75);
            this.leftPlusLabel.Name = "leftPlusLabel";
            this.leftPlusLabel.Size = new System.Drawing.Size(60, 50);
            this.leftPlusLabel.TabIndex = 2;
            this.leftPlusLabel.Text = "?";
            this.leftPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(116, 75);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(60, 50);
            this.plusSign.TabIndex = 3;
            this.plusSign.Text = "+";
            this.plusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPlusLabel
            // 
            this.rightPlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPlusLabel.Location = new System.Drawing.Point(182, 75);
            this.rightPlusLabel.Name = "rightPlusLabel";
            this.rightPlusLabel.Size = new System.Drawing.Size(60, 50);
            this.rightPlusLabel.TabIndex = 4;
            this.rightPlusLabel.Text = "?";
            this.rightPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign
            // 
            this.equalSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign.Location = new System.Drawing.Point(248, 75);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(60, 50);
            this.equalSign.TabIndex = 6;
            this.equalSign.Text = "=";
            this.equalSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(314, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 35);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            this.sum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answer_Click);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(314, 134);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 35);
            this.difference.TabIndex = 3;
            this.difference.ValueChanged += new System.EventHandler(this.difference_ValueChanged);
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            this.difference.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightSubtractLabel
            // 
            this.rightSubtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightSubtractLabel.Location = new System.Drawing.Point(182, 125);
            this.rightSubtractLabel.Name = "rightSubtractLabel";
            this.rightSubtractLabel.Size = new System.Drawing.Size(60, 50);
            this.rightSubtractLabel.TabIndex = 10;
            this.rightSubtractLabel.Text = "?";
            this.rightSubtractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusSign
            // 
            this.minusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSign.Location = new System.Drawing.Point(116, 125);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(60, 50);
            this.minusSign.TabIndex = 9;
            this.minusSign.Text = "-";
            this.minusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftSubtractLabel
            // 
            this.leftSubtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSubtractLabel.Location = new System.Drawing.Point(50, 125);
            this.leftSubtractLabel.Name = "leftSubtractLabel";
            this.leftSubtractLabel.Size = new System.Drawing.Size(60, 50);
            this.leftSubtractLabel.TabIndex = 8;
            this.leftSubtractLabel.Text = "?";
            this.leftSubtractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(314, 184);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 35);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.product_ValueChanged);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            this.product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answer_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 16;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightMulLabel
            // 
            this.rightMulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMulLabel.Location = new System.Drawing.Point(182, 175);
            this.rightMulLabel.Name = "rightMulLabel";
            this.rightMulLabel.Size = new System.Drawing.Size(60, 50);
            this.rightMulLabel.TabIndex = 15;
            this.rightMulLabel.Text = "?";
            this.rightMulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulSign
            // 
            this.mulSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulSign.Location = new System.Drawing.Point(116, 175);
            this.mulSign.Name = "mulSign";
            this.mulSign.Size = new System.Drawing.Size(60, 50);
            this.mulSign.TabIndex = 14;
            this.mulSign.Text = "×";
            this.mulSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftMulLabel
            // 
            this.leftMulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMulLabel.Location = new System.Drawing.Point(50, 175);
            this.leftMulLabel.Name = "leftMulLabel";
            this.leftMulLabel.Size = new System.Drawing.Size(60, 50);
            this.leftMulLabel.TabIndex = 13;
            this.leftMulLabel.Text = "?";
            this.leftMulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(314, 234);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 35);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.quotient_ValueChanged);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            this.quotient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answer_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 21;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightDivLabel
            // 
            this.rightDivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightDivLabel.Location = new System.Drawing.Point(182, 225);
            this.rightDivLabel.Name = "rightDivLabel";
            this.rightDivLabel.Size = new System.Drawing.Size(60, 50);
            this.rightDivLabel.TabIndex = 20;
            this.rightDivLabel.Text = "?";
            this.rightDivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLabel
            // 
            this.divLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLabel.Location = new System.Drawing.Point(116, 225);
            this.divLabel.Name = "divLabel";
            this.divLabel.Size = new System.Drawing.Size(60, 50);
            this.divLabel.TabIndex = 19;
            this.divLabel.Text = "÷";
            this.divLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftDivLabel
            // 
            this.leftDivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftDivLabel.Location = new System.Drawing.Point(50, 225);
            this.leftDivLabel.Name = "leftDivLabel";
            this.leftDivLabel.Size = new System.Drawing.Size(60, 50);
            this.leftDivLabel.TabIndex = 18;
            this.leftDivLabel.Text = "?";
            this.leftDivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(170, 315);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rightDivLabel);
            this.Controls.Add(this.divLabel);
            this.Controls.Add(this.leftDivLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightMulLabel);
            this.Controls.Add(this.mulSign);
            this.Controls.Add(this.leftMulLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightSubtractLabel);
            this.Controls.Add(this.minusSign);
            this.Controls.Add(this.leftSubtractLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equalSign);
            this.Controls.Add(this.rightPlusLabel);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.leftPlusLabel);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label leftPlusLabel;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label rightPlusLabel;
        private System.Windows.Forms.Label equalSign;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rightSubtractLabel;
        private System.Windows.Forms.Label minusSign;
        private System.Windows.Forms.Label leftSubtractLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rightMulLabel;
        private System.Windows.Forms.Label mulSign;
        private System.Windows.Forms.Label leftMulLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rightDivLabel;
        private System.Windows.Forms.Label divLabel;
        private System.Windows.Forms.Label leftDivLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

