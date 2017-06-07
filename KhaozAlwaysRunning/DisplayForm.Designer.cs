namespace KhaozAlwaysRunningForm
{
    partial class DisplayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.TmrInterval = new System.Windows.Forms.Timer(this.components);
            this.LblBattey = new System.Windows.Forms.Label();
            this.LblCPU = new System.Windows.Forms.Label();
            this.LblHeading = new System.Windows.Forms.Label();
            this.BtnClick = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LblPlex = new System.Windows.Forms.Label();
            this.PBoxPlexProt = new System.Windows.Forms.PictureBox();
            this.ImgCPU = new System.Windows.Forms.PictureBox();
            this.ImgBattery = new System.Windows.Forms.PictureBox();
            this.LblBattNotify = new System.Windows.Forms.Label();
            this.PBoxBatteryNotify = new System.Windows.Forms.PictureBox();
            this.LblHighCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPlexProt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBatteryNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrInterval
            // 
            this.TmrInterval.Interval = 1000;
            this.TmrInterval.Tick += new System.EventHandler(this.TmrInterval_Tick);
            // 
            // LblBattey
            // 
            this.LblBattey.AutoSize = true;
            this.LblBattey.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBattey.Location = new System.Drawing.Point(67, 65);
            this.LblBattey.Name = "LblBattey";
            this.LblBattey.Size = new System.Drawing.Size(129, 23);
            this.LblBattey.TabIndex = 4;
            this.LblBattey.Text = "Battery Power";
            // 
            // LblCPU
            // 
            this.LblCPU.AutoSize = true;
            this.LblCPU.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCPU.Location = new System.Drawing.Point(67, 124);
            this.LblCPU.Name = "LblCPU";
            this.LblCPU.Size = new System.Drawing.Size(58, 23);
            this.LblCPU.TabIndex = 6;
            this.LblCPU.Text = "CPU: ";
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("DengXian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(3, 3);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(221, 29);
            this.LblHeading.TabIndex = 7;
            this.LblHeading.Text = "Khaoz Always On...";
            // 
            // BtnClick
            // 
            this.BtnClick.Location = new System.Drawing.Point(197, 226);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(75, 23);
            this.BtnClick.TabIndex = 8;
            this.BtnClick.Text = "button1";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LblPlex
            // 
            this.LblPlex.AutoSize = true;
            this.LblPlex.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlex.Location = new System.Drawing.Point(67, 218);
            this.LblPlex.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblPlex.Name = "LblPlex";
            this.LblPlex.Size = new System.Drawing.Size(138, 23);
            this.LblPlex.TabIndex = 10;
            this.LblPlex.Text = "Plex Protection";
            // 
            // PBoxPlexProt
            // 
            this.PBoxPlexProt.Image = ((System.Drawing.Image)(resources.GetObject("PBoxPlexProt.Image")));
            this.PBoxPlexProt.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.PBoxPlexProt.Location = new System.Drawing.Point(3, 216);
            this.PBoxPlexProt.Name = "PBoxPlexProt";
            this.PBoxPlexProt.Size = new System.Drawing.Size(61, 25);
            this.PBoxPlexProt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxPlexProt.TabIndex = 9;
            this.PBoxPlexProt.TabStop = false;
            this.PBoxPlexProt.Click += new System.EventHandler(this.PBoxPlexProt_Click);
            // 
            // ImgCPU
            // 
            this.ImgCPU.Image = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.ImgCPU.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.ImgCPU.Location = new System.Drawing.Point(3, 106);
            this.ImgCPU.Name = "ImgCPU";
            this.ImgCPU.Size = new System.Drawing.Size(61, 60);
            this.ImgCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCPU.TabIndex = 5;
            this.ImgCPU.TabStop = false;
            // 
            // ImgBattery
            // 
            this.ImgBattery.Image = global::KhaozAlwaysRunningForm.Properties.Resources.PowerTrue;
            this.ImgBattery.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgBattery.InitialImage")));
            this.ImgBattery.Location = new System.Drawing.Point(0, 42);
            this.ImgBattery.Name = "ImgBattery";
            this.ImgBattery.Size = new System.Drawing.Size(64, 64);
            this.ImgBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBattery.TabIndex = 2;
            this.ImgBattery.TabStop = false;
            // 
            // LblBattNotify
            // 
            this.LblBattNotify.AutoSize = true;
            this.LblBattNotify.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBattNotify.Location = new System.Drawing.Point(67, 182);
            this.LblBattNotify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblBattNotify.Name = "LblBattNotify";
            this.LblBattNotify.Size = new System.Drawing.Size(174, 23);
            this.LblBattNotify.TabIndex = 12;
            this.LblBattNotify.Text = "Battery Notification";
            // 
            // PBoxBatteryNotify
            // 
            this.PBoxBatteryNotify.Image = ((System.Drawing.Image)(resources.GetObject("PBoxBatteryNotify.Image")));
            this.PBoxBatteryNotify.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.PBoxBatteryNotify.Location = new System.Drawing.Point(3, 180);
            this.PBoxBatteryNotify.Name = "PBoxBatteryNotify";
            this.PBoxBatteryNotify.Size = new System.Drawing.Size(61, 25);
            this.PBoxBatteryNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxBatteryNotify.TabIndex = 11;
            this.PBoxBatteryNotify.TabStop = false;
            this.PBoxBatteryNotify.Click += new System.EventHandler(this.PBoxBatteryNotify_Click);
            // 
            // LblHighCPU
            // 
            this.LblHighCPU.AutoSize = true;
            this.LblHighCPU.Font = new System.Drawing.Font("DengXian", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighCPU.Location = new System.Drawing.Point(68, 151);
            this.LblHighCPU.Name = "LblHighCPU";
            this.LblHighCPU.Size = new System.Drawing.Size(49, 14);
            this.LblHighCPU.TabIndex = 13;
            this.LblHighCPU.Text = "Count: 0";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblHighCPU);
            this.Controls.Add(this.LblBattNotify);
            this.Controls.Add(this.PBoxBatteryNotify);
            this.Controls.Add(this.LblPlex);
            this.Controls.Add(this.PBoxPlexProt);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.LblHeading);
            this.Controls.Add(this.LblCPU);
            this.Controls.Add(this.ImgCPU);
            this.Controls.Add(this.LblBattey);
            this.Controls.Add(this.ImgBattery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khaoz Always On";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPlexProt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBatteryNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmrInterval;
        private System.Windows.Forms.PictureBox ImgBattery;
        private System.Windows.Forms.Label LblBattey;
        private System.Windows.Forms.PictureBox ImgCPU;
        private System.Windows.Forms.Label LblCPU;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PBoxPlexProt;
        private System.Windows.Forms.Label LblPlex;
        private System.Windows.Forms.Label LblBattNotify;
        private System.Windows.Forms.PictureBox PBoxBatteryNotify;
        private System.Windows.Forms.Label LblHighCPU;
    }
}

