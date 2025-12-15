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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lstSummary
            // 
            lstSummary.BackColor = Color.White;
            lstSummary.BorderStyle = BorderStyle.FixedSingle;
            lstSummary.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstSummary.FormattingEnabled = true;
            lstSummary.Location = new Point(70, 85);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(497, 275);
            lstSummary.TabIndex = 0;
            lstSummary.SelectedIndexChanged += lstSummary_SelectedIndexChanged;
            // 
            // btnBest
            // 
            btnBest.BackColor = Color.FromArgb(224, 224, 224);
            btnBest.BackgroundImage = Properties.Resources.ChatGPT_Image_Dec_16__2025__03_51_37_AM1;
            btnBest.BackgroundImageLayout = ImageLayout.None;
            btnBest.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBest.ForeColor = SystemColors.ActiveCaptionText;
            btnBest.Location = new Point(436, 389);
            btnBest.Name = "btnBest";
            btnBest.Size = new Size(131, 34);
            btnBest.TabIndex = 1;
            btnBest.Text = "Show Best Store";
            btnBest.UseVisualStyleBackColor = false;
            btnBest.Click += btnBest_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(284, 432);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 34);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(70, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 10);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(70, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(497, 10);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(566, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 290);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(61, 76);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 290);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Dec_16__2025__03_51_37_AM;
            ClientSize = new Size(639, 502);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnBest);
            Controls.Add(lstSummary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSummary;
        private Button btnBest;
        private Button btnBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}