namespace MusicalInstrumentLocator
{
    partial class Form3
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
            pnlMap = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnSummary = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlMap
            // 
            pnlMap.BackgroundImage = Properties.Resources.map;
            pnlMap.BorderStyle = BorderStyle.Fixed3D;
            pnlMap.Location = new Point(25, 41);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(304, 400);
            pnlMap.TabIndex = 3;
            pnlMap.Paint += pnlMap_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.map;
            pictureBox1.Location = new Point(25, 440);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 17);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.map;
            pictureBox2.Location = new Point(25, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 18);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.final_map1;
            pictureBox3.Location = new Point(329, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 429);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.final_map;
            pictureBox4.Location = new Point(12, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 429);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnSummary
            // 
            btnSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummary.Location = new Point(213, 489);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(75, 23);
            btnSummary.TabIndex = 8;
            btnSummary.Text = "Next";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click_1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(74, 489);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._980a951108dc41233b9ba54a4ef528a3;
            ClientSize = new Size(356, 540);
            Controls.Add(btnBack);
            Controls.Add(btnSummary);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pnlMap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMap;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnSummary;
        private Button btnBack;
    }
}