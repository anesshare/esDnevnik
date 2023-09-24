namespace esDnevnik
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(86, 106);
            button1.Name = "button1";
            button1.Size = new Size(118, 110);
            button1.TabIndex = 0;
            button1.Text = "I/1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(357, 106);
            button2.Name = "button2";
            button2.Size = new Size(118, 110);
            button2.TabIndex = 0;
            button2.Text = "I/2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(582, 106);
            button3.Name = "button3";
            button3.Size = new Size(118, 110);
            button3.TabIndex = 0;
            button3.Text = "III/4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(86, 285);
            button4.Name = "button4";
            button4.Size = new Size(118, 110);
            button4.TabIndex = 0;
            button4.Text = "II/6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(357, 285);
            button5.Name = "button5";
            button5.Size = new Size(118, 110);
            button5.TabIndex = 0;
            button5.Text = "IV/7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(582, 285);
            button6.Name = "button6";
            button6.Size = new Size(118, 110);
            button6.TabIndex = 0;
            button6.Text = "IV/6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 1;
            label1.Text = "Logged in as: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(190, 31);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Menu";
            Size = new Size(797, 449);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
    }
}
