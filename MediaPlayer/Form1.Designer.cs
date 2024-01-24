namespace MediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeLvlLable = new System.Windows.Forms.Label();
            this.VolumeLable = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.MediaPlayerLable = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TrackStart = new System.Windows.Forms.Label();
            this.TrackEnd = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.VolumeLvlLable);
            this.groupBox1.Controls.Add(this.VolumeLable);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.TrackList);
            this.groupBox1.Controls.Add(this.OpenBtn);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.PauseBtn);
            this.groupBox1.Controls.Add(this.PlayBtn);
            this.groupBox1.Controls.Add(this.PreviousBtn);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // VolumeLvlLable
            // 
            this.VolumeLvlLable.AutoSize = true;
            this.VolumeLvlLable.BackColor = System.Drawing.Color.Transparent;
            this.VolumeLvlLable.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeLvlLable.ForeColor = System.Drawing.Color.IndianRed;
            this.VolumeLvlLable.Location = new System.Drawing.Point(1045, 119);
            this.VolumeLvlLable.Name = "VolumeLvlLable";
            this.VolumeLvlLable.Size = new System.Drawing.Size(36, 23);
            this.VolumeLvlLable.TabIndex = 9;
            this.VolumeLvlLable.Text = "0%";
            // 
            // VolumeLable
            // 
            this.VolumeLable.AutoSize = true;
            this.VolumeLable.BackColor = System.Drawing.Color.Transparent;
            this.VolumeLable.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeLable.ForeColor = System.Drawing.Color.IndianRed;
            this.VolumeLable.Location = new System.Drawing.Point(979, 216);
            this.VolumeLable.Name = "VolumeLable";
            this.VolumeLable.Size = new System.Drawing.Size(88, 23);
            this.VolumeLable.TabIndex = 8;
            this.VolumeLable.Text = "Volume";
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBtn.Location = new System.Drawing.Point(648, 37);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(147, 43);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(983, 37);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 178);
            this.trackBar1.TabIndex = 6;
            // 
            // TrackList
            // 
            this.TrackList.BackColor = System.Drawing.Color.LightGray;
            this.TrackList.ForeColor = System.Drawing.Color.IndianRed;
            this.TrackList.FormattingEnabled = true;
            this.TrackList.ItemHeight = 23;
            this.TrackList.Location = new System.Drawing.Point(26, 91);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(924, 142);
            this.TrackList.TabIndex = 5;
            this.TrackList.SelectedIndexChanged += new System.EventHandler(this.TrackList_SelectedIndexChanged);
            // 
            // OpenBtn
            // 
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBtn.Location = new System.Drawing.Point(803, 37);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(147, 43);
            this.OpenBtn.TabIndex = 4;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.Location = new System.Drawing.Point(495, 37);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(147, 43);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // PauseBtn
            // 
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseBtn.Location = new System.Drawing.Point(332, 37);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(147, 43);
            this.PauseBtn.TabIndex = 2;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayBtn.Location = new System.Drawing.Point(180, 37);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(147, 43);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousBtn.Location = new System.Drawing.Point(26, 37);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(147, 43);
            this.PreviousBtn.TabIndex = 0;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            // 
            // MediaPlayerLable
            // 
            this.MediaPlayerLable.AutoSize = true;
            this.MediaPlayerLable.BackColor = System.Drawing.Color.Transparent;
            this.MediaPlayerLable.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediaPlayerLable.ForeColor = System.Drawing.Color.IndianRed;
            this.MediaPlayerLable.Location = new System.Drawing.Point(8, 9);
            this.MediaPlayerLable.Name = "MediaPlayerLable";
            this.MediaPlayerLable.Size = new System.Drawing.Size(166, 23);
            this.MediaPlayerLable.TabIndex = 9;
            this.MediaPlayerLable.Text = "Media Player";
            this.MediaPlayerLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(82, 534);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(951, 22);
            this.progressBar1.TabIndex = 10;
            // 
            // TrackStart
            // 
            this.TrackStart.AutoSize = true;
            this.TrackStart.BackColor = System.Drawing.Color.Transparent;
            this.TrackStart.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackStart.ForeColor = System.Drawing.Color.IndianRed;
            this.TrackStart.Location = new System.Drawing.Point(12, 534);
            this.TrackStart.Name = "TrackStart";
            this.TrackStart.Size = new System.Drawing.Size(64, 20);
            this.TrackStart.TabIndex = 10;
            this.TrackStart.Text = "00:00";
            // 
            // TrackEnd
            // 
            this.TrackEnd.AutoSize = true;
            this.TrackEnd.BackColor = System.Drawing.Color.Transparent;
            this.TrackEnd.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackEnd.ForeColor = System.Drawing.Color.IndianRed;
            this.TrackEnd.Location = new System.Drawing.Point(1043, 534);
            this.TrackEnd.Name = "TrackEnd";
            this.TrackEnd.Size = new System.Drawing.Size(64, 20);
            this.TrackEnd.TabIndex = 11;
            this.TrackEnd.Text = "00:00";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(16, 35);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1091, 479);
            this.Player.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1135, 840);
            this.Controls.Add(this.TrackEnd);
            this.Controls.Add(this.TrackStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MediaPlayerLable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label VolumeLvlLable;
        private System.Windows.Forms.Label VolumeLable;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Label MediaPlayerLable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TrackStart;
        private System.Windows.Forms.Label TrackEnd;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        protected internal AxWMPLib.AxWindowsMediaPlayer Player;
    }
}

