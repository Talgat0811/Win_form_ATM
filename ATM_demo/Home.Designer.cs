namespace ATM_demo
{
    partial class Home
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            AccNumlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 111);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(757, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 42);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 34);
            label1.Name = "label1";
            label1.Size = new Size(532, 42);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(328, 59);
            button1.TabIndex = 9;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(460, 194);
            button2.Name = "button2";
            button2.Size = new Size(328, 59);
            button2.TabIndex = 10;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 302);
            button3.Name = "button3";
            button3.Size = new Size(328, 59);
            button3.TabIndex = 11;
            button3.Text = "FAST CASH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Location = new Point(460, 302);
            button4.Name = "button4";
            button4.Size = new Size(328, 59);
            button4.TabIndex = 12;
            button4.Text = "MINI STATEMENT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 405);
            button5.Name = "button5";
            button5.Size = new Size(328, 59);
            button5.TabIndex = 13;
            button5.Text = "CHANGE PIN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.White;
            button6.Location = new Point(460, 405);
            button6.Name = "button6";
            button6.Size = new Size(328, 59);
            button6.TabIndex = 14;
            button6.Text = "BALANCE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 548);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 17);
            panel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(334, 513);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 16;
            label5.Text = "LOGOUT";
            label5.Click += label5_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AccNumlbl.ForeColor = Color.DarkSlateGray;
            AccNumlbl.Location = new Point(236, 123);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(296, 42);
            AccNumlbl.TabIndex = 4;
            AccNumlbl.Text = "Account Number";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(AccNumlbl);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
        private Label AccNumlbl;
    }
}