namespace MusicalInstrumentLocator
{
    partial class Form4
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
            lstSummary = new ListBox();
            btnBest = new Button();
            btnBack = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lstSummary
            // 
            lstSummary.BackColor = Color.Silver;
            lstSummary.BorderStyle = BorderStyle.FixedSingle;
            lstSummary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstSummary.FormattingEnabled = true;
            lstSummary.Location = new Point(38, 87);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(278, 274);
            lstSummary.TabIndex = 0;
            lstSummary.SelectedIndexChanged += lstSummary_SelectedIndexChanged;
            // 
            // btnBest
            // 
            btnBest.BackColor = Color.FromArgb(255, 255, 192);
            btnBest.BackgroundImageLayout = ImageLayout.None;
            btnBest.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBest.Location = new Point(185, 473);
            btnBest.Name = "btnBest";
            btnBest.Size = new Size(131, 34);
            btnBest.TabIndex = 1;
            btnBest.Text = "Show Best Store";
            btnBest.UseVisualStyleBackColor = false;
            btnBest.Click += btnBest_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(70, 477);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 27);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.grgrg;
            pictureBox2.Location = new Point(38, 358);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 21);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.grgrg;
            pictureBox1.Location = new Point(38, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 21);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.grgrg;
            pictureBox3.Location = new Point(313, 69);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 310);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.grgrg;
            pictureBox4.Location = new Point(24, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(14, 310);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sss;
            ClientSize = new Size(356, 540);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnBack);
            Controls.Add(btnBest);
            Controls.Add(lstSummary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSummary;
        private Button btnBest;
        private Button btnBack;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}