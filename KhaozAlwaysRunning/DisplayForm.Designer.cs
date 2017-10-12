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
            this.LblCpuNotify = new System.Windows.Forms.Label();
            this.LblBattNotify = new System.Windows.Forms.Label();
            this.LblHighCPU = new System.Windows.Forms.Label();
            this.LblPing = new System.Windows.Forms.Label();
            this.LblPingCount = new System.Windows.Forms.Label();
            this.LblPingNotify = new System.Windows.Forms.Label();
            this.PBoxPingNotify = new System.Windows.Forms.PictureBox();
            this.ImgNetwork = new System.Windows.Forms.PictureBox();
            this.PBoxBatteryNotify = new System.Windows.Forms.PictureBox();
            this.PBoxCpuNotify = new System.Windows.Forms.PictureBox();
            this.ImgCPU = new System.Windows.Forms.PictureBox();
            this.ImgBattery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPingNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBatteryNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCpuNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBattery)).BeginInit();
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
            this.LblCPU.Location = new System.Drawing.Point(67, 121);
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
            this.BtnClick.Location = new System.Drawing.Point(179, 305);
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
            // LblCpuNotify
            // 
            this.LblCpuNotify.AutoSize = true;
            this.LblCpuNotify.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpuNotify.Location = new System.Drawing.Point(68, 304);
            this.LblCpuNotify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblCpuNotify.Name = "LblCpuNotify";
            this.LblCpuNotify.Size = new System.Drawing.Size(152, 23);
            this.LblCpuNotify.TabIndex = 10;
            this.LblCpuNotify.Text = "CPU Notification";
            // 
            // LblBattNotify
            // 
            this.LblBattNotify.AutoSize = true;
            this.LblBattNotify.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBattNotify.Location = new System.Drawing.Point(68, 243);
            this.LblBattNotify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblBattNotify.Name = "LblBattNotify";
            this.LblBattNotify.Size = new System.Drawing.Size(174, 23);
            this.LblBattNotify.TabIndex = 12;
            this.LblBattNotify.Text = "Battery Notification";
            // 
            // LblHighCPU
            // 
            this.LblHighCPU.AutoSize = true;
            this.LblHighCPU.Font = new System.Drawing.Font("DengXian", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighCPU.Location = new System.Drawing.Point(68, 148);
            this.LblHighCPU.Name = "LblHighCPU";
            this.LblHighCPU.Size = new System.Drawing.Size(49, 14);
            this.LblHighCPU.TabIndex = 13;
            this.LblHighCPU.Text = "Count: 0";
            // 
            // LblPing
            // 
            this.LblPing.AutoSize = true;
            this.LblPing.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPing.Location = new System.Drawing.Point(67, 183);
            this.LblPing.Name = "LblPing";
            this.LblPing.Size = new System.Drawing.Size(59, 23);
            this.LblPing.TabIndex = 15;
            this.LblPing.Text = "Ping: ";
            // 
            // LblPingCount
            // 
            this.LblPingCount.AutoSize = true;
            this.LblPingCount.Font = new System.Drawing.Font("DengXian", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPingCount.Location = new System.Drawing.Point(68, 206);
            this.LblPingCount.Name = "LblPingCount";
            this.LblPingCount.Size = new System.Drawing.Size(49, 14);
            this.LblPingCount.TabIndex = 16;
            this.LblPingCount.Text = "Count: 0";
            // 
            // LblPingNotify
            // 
            this.LblPingNotify.AutoSize = true;
            this.LblPingNotify.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPingNotify.Location = new System.Drawing.Point(68, 274);
            this.LblPingNotify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblPingNotify.Name = "LblPingNotify";
            this.LblPingNotify.Size = new System.Drawing.Size(153, 23);
            this.LblPingNotify.TabIndex = 18;
            this.LblPingNotify.Text = "Ping Notification";
            // 
            // PBoxPingNotify
            // 
            this.PBoxPingNotify.Image = ((System.Drawing.Image)(resources.GetObject("PBoxPingNotify.Image")));
            this.PBoxPingNotify.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.PBoxPingNotify.Location = new System.Drawing.Point(4, 272);
            this.PBoxPingNotify.Name = "PBoxPingNotify";
            this.PBoxPingNotify.Size = new System.Drawing.Size(61, 25);
            this.PBoxPingNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxPingNotify.TabIndex = 17;
            this.PBoxPingNotify.TabStop = false;
            this.PBoxPingNotify.Click += new System.EventHandler(this.PBoxPingNotify_Click);
            // 
            // ImgNetwork
            // 
            this.ImgNetwork.Image = global::KhaozAlwaysRunningForm.Properties.Resources.Network;
            this.ImgNetwork.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.ImgNetwork.Location = new System.Drawing.Point(3, 166);
            this.ImgNetwork.Name = "ImgNetwork";
            this.ImgNetwork.Size = new System.Drawing.Size(61, 60);
            this.ImgNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgNetwork.TabIndex = 14;
            this.ImgNetwork.TabStop = false;
            // 
            // PBoxBatteryNotify
            // 
            this.PBoxBatteryNotify.Image = ((System.Drawing.Image)(resources.GetObject("PBoxBatteryNotify.Image")));
            this.PBoxBatteryNotify.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.PBoxBatteryNotify.Location = new System.Drawing.Point(4, 241);
            this.PBoxBatteryNotify.Name = "PBoxBatteryNotify";
            this.PBoxBatteryNotify.Size = new System.Drawing.Size(61, 25);
            this.PBoxBatteryNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxBatteryNotify.TabIndex = 11;
            this.PBoxBatteryNotify.TabStop = false;
            this.PBoxBatteryNotify.Click += new System.EventHandler(this.PBoxBatteryNotify_Click);
            // 
            // PBoxCpuNotify
            // 
            this.PBoxCpuNotify.Image = ((System.Drawing.Image)(resources.GetObject("PBoxCpuNotify.Image")));
            this.PBoxCpuNotify.InitialImage = global::KhaozAlwaysRunningForm.Properties.Resources.CPU;
            this.PBoxCpuNotify.Location = new System.Drawing.Point(3, 303);
            this.PBoxCpuNotify.Name = "PBoxCpuNotify";
            this.PBoxCpuNotify.Size = new System.Drawing.Size(61, 25);
            this.PBoxCpuNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCpuNotify.TabIndex = 9;
            this.PBoxCpuNotify.TabStop = false;
            this.PBoxCpuNotify.Click += new System.EventHandler(this.PBoxPlexProt_Click);
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
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(241, 334);
            this.Controls.Add(this.LblPingNotify);
            this.Controls.Add(this.PBoxPingNotify);
            this.Controls.Add(this.LblPingCount);
            this.Controls.Add(this.LblPing);
            this.Controls.Add(this.ImgNetwork);
            this.Controls.Add(this.LblHighCPU);
            this.Controls.Add(this.LblBattNotify);
            this.Controls.Add(this.PBoxBatteryNotify);
            this.Controls.Add(this.LblCpuNotify);
            this.Controls.Add(this.PBoxCpuNotify);
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
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPingNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBatteryNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCpuNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBattery)).EndInit();
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
        private System.Windows.Forms.PictureBox PBoxCpuNotify;
        private System.Windows.Forms.Label LblCpuNotify;
        private System.Windows.Forms.Label LblBattNotify;
        private System.Windows.Forms.PictureBox PBoxBatteryNotify;
        private System.Windows.Forms.Label LblHighCPU;
        private System.Windows.Forms.PictureBox ImgNetwork;
        private System.Windows.Forms.Label LblPing;
        private System.Windows.Forms.Label LblPingCount;
        private System.Windows.Forms.Label LblPingNotify;
        private System.Windows.Forms.PictureBox PBoxPingNotify;
    }
}

