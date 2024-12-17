namespace vsop2
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
            num1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            num2 = new TextBox();
            result = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(371, 49);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            num1.BackColor = SystemColors.GradientInactiveCaption;
            num1.ForeColor = SystemColors.ControlText;
            num1.Location = new Point(349, 51);
            num1.Name = "num1";
            num1.Size = new Size(128, 27);
            num1.TabIndex = 1;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(483, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 58);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Num 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 102);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Num 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Resuit";
            // 
            // num2
            // 
            num2.BackColor = SystemColors.GradientInactiveCaption;
            num2.Location = new Point(349, 99);
            num2.Name = "num2";
            num2.Size = new Size(128, 27);
            num2.TabIndex = 6;
            // 
            // result
            // 
            result.BackColor = SystemColors.Info;
            result.Location = new Point(352, 141);
            result.Name = "result";
            result.Size = new Size(128, 27);
            result.TabIndex = 7;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(564, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 8;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(483, 99);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 9;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(564, 99);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 10;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.MenuHighlight;
            button6.Location = new Point(483, 141);
            button6.Name = "button6";
            button6.Size = new Size(75, 29);
            button6.TabIndex = 11;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(num1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox num1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox num2;
        private TextBox result;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
