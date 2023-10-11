using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace mathsquiz
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            timeLabel.Click += new EventHandler(Label1_Click);
            Label1 = new Label();
            plusLeftLabel = new Label();
            Label2 = new Label();
            plusRightLabel = new Label();
            Label4 = new Label();
            Label4.Click += new EventHandler(Label4_Click);
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            difference.ValueChanged += new EventHandler(NumericUpDown1_ValueChanged);
            Label3 = new Label();
            Label3.Click += new EventHandler(Label3_Click);
            minusRightLabel = new Label();
            minusRightLabel.Click += new EventHandler(Label5_Click);
            Label6 = new Label();
            Label6.Click += new EventHandler(Label6_Click);
            minusLeftLabel = new Label();
            minusLeftLabel.Click += new EventHandler(Label7_Click);
            product = new NumericUpDown();
            Label5 = new Label();
            timesRightLabel = new Label();
            Label8 = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            Label10 = new Label();
            dividedRightLabel = new Label();
            Label12 = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            DateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Microsoft Sans Serif", 15.75f);
            timeLabel.Location = new Point(510, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.75f);
            Label1.Location = new Point(409, 11);
            Label1.Name = "Label1";
            Label1.Size = new Size(101, 25);
            Label1.TabIndex = 1;
            Label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label2.Location = new Point(196, 75);
            Label2.Name = "Label2";
            Label2.Size = new Size(60, 50);
            Label2.TabIndex = 3;
            Label2.Text = "+";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            plusRightLabel.Location = new Point(332, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label4.Location = new Point(450, 75);
            Label4.Name = "Label4";
            Label4.Size = new Size(60, 50);
            Label4.TabIndex = 5;
            Label4.Text = "=";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Microsoft Sans Serif", 18.0f);
            sum.Location = new Point(568, 84);
            sum.Name = "sum";
            sum.Size = new Size(100, 35);
            sum.TabIndex = 1;
            // 
            // difference
            // 
            difference.Font = new Font("Microsoft Sans Serif", 18.0f);
            difference.Location = new Point(568, 159);
            difference.Name = "difference";
            difference.Size = new Size(100, 35);
            difference.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label3.Location = new Point(450, 150);
            Label3.Name = "Label3";
            Label3.Size = new Size(60, 50);
            Label3.TabIndex = 10;
            Label3.Text = "=";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            minusRightLabel.Location = new Point(332, 150);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 9;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label6.Location = new Point(196, 150);
            Label6.Name = "Label6";
            Label6.Size = new Size(60, 50);
            Label6.TabIndex = 8;
            Label6.Text = "-";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            minusLeftLabel.Location = new Point(50, 150);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Microsoft Sans Serif", 18.0f);
            product.Location = new Point(568, 234);
            product.Name = "product";
            product.Size = new Size(100, 35);
            product.TabIndex = 3;
            // 
            // Label5
            // 
            Label5.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label5.Location = new Point(450, 225);
            Label5.Name = "Label5";
            Label5.Size = new Size(60, 50);
            Label5.TabIndex = 15;
            Label5.Text = "=";
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            timesRightLabel.Location = new Point(332, 225);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            Label8.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label8.Location = new Point(196, 225);
            Label8.Name = "Label8";
            Label8.Size = new Size(60, 50);
            Label8.TabIndex = 13;
            Label8.Text = "×";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            timesLeftLabel.Location = new Point(50, 225);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Microsoft Sans Serif", 18.0f);
            quotient.Location = new Point(568, 310);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 35);
            quotient.TabIndex = 4;
            // 
            // Label10
            // 
            Label10.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label10.Location = new Point(450, 301);
            Label10.Name = "Label10";
            Label10.Size = new Size(60, 50);
            Label10.TabIndex = 20;
            Label10.Text = "=";
            Label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            dividedRightLabel.Location = new Point(332, 301);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 19;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            Label12.Font = new Font("Microsoft Sans Serif", 18.0f);
            Label12.Location = new Point(196, 301);
            Label12.Name = "Label12";
            Label12.Size = new Size(60, 50);
            Label12.TabIndex = 18;
            Label12.Text = "÷";
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Microsoft Sans Serif", 18.0f);
            dividedLeftLabel.Location = new Point(50, 301);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Microsoft Sans Serif", 14.0f);
            startButton.Location = new Point(317, 385);
            startButton.Name = "startButton";
            startButton.Size = new Size(131, 34);
            startButton.TabIndex = 0;
            startButton.Text = "Start the Quiz";
            startButton.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Enabled = false;
            DateTimePicker1.Location = new Point(12, 9);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(190, 20);
            DateTimePicker1.TabIndex = 21;
            DateTimePicker1.Value = new DateTime(2023, 9, 22, 0, 0, 0, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 462);
            Controls.Add(DateTimePicker1);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(Label10);
            Controls.Add(dividedRightLabel);
            Controls.Add(Label12);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(Label5);
            Controls.Add(timesRightLabel);
            Controls.Add(Label8);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(Label3);
            Controls.Add(minusRightLabel);
            Controls.Add(Label6);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(Label4);
            Controls.Add(plusRightLabel);
            Controls.Add(Label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(Label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Nnachi Joseph Otu + Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label timeLabel;
        internal Label Label1;
        internal Label plusLeftLabel;
        internal Label Label2;
        internal Label plusRightLabel;
        internal Label Label4;
        internal NumericUpDown sum;
        internal NumericUpDown difference;
        internal Label Label3;
        internal Label minusRightLabel;
        internal Label Label6;
        internal Label minusLeftLabel;
        internal NumericUpDown product;
        internal Label Label5;
        internal Label timesRightLabel;
        internal Label Label8;
        internal Label timesLeftLabel;
        internal NumericUpDown quotient;
        internal Label Label10;
        internal Label dividedRightLabel;
        internal Label Label12;
        internal Label dividedLeftLabel;
        internal Button startButton;
        internal DateTimePicker DateTimePicker1;
    }
}