namespace DeadlyDuel
{
    partial class FightScene
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightScene));
            this.currentDamage2 = new System.Windows.Forms.Label();
            this.currentDamage1 = new System.Windows.Forms.Label();
            this.Player1_box = new System.Windows.Forms.PictureBox();
            this.gameSpeed_butt = new System.Windows.Forms.CheckBox();
            this.NoSound_butt = new System.Windows.Forms.CheckBox();
            this.timerDisplay = new System.Windows.Forms.Label();
            this.Player2_type = new System.Windows.Forms.Label();
            this.Player1_type = new System.Windows.Forms.Label();
            this.progressBar_hp2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_hp1 = new System.Windows.Forms.ProgressBar();
            this.Player2_box = new System.Windows.Forms.PictureBox();
            this.startGame_butt = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.TextBox();
            this.currentHp2 = new System.Windows.Forms.TextBox();
            this.currentHp1 = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.soundsPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // currentDamage2
            // 
            this.currentDamage2.AutoSize = true;
            this.currentDamage2.BackColor = System.Drawing.Color.Transparent;
            this.currentDamage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.currentDamage2.ForeColor = System.Drawing.Color.Maroon;
            this.currentDamage2.Location = new System.Drawing.Point(272, 228);
            this.currentDamage2.Margin = new System.Windows.Forms.Padding(0);
            this.currentDamage2.MinimumSize = new System.Drawing.Size(30, 17);
            this.currentDamage2.Name = "currentDamage2";
            this.currentDamage2.Size = new System.Drawing.Size(30, 39);
            this.currentDamage2.TabIndex = 35;
            // 
            // currentDamage1
            // 
            this.currentDamage1.AutoSize = true;
            this.currentDamage1.BackColor = System.Drawing.Color.Transparent;
            this.currentDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.currentDamage1.ForeColor = System.Drawing.Color.Maroon;
            this.currentDamage1.Location = new System.Drawing.Point(568, 228);
            this.currentDamage1.Margin = new System.Windows.Forms.Padding(0);
            this.currentDamage1.MinimumSize = new System.Drawing.Size(30, 17);
            this.currentDamage1.Name = "currentDamage1";
            this.currentDamage1.Size = new System.Drawing.Size(30, 39);
            this.currentDamage1.TabIndex = 36;
            // 
            // Player1_box
            // 
            this.Player1_box.BackColor = System.Drawing.Color.Transparent;
            this.Player1_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player1_box.Location = new System.Drawing.Point(168, 337);
            this.Player1_box.MaximumSize = new System.Drawing.Size(300, 300);
            this.Player1_box.Name = "Player1_box";
            this.Player1_box.Size = new System.Drawing.Size(300, 300);
            this.Player1_box.TabIndex = 25;
            this.Player1_box.TabStop = false;
            // 
            // gameSpeed_butt
            // 
            this.gameSpeed_butt.Appearance = System.Windows.Forms.Appearance.Button;
            this.gameSpeed_butt.AutoSize = true;
            this.gameSpeed_butt.BackColor = System.Drawing.SystemColors.Control;
            this.gameSpeed_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameSpeed_butt.FlatAppearance.BorderSize = 0;
            this.gameSpeed_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameSpeed_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gameSpeed_butt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameSpeed_butt.Location = new System.Drawing.Point(145, 12);
            this.gameSpeed_butt.Name = "gameSpeed_butt";
            this.gameSpeed_butt.Size = new System.Drawing.Size(101, 34);
            this.gameSpeed_butt.TabIndex = 34;
            this.gameSpeed_butt.Text = "Speed 4x";
            this.gameSpeed_butt.UseVisualStyleBackColor = false;
            this.gameSpeed_butt.CheckedChanged += new System.EventHandler(this.gameSpeed_butt_CheckedChanged);
            // 
            // NoSound_butt
            // 
            this.NoSound_butt.AutoSize = true;
            this.NoSound_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NoSound_butt.Location = new System.Drawing.Point(9, 18);
            this.NoSound_butt.MinimumSize = new System.Drawing.Size(112, 28);
            this.NoSound_butt.Name = "NoSound_butt";
            this.NoSound_butt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoSound_butt.Size = new System.Drawing.Size(115, 28);
            this.NoSound_butt.TabIndex = 33;
            this.NoSound_butt.Text = "No Sound";
            this.NoSound_butt.UseVisualStyleBackColor = true;
            this.NoSound_butt.CheckedChanged += new System.EventHandler(this.NoSound_butt_CheckedChanged);
            // 
            // timerDisplay
            // 
            this.timerDisplay.AutoSize = true;
            this.timerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timerDisplay.Location = new System.Drawing.Point(395, 147);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(73, 31);
            this.timerDisplay.TabIndex = 32;
            this.timerDisplay.Text = "00:00";
            // 
            // Player2_type
            // 
            this.Player2_type.AutoSize = true;
            this.Player2_type.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Player2_type.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Underline);
            this.Player2_type.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Player2_type.Location = new System.Drawing.Point(743, 131);
            this.Player2_type.Name = "Player2_type";
            this.Player2_type.Size = new System.Drawing.Size(80, 27);
            this.Player2_type.TabIndex = 31;
            this.Player2_type.Text = "Player2";
            // 
            // Player1_type
            // 
            this.Player1_type.AutoSize = true;
            this.Player1_type.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Player1_type.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Underline);
            this.Player1_type.ForeColor = System.Drawing.Color.White;
            this.Player1_type.Location = new System.Drawing.Point(12, 131);
            this.Player1_type.Name = "Player1_type";
            this.Player1_type.Size = new System.Drawing.Size(77, 27);
            this.Player1_type.TabIndex = 30;
            this.Player1_type.Text = "Player1";
            // 
            // progressBar_hp2
            // 
            this.progressBar_hp2.BackColor = System.Drawing.Color.Brown;
            this.progressBar_hp2.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar_hp2.Location = new System.Drawing.Point(471, 158);
            this.progressBar_hp2.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_hp2.Name = "progressBar_hp2";
            this.progressBar_hp2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar_hp2.RightToLeftLayout = true;
            this.progressBar_hp2.Size = new System.Drawing.Size(383, 20);
            this.progressBar_hp2.Step = -1;
            this.progressBar_hp2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_hp2.TabIndex = 29;
            this.progressBar_hp2.Value = 100;
            // 
            // progressBar_hp1
            // 
            this.progressBar_hp1.BackColor = System.Drawing.Color.Brown;
            this.progressBar_hp1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar_hp1.Location = new System.Drawing.Point(9, 158);
            this.progressBar_hp1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_hp1.MarqueeAnimationSpeed = 0;
            this.progressBar_hp1.Name = "progressBar_hp1";
            this.progressBar_hp1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar_hp1.Size = new System.Drawing.Size(383, 20);
            this.progressBar_hp1.Step = -1;
            this.progressBar_hp1.TabIndex = 28;
            this.progressBar_hp1.Value = 100;
            // 
            // Player2_box
            // 
            this.Player2_box.BackColor = System.Drawing.Color.Transparent;
            this.Player2_box.Location = new System.Drawing.Point(408, 337);
            this.Player2_box.MaximumSize = new System.Drawing.Size(300, 300);
            this.Player2_box.Name = "Player2_box";
            this.Player2_box.Size = new System.Drawing.Size(300, 300);
            this.Player2_box.TabIndex = 27;
            this.Player2_box.TabStop = false;
            this.Player2_box.Click += new System.EventHandler(this.Player2_box_Click);
            // 
            // startGame_butt
            // 
            this.startGame_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startGame_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startGame_butt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.startGame_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGame_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.startGame_butt.ForeColor = System.Drawing.Color.Transparent;
            this.startGame_butt.Location = new System.Drawing.Point(322, 78);
            this.startGame_butt.Name = "startGame_butt";
            this.startGame_butt.Size = new System.Drawing.Size(215, 66);
            this.startGame_butt.TabIndex = 26;
            this.startGame_butt.Text = "Start";
            this.startGame_butt.UseVisualStyleBackColor = false;
            this.startGame_butt.Click += new System.EventHandler(this.startGame_butt_Click);
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.Color.Gainsboro;
            this.battleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.battleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.battleLog.Location = new System.Drawing.Point(860, 0);
            this.battleLog.Multiline = true;
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(280, 681);
            this.battleLog.TabIndex = 39;
            // 
            // currentHp2
            // 
            this.currentHp2.BackColor = System.Drawing.Color.Red;
            this.currentHp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentHp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.currentHp2.ForeColor = System.Drawing.Color.White;
            this.currentHp2.Location = new System.Drawing.Point(796, 179);
            this.currentHp2.Name = "currentHp2";
            this.currentHp2.Size = new System.Drawing.Size(57, 28);
            this.currentHp2.TabIndex = 40;
            this.currentHp2.Text = "1000";
            // 
            // currentHp1
            // 
            this.currentHp1.BackColor = System.Drawing.Color.Red;
            this.currentHp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentHp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.currentHp1.ForeColor = System.Drawing.Color.White;
            this.currentHp1.Location = new System.Drawing.Point(9, 179);
            this.currentHp1.Name = "currentHp1";
            this.currentHp1.Size = new System.Drawing.Size(58, 28);
            this.currentHp1.TabIndex = 41;
            this.currentHp1.Text = "1000";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(20, 632);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(0, 0);
            this.musicPlayer.TabIndex = 42;
            this.musicPlayer.Visible = false;
            // 
            // soundsPlayer
            // 
            this.soundsPlayer.Enabled = true;
            this.soundsPlayer.Location = new System.Drawing.Point(18, 649);
            this.soundsPlayer.Name = "soundsPlayer";
            this.soundsPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundsPlayer.OcxState")));
            this.soundsPlayer.Size = new System.Drawing.Size(0, 0);
            this.soundsPlayer.TabIndex = 43;
            this.soundsPlayer.Visible = false;
            // 
            // FightScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1140, 681);
            this.Controls.Add(this.soundsPlayer);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.currentHp1);
            this.Controls.Add(this.currentHp2);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.currentDamage2);
            this.Controls.Add(this.currentDamage1);
            this.Controls.Add(this.Player1_box);
            this.Controls.Add(this.gameSpeed_butt);
            this.Controls.Add(this.NoSound_butt);
            this.Controls.Add(this.timerDisplay);
            this.Controls.Add(this.Player2_type);
            this.Controls.Add(this.Player1_type);
            this.Controls.Add(this.progressBar_hp2);
            this.Controls.Add(this.progressBar_hp1);
            this.Controls.Add(this.Player2_box);
            this.Controls.Add(this.startGame_butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FightScene";
            this.Text = "Deadly Duel";
            this.Load += new System.EventHandler(this.FightScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentDamage2;
        private System.Windows.Forms.Label currentDamage1;
        private System.Windows.Forms.PictureBox Player1_box;
        private System.Windows.Forms.CheckBox gameSpeed_butt;
        private System.Windows.Forms.CheckBox NoSound_butt;
        private System.Windows.Forms.Label timerDisplay;
        private System.Windows.Forms.Label Player2_type;
        private System.Windows.Forms.Label Player1_type;
        private System.Windows.Forms.ProgressBar progressBar_hp2;
        private System.Windows.Forms.ProgressBar progressBar_hp1;
        private System.Windows.Forms.PictureBox Player2_box;
        private System.Windows.Forms.Button startGame_butt;
        private System.Windows.Forms.TextBox battleLog;
        private System.Windows.Forms.TextBox currentHp2;
        private System.Windows.Forms.TextBox currentHp1;
        private System.Windows.Forms.Timer gameTimer;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private AxWMPLib.AxWindowsMediaPlayer soundsPlayer;
    }
}

