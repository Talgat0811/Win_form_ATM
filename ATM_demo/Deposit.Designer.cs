namespace ATM_demo
{
    partial class Deposit
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
            label5 = new Label();
            button1 = new Button();
            DepositAmtTb = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            label2 = new Label();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(500, 365);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 44;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(352, 279);
            button1.Name = "button1";
            button1.Size = new Size(364, 65);
            button1.TabIndex = 43;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DepositAmtTb
            // 
            DepositAmtTb.Font = new Font("Arial", 19.8000011F);
            DepositAmtTb.Location = new Point(352, 194);
            DepositAmtTb.Name = "DepositAmtTb";
            DepositAmtTb.Size = new Size(364, 45);
            DepositAmtTb.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 19.8000011F);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(106, 200);
            label13.Name = "label13";
            label13.Size = new Size(183, 39);
            label13.TabIndex = 41;
            label13.Text = "AMOUNT :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 17);
            panel2.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(339, 106);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 11;
            label2.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(DepositAmtTb);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label5;
        private Button button1;
        private TextBox DepositAmtTb;
        private Label label13;
        private Panel panel2;
        private Label label2;
    }
}