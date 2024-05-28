namespace ATM_demo
{
    partial class MiniStatment
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
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            MiniStatementDGV = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 111);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 111);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(134, 34);
            label4.Name = "label4";
            label4.Size = new Size(533, 42);
            label4.TabIndex = 4;
            label4.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(757, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 42);
            label5.TabIndex = 3;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(134, 34);
            label6.Name = "label6";
            label6.Size = new Size(532, 42);
            label6.TabIndex = 2;
            label6.Text = "Select Your Transaction Please ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1157, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 42);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(351, 35);
            label1.Name = "label1";
            label1.Size = new Size(533, 42);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(255, 120);
            label7.Name = "label7";
            label7.Size = new Size(301, 39);
            label7.TabIndex = 5;
            label7.Text = "MINI STATEMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(362, 488);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 45;
            label3.Text = "Back";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 523);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 17);
            panel3.TabIndex = 46;
            // 
            // MiniStatementDGV
            // 
            MiniStatementDGV.BackgroundColor = Color.White;
            MiniStatementDGV.BorderStyle = BorderStyle.None;
            MiniStatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiniStatementDGV.Location = new Point(0, 167);
            MiniStatementDGV.Name = "MiniStatementDGV";
            MiniStatementDGV.RowHeadersWidth = 51;
            MiniStatementDGV.Size = new Size(800, 314);
            MiniStatementDGV.TabIndex = 47;
            // 
            // MiniStatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 540);
            Controls.Add(MiniStatementDGV);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatment";
            Load += MiniStatment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label3;
        private Panel panel3;
        private DataGridView MiniStatementDGV;
    }
}