namespace MusicalInstrumentLocator
{
    partial class Form2
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
            txtUserName = new TextBox();
            txtUserLocation = new TextBox();
            txtInstrumentBuy = new TextBox();
            btnShow = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(114, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(118, 29);
            txtUserName.TabIndex = 0;
            // 
            // txtUserLocation
            // 
            txtUserLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserLocation.Location = new Point(114, 103);
            txtUserLocation.Name = "txtUserLocation";
            txtUserLocation.Size = new Size(118, 29);
            txtUserLocation.TabIndex = 1;
            // 
            // txtInstrumentBuy
            // 
            txtInstrumentBuy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstrumentBuy.Location = new Point(33, 213);
            txtInstrumentBuy.Name = "txtInstrumentBuy";
            txtInstrumentBuy.Size = new Size(138, 27);
            txtInstrumentBuy.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(193, 455);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(84, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(33, 161);
            label3.Name = "label3";
            label3.Size = new Size(242, 21);
            label3.TabIndex = 9;
            label3.Text = "Instrument to buy 🎻🎷🎵";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 195);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 11;
            label1.Text = "NAME: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 107);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 12;
            label2.Text = "LOCATION:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(71, 455);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._980a951108dc41233b9ba54a4ef528a3;
            ClientSize = new Size(356, 540);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnShow);
            Controls.Add(txtInstrumentBuy);
            Controls.Add(txtUserLocation);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtUserLocation;
        private TextBox txtInstrumentBuy;
        private Button btnShow;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button btnBack;
    }
}