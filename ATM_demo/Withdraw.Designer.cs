namespace ATM_demo
{
    partial class Withdraw
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
            label5 = new Label();
            button1 = new Button();
            wdarntTb = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            withdrawlbl = new Label();
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
            panel1.TabIndex = 3;
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
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(322, 107);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 45;
            label2.Text = "WITHDARW";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(478, 377);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 49;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(335, 280);
            button1.Name = "button1";
            button1.Size = new Size(364, 65);
            button1.TabIndex = 48;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // wdarntTb
            // 
            wdarntTb.Font = new Font("Arial", 19.8000011F);
            wdarntTb.Location = new Point(335, 195);
            wdarntTb.Name = "wdarntTb";
            wdarntTb.Size = new Size(364, 45);
            wdarntTb.TabIndex = 47;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 19.8000011F);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(89, 201);
            label13.Name = "label13";
            label13.Size = new Size(183, 39);
            label13.TabIndex = 46;
            label13.Text = "AMOUNT :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 17);
            panel2.TabIndex = 50;
            // 
            // withdrawlbl
            // 
            withdrawlbl.AutoSize = true;
            withdrawlbl.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            withdrawlbl.ForeColor = Color.DarkSlateGray;
            withdrawlbl.Location = new Point(290, 149);
            withdrawlbl.Name = "withdrawlbl";
            withdrawlbl.Size = new Size(304, 32);
            withdrawlbl.TabIndex = 51;
            withdrawlbl.Text = "AVAILABLE BALANCE";
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(withdrawlbl);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(wdarntTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdraw";
            Load += Withdraw_Load;
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
        private Label label5;
        private Button button1;
        private TextBox wdarntTb;
        private Label label13;
        private Panel panel2;
        private Label withdrawlbl;
    }
}