namespace ATM_demo
{
    partial class Balance
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
            label13 = new Label();
            label2 = new Label();
            Balancelbl = new Label();
            AccNumlbl = new Label();
            panel2 = new Panel();
            label5 = new Label();
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
            panel1.Size = new Size(800, 110);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 24F);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(79, 186);
            label13.Name = "label13";
            label13.Size = new Size(336, 45);
            label13.TabIndex = 33;
            label13.Text = "Account Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(79, 270);
            label2.Name = "label2";
            label2.Size = new Size(273, 45);
            label2.TabIndex = 34;
            label2.Text = "Your Balance :";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Arial", 24F);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(448, 270);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(239, 45);
            Balancelbl.TabIndex = 36;
            Balancelbl.Text = "BalanceinRs";
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Arial", 24F);
            AccNumlbl.ForeColor = Color.DarkSlateGray;
            AccNumlbl.Location = new Point(448, 186);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(171, 45);
            AccNumlbl.TabIndex = 35;
            AccNumlbl.Text = "AccNum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 16);
            panel2.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(349, 388);
            label5.Name = "label5";
            label5.Size = new Size(92, 39);
            label5.TabIndex = 38;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumlbl);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label13;
        private Label label2;
        private Label Balancelbl;
        private Label AccNumlbl;
        private Panel panel2;
        private Label label5;
    }
}