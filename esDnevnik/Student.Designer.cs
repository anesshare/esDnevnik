namespace esDnevnik
{
    partial class Student
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            profesorBindingSource = new BindingSource(components);
            bazaBindingSource = new BindingSource(components);
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bazaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 0;
            label1.Text = "Logged in as:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(202, 18);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // profesorBindingSource
            // 
            profesorBindingSource.DataSource = typeof(Profesor);
            // 
            // bazaBindingSource
            // 
            bazaBindingSource.DataSource = typeof(Baza);
            // 
            // button1
            // 
            button1.Location = new Point(339, 18);
            button1.Name = "button1";
            button1.Size = new Size(132, 53);
            button1.TabIndex = 3;
            button1.Text = "DISPLAY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(995, 248);
            dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(486, 18);
            button2.Name = "button2";
            button2.Size = new Size(203, 53);
            button2.TabIndex = 20;
            button2.Text = "ADD STUDENT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Student";
            Size = new Size(995, 449);
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bazaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private BindingSource bazaBindingSource;
        private BindingSource profesorBindingSource;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
