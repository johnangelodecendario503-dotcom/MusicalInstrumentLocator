namespace MusicalInstrumentLocator
{
    partial class Form1
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
            txtStoreName = new TextBox();
            txtStoreLocation = new TextBox();
            txtInstrument = new TextBox();
            txtPrice = new TextBox();
            btnAddStore = new Button();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtStoreName
            // 
            txtStoreName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStoreName.Location = new Point(118, 60);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(149, 29);
            txtStoreName.TabIndex = 0;
            // 
            // txtStoreLocation
            // 
            txtStoreLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStoreLocation.Location = new Point(118, 109);
            txtStoreLocation.Name = "txtStoreLocation";
            txtStoreLocation.Size = new Size(149, 29);
            txtStoreLocation.TabIndex = 1;
            // 
            // txtInstrument
            // 
            txtInstrument.BackColor = Color.FromArgb(224, 224, 224);
            txtInstrument.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstrument.Location = new Point(76, 208);
            txtInstrument.Name = "txtInstrument";
            txtInstrument.Size = new Size(145, 25);
            txtInstrument.TabIndex = 2;
            txtInstrument.TextChanged += txtInstrument_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(76, 237);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 25);
            txtPrice.TabIndex = 3;
            // 
            // btnAddStore
            // 
            btnAddStore.BackColor = Color.FromArgb(192, 64, 0);
            btnAddStore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStore.ForeColor = SystemColors.Control;
            btnAddStore.Location = new Point(236, 165);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(62, 30);
            btnAddStore.TabIndex = 4;
            btnAddStore.Text = "Add";
            btnAddStore.UseVisualStyleBackColor = false;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(192, 64, 0);
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(241, 452);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(87, 30);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 6;
            label1.Text = "STORE: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 113);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 7;
            label2.Text = "LOCATION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(26, 174);
            label3.Name = "label3";
            label3.Size = new Size(198, 21);
            label3.TabIndex = 8;
            label3.Text = "Items Available 🎸:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 211);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 240);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Price:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._980a951108dc41233b9ba54a4ef528a3;
            ClientSize = new Size(340, 504);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnAddStore);
            Controls.Add(txtPrice);
            Controls.Add(txtInstrument);
            Controls.Add(txtStoreLocation);
            Controls.Add(txtStoreName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStoreName;
        private TextBox txtStoreLocation;
        private TextBox txtInstrument;
        private TextBox txtPrice;
        private Button btnAddStore;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
