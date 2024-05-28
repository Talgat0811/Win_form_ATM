namespace ATM_demo
{
    partial class Account
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
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            AccNameTb = new TextBox();
            AccNumTb = new TextBox();
            Addresstb = new TextBox();
            FanameTb = new TextBox();
            PhoneTb = new TextBox();
            pintb = new TextBox();
            educationtb = new ComboBox();
            dobdate = new DateTimePicker();
            panel2 = new Panel();
            button1 = new Button();
            label13 = new Label();
            occupationtb = new TextBox();
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
            panel1.Size = new Size(1200, 111);
            panel1.TabIndex = 1;
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
            label2.Click += label2_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(103, 200);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 10;
            label5.Text = "ACC NUM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(103, 293);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 11;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(103, 374);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 12;
            label4.Text = "FNAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(103, 459);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 13;
            label6.Text = "ADDRESS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(639, 459);
            label7.Name = "label7";
            label7.Size = new Size(114, 32);
            label7.TabIndex = 14;
            label7.Text = "PHONE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(639, 293);
            label8.Name = "label8";
            label8.Size = new Size(176, 32);
            label8.TabIndex = 15;
            label8.Text = "EDUCATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(639, 374);
            label9.Name = "label9";
            label9.Size = new Size(196, 32);
            label9.TabIndex = 16;
            label9.Text = "OCCUPATION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(639, 557);
            label10.Name = "label10";
            label10.Size = new Size(75, 32);
            label10.TabIndex = 17;
            label10.Text = "DOB";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(639, 204);
            label11.Name = "label11";
            label11.Size = new Size(61, 32);
            label11.TabIndex = 18;
            label11.Text = "PIN";
            // 
            // AccNameTb
            // 
            AccNameTb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AccNameTb.Location = new Point(263, 291);
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(311, 34);
            AccNameTb.TabIndex = 21;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AccNumTb.Location = new Point(263, 198);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(311, 34);
            AccNumTb.TabIndex = 20;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Addresstb.Location = new Point(263, 457);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(311, 131);
            Addresstb.TabIndex = 23;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FanameTb.Location = new Point(263, 372);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(311, 34);
            FanameTb.TabIndex = 22;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneTb.Location = new Point(841, 461);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(311, 34);
            PhoneTb.TabIndex = 24;
            // 
            // pintb
            // 
            pintb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pintb.Location = new Point(836, 198);
            pintb.Name = "pintb";
            pintb.Size = new Size(311, 34);
            pintb.TabIndex = 25;
            // 
            // educationtb
            // 
            educationtb.Font = new Font("Arial", 13.8F);
            educationtb.FormattingEnabled = true;
            educationtb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationtb.Location = new Point(836, 291);
            educationtb.Name = "educationtb";
            educationtb.Size = new Size(311, 34);
            educationtb.TabIndex = 27;
            // 
            // dobdate
            // 
            dobdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dobdate.Location = new Point(841, 558);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(250, 30);
            dobdate.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 759);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 20);
            panel2.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(490, 629);
            button1.Name = "button1";
            button1.Size = new Size(295, 57);
            button1.TabIndex = 31;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(600, 709);
            label13.Name = "label13";
            label13.Size = new Size(76, 32);
            label13.TabIndex = 32;
            label13.Text = "Back";
            label13.Click += label13_Click;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            occupationtb.Location = new Point(841, 376);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(311, 34);
            occupationtb.TabIndex = 33;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 779);
            Controls.Add(occupationtb);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dobdate);
            Controls.Add(educationtb);
            Controls.Add(pintb);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNameTb);
            Controls.Add(AccNumTb);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox AccNameTb;
        private TextBox AccNumTb;
        private TextBox Addresstb;
        private TextBox FanameTb;
        private TextBox PhoneTb;
        private TextBox pintb;
        private ComboBox educationtb;
        private DateTimePicker dobdate;
        private Panel panel2;
        private Button button1;
        private Label label13;
        private TextBox occupationtb;
    }
}