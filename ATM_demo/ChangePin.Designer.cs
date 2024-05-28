namespace ATM_demo
{
    partial class ChangePin
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
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label13 = new Label();
            button1 = new Button();
            Pin2Tb = new TextBox();
            Pin1Tb = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 103);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(757, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 42);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 31);
            label1.Name = "label1";
            label1.Size = new Size(533, 42);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 19.8000011F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(56, 257);
            label2.Name = "label2";
            label2.Size = new Size(243, 39);
            label2.TabIndex = 36;
            label2.Text = "CONFIRM PIN";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 19.8000011F);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(56, 170);
            label13.Name = "label13";
            label13.Size = new Size(165, 39);
            label13.TabIndex = 35;
            label13.Text = "NEW PIN";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(342, 314);
            button1.Name = "button1";
            button1.Size = new Size(364, 65);
            button1.TabIndex = 39;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Font = new Font("Arial", 19.8000011F);
            Pin2Tb.Location = new Point(342, 251);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(364, 45);
            Pin2Tb.TabIndex = 38;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Font = new Font("Arial", 19.8000011F);
            Pin1Tb.Location = new Point(342, 164);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(364, 45);
            Pin1Tb.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(483, 398);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 40;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 17);
            panel2.TabIndex = 41;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            Load += ChangePin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label13;
        private Button button1;
        private TextBox Pin2Tb;
        private TextBox Pin1Tb;
        private Label label5;
        private Panel panel2;
    }
}