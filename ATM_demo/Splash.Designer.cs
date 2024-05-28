namespace ATM_demo
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            kylng = new RadioButton();
            rulng = new RadioButton();
            enlng = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(668, 53);
            label1.TabIndex = 0;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // kylng
            // 
            kylng.AutoSize = true;
            kylng.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            kylng.ForeColor = Color.White;
            kylng.Location = new Point(630, 125);
            kylng.Name = "kylng";
            kylng.Size = new Size(85, 25);
            kylng.TabIndex = 2;
            kylng.TabStop = true;
            kylng.Text = "Kyrgyz";
            kylng.UseVisualStyleBackColor = true;
            // 
            // rulng
            // 
            rulng.AutoSize = true;
            rulng.Font = new Font("Arial", 10.8F);
            rulng.ForeColor = Color.White;
            rulng.Location = new Point(630, 171);
            rulng.Name = "rulng";
            rulng.Size = new Size(96, 25);
            rulng.TabIndex = 3;
            rulng.TabStop = true;
            rulng.Text = "Russian";
            rulng.UseVisualStyleBackColor = true;
            // 
            // enlng
            // 
            enlng.AutoSize = true;
            enlng.Font = new Font("Arial", 10.8F);
            enlng.ForeColor = Color.White;
            enlng.Location = new Point(630, 214);
            enlng.Name = "enlng";
            enlng.Size = new Size(90, 25);
            enlng.TabIndex = 4;
            enlng.TabStop = true;
            enlng.Text = "English";
            enlng.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.TryAgain;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(411, 336);
            button1.Name = "button1";
            button1.Size = new Size(295, 57);
            button1.TabIndex = 32;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(enlng);
            Controls.Add(rulng);
            Controls.Add(kylng);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private RadioButton kylng;
        private RadioButton rulng;
        private RadioButton enlng;
        private Button button1;
    }
}
