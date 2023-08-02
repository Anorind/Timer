namespace MyTimer
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
            labelShowTime = new Label();
            buttonSetAnAllarm = new Button();
            buttonStopAllarm = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelShowTime
            // 
            labelShowTime.AutoSize = true;
            labelShowTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelShowTime.Location = new Point(67, 48);
            labelShowTime.Name = "labelShowTime";
            labelShowTime.Size = new Size(306, 96);
            labelShowTime.TabIndex = 0;
            labelShowTime.Text = "00:00:00";
            // 
            // buttonSetAnAllarm
            // 
            buttonSetAnAllarm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetAnAllarm.Location = new Point(67, 231);
            buttonSetAnAllarm.Name = "buttonSetAnAllarm";
            buttonSetAnAllarm.Size = new Size(295, 55);
            buttonSetAnAllarm.TabIndex = 2;
            buttonSetAnAllarm.Text = "Завести будильник";
            buttonSetAnAllarm.UseVisualStyleBackColor = true;
            buttonSetAnAllarm.Click += buttonSetAnAllarm_Click;
            // 
            // buttonStopAllarm
            // 
            buttonStopAllarm.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStopAllarm.Location = new Point(29, 302);
            buttonStopAllarm.Name = "buttonStopAllarm";
            buttonStopAllarm.Size = new Size(360, 105);
            buttonStopAllarm.TabIndex = 3;
            buttonStopAllarm.Text = "Зупинити будильник";
            buttonStopAllarm.UseVisualStyleBackColor = true;
            buttonStopAllarm.Click += buttonStopAllarm_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(143, 161);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 55);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(buttonStopAllarm);
            Controls.Add(buttonSetAnAllarm);
            Controls.Add(labelShowTime);
            Name = "Form1";
            Text = "Будильник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShowTime;
        private Button buttonSetAnAllarm;
        private Button buttonStopAllarm;
        private MaskedTextBox maskedTextBox1;
    }
}