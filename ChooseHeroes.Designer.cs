namespace DeadlyDuel
{
    partial class ChooseHeroes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseHeroes));
            this.Fight_butt = new System.Windows.Forms.Button();
            this.viewHero2 = new System.Windows.Forms.PictureBox();
            this.viewHero1 = new System.Windows.Forms.PictureBox();
            this.hero2_type = new System.Windows.Forms.Button();
            this.hero1_type = new System.Windows.Forms.Button();
            this.trackBar1_hp = new System.Windows.Forms.TrackBar();
            this.trackBar1_damage = new System.Windows.Forms.TrackBar();
            this.trackBar1_armor = new System.Windows.Forms.TrackBar();
            this.trackBar2_hp = new System.Windows.Forms.TrackBar();
            this.trackBar2_damage = new System.Windows.Forms.TrackBar();
            this.trackBar2_armor = new System.Windows.Forms.TrackBar();
            this.textBox_hp = new System.Windows.Forms.TextBox();
            this.textBox1_damage = new System.Windows.Forms.TextBox();
            this.textBox1_armor = new System.Windows.Forms.TextBox();
            this.textBox2_hp = new System.Windows.Forms.TextBox();
            this.textBox2_damage = new System.Windows.Forms.TextBox();
            this.textBox2_armor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewHero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_armor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_armor)).BeginInit();
            this.SuspendLayout();
            // 
            // Fight_butt
            // 
            this.Fight_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Fight_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fight_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Fight_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fight_butt.Location = new System.Drawing.Point(461, 453);
            this.Fight_butt.Name = "Fight_butt";
            this.Fight_butt.Size = new System.Drawing.Size(162, 71);
            this.Fight_butt.TabIndex = 13;
            this.Fight_butt.Text = "Fight";
            this.Fight_butt.UseVisualStyleBackColor = false;
            this.Fight_butt.Click += new System.EventHandler(this.Fight_butt_Click);
            // 
            // viewHero2
            // 
            this.viewHero2.BackColor = System.Drawing.Color.Transparent;
            this.viewHero2.Location = new System.Drawing.Point(629, 354);
            this.viewHero2.Name = "viewHero2";
            this.viewHero2.Size = new System.Drawing.Size(251, 274);
            this.viewHero2.TabIndex = 12;
            this.viewHero2.TabStop = false;
            // 
            // viewHero1
            // 
            this.viewHero1.BackColor = System.Drawing.Color.Transparent;
            this.viewHero1.Location = new System.Drawing.Point(204, 354);
            this.viewHero1.Name = "viewHero1";
            this.viewHero1.Size = new System.Drawing.Size(251, 274);
            this.viewHero1.TabIndex = 11;
            this.viewHero1.TabStop = false;
            // 
            // hero2_type
            // 
            this.hero2_type.BackColor = System.Drawing.Color.SlateGray;
            this.hero2_type.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.hero2_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hero2_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.hero2_type.ForeColor = System.Drawing.SystemColors.Control;
            this.hero2_type.Location = new System.Drawing.Point(789, 54);
            this.hero2_type.Name = "hero2_type";
            this.hero2_type.Size = new System.Drawing.Size(303, 71);
            this.hero2_type.TabIndex = 10;
            this.hero2_type.Text = "Hero 2";
            this.hero2_type.UseVisualStyleBackColor = false;
            this.hero2_type.Click += new System.EventHandler(this.hero2_type_Click);
            // 
            // hero1_type
            // 
            this.hero1_type.BackColor = System.Drawing.Color.SlateGray;
            this.hero1_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hero1_type.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.hero1_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hero1_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.hero1_type.ForeColor = System.Drawing.SystemColors.Control;
            this.hero1_type.Location = new System.Drawing.Point(42, 54);
            this.hero1_type.Name = "hero1_type";
            this.hero1_type.Size = new System.Drawing.Size(303, 71);
            this.hero1_type.TabIndex = 9;
            this.hero1_type.Text = "Hero 1";
            this.hero1_type.UseVisualStyleBackColor = false;
            this.hero1_type.Click += new System.EventHandler(this.hero1_type_Click);
            // 
            // trackBar1_hp
            // 
            this.trackBar1_hp.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar1_hp.LargeChange = 100;
            this.trackBar1_hp.Location = new System.Drawing.Point(42, 154);
            this.trackBar1_hp.Maximum = 1000;
            this.trackBar1_hp.Minimum = 100;
            this.trackBar1_hp.Name = "trackBar1_hp";
            this.trackBar1_hp.Size = new System.Drawing.Size(303, 45);
            this.trackBar1_hp.SmallChange = 10;
            this.trackBar1_hp.TabIndex = 14;
            this.trackBar1_hp.Value = 756;
            this.trackBar1_hp.Scroll += new System.EventHandler(this.trackBar1_hp_Scroll);
            // 
            // trackBar1_damage
            // 
            this.trackBar1_damage.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar1_damage.LargeChange = 10;
            this.trackBar1_damage.Location = new System.Drawing.Point(42, 226);
            this.trackBar1_damage.Maximum = 300;
            this.trackBar1_damage.Minimum = 10;
            this.trackBar1_damage.Name = "trackBar1_damage";
            this.trackBar1_damage.Size = new System.Drawing.Size(303, 45);
            this.trackBar1_damage.TabIndex = 15;
            this.trackBar1_damage.Value = 112;
            this.trackBar1_damage.Scroll += new System.EventHandler(this.trackBar1_damage_Scroll);
            // 
            // trackBar1_armor
            // 
            this.trackBar1_armor.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar1_armor.LargeChange = 10;
            this.trackBar1_armor.Location = new System.Drawing.Point(42, 299);
            this.trackBar1_armor.Maximum = 30;
            this.trackBar1_armor.Name = "trackBar1_armor";
            this.trackBar1_armor.Size = new System.Drawing.Size(303, 45);
            this.trackBar1_armor.TabIndex = 16;
            this.trackBar1_armor.Value = 6;
            this.trackBar1_armor.Scroll += new System.EventHandler(this.trackBar1_armor_Scroll);
            // 
            // trackBar2_hp
            // 
            this.trackBar2_hp.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar2_hp.LargeChange = 100;
            this.trackBar2_hp.Location = new System.Drawing.Point(789, 152);
            this.trackBar2_hp.Maximum = 1000;
            this.trackBar2_hp.Minimum = 100;
            this.trackBar2_hp.Name = "trackBar2_hp";
            this.trackBar2_hp.Size = new System.Drawing.Size(303, 45);
            this.trackBar2_hp.SmallChange = 10;
            this.trackBar2_hp.TabIndex = 17;
            this.trackBar2_hp.Value = 958;
            this.trackBar2_hp.Scroll += new System.EventHandler(this.trackBar2_hp_Scroll);
            // 
            // trackBar2_damage
            // 
            this.trackBar2_damage.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar2_damage.LargeChange = 10;
            this.trackBar2_damage.Location = new System.Drawing.Point(789, 225);
            this.trackBar2_damage.Maximum = 300;
            this.trackBar2_damage.Minimum = 10;
            this.trackBar2_damage.Name = "trackBar2_damage";
            this.trackBar2_damage.Size = new System.Drawing.Size(303, 45);
            this.trackBar2_damage.SmallChange = 10;
            this.trackBar2_damage.TabIndex = 18;
            this.trackBar2_damage.Value = 78;
            this.trackBar2_damage.Scroll += new System.EventHandler(this.trackBar2_damage_Scroll);
            // 
            // trackBar2_armor
            // 
            this.trackBar2_armor.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar2_armor.LargeChange = 10;
            this.trackBar2_armor.Location = new System.Drawing.Point(789, 298);
            this.trackBar2_armor.Maximum = 30;
            this.trackBar2_armor.Name = "trackBar2_armor";
            this.trackBar2_armor.Size = new System.Drawing.Size(303, 45);
            this.trackBar2_armor.SmallChange = 10;
            this.trackBar2_armor.TabIndex = 19;
            this.trackBar2_armor.Value = 16;
            this.trackBar2_armor.Scroll += new System.EventHandler(this.trackBar2_armor_Scroll);
            // 
            // textBox_hp
            // 
            this.textBox_hp.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_hp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_hp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_hp.Location = new System.Drawing.Point(43, 125);
            this.textBox_hp.Name = "textBox_hp";
            this.textBox_hp.Size = new System.Drawing.Size(103, 28);
            this.textBox_hp.TabIndex = 21;
            this.textBox_hp.Text = "Hp:";
            this.textBox_hp.TextChanged += new System.EventHandler(this.textBox_hp_TextChanged);
            // 
            // textBox1_damage
            // 
            this.textBox1_damage.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1_damage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1_damage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_damage.Location = new System.Drawing.Point(42, 198);
            this.textBox1_damage.Name = "textBox1_damage";
            this.textBox1_damage.Size = new System.Drawing.Size(149, 28);
            this.textBox1_damage.TabIndex = 22;
            this.textBox1_damage.Text = "Damage:";
            this.textBox1_damage.TextChanged += new System.EventHandler(this.textBox1_damage_TextChanged);
            // 
            // textBox1_armor
            // 
            this.textBox1_armor.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1_armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1_armor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_armor.Location = new System.Drawing.Point(42, 271);
            this.textBox1_armor.Name = "textBox1_armor";
            this.textBox1_armor.Size = new System.Drawing.Size(112, 28);
            this.textBox1_armor.TabIndex = 23;
            this.textBox1_armor.Text = "Armor:";
            this.textBox1_armor.TextChanged += new System.EventHandler(this.textBox1_armor_TextChanged);
            // 
            // textBox2_hp
            // 
            this.textBox2_hp.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2_hp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox2_hp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2_hp.Location = new System.Drawing.Point(789, 124);
            this.textBox2_hp.Name = "textBox2_hp";
            this.textBox2_hp.Size = new System.Drawing.Size(104, 28);
            this.textBox2_hp.TabIndex = 24;
            this.textBox2_hp.Text = "Hp:";
            this.textBox2_hp.TextChanged += new System.EventHandler(this.textBox2_hp_TextChanged);
            // 
            // textBox2_damage
            // 
            this.textBox2_damage.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2_damage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox2_damage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2_damage.Location = new System.Drawing.Point(789, 197);
            this.textBox2_damage.Name = "textBox2_damage";
            this.textBox2_damage.Size = new System.Drawing.Size(144, 28);
            this.textBox2_damage.TabIndex = 25;
            this.textBox2_damage.Text = "Damage:";
            this.textBox2_damage.TextChanged += new System.EventHandler(this.textBox2_damage_TextChanged);
            // 
            // textBox2_armor
            // 
            this.textBox2_armor.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2_armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox2_armor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2_armor.Location = new System.Drawing.Point(789, 270);
            this.textBox2_armor.Name = "textBox2_armor";
            this.textBox2_armor.Size = new System.Drawing.Size(109, 28);
            this.textBox2_armor.TabIndex = 26;
            this.textBox2_armor.Text = "Armor:";
            this.textBox2_armor.TextChanged += new System.EventHandler(this.textBox2_armor_TextChanged);
            // 
            // ChooseHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 681);
            this.Controls.Add(this.textBox2_armor);
            this.Controls.Add(this.textBox2_damage);
            this.Controls.Add(this.textBox2_hp);
            this.Controls.Add(this.textBox1_armor);
            this.Controls.Add(this.textBox1_damage);
            this.Controls.Add(this.textBox_hp);
            this.Controls.Add(this.trackBar2_armor);
            this.Controls.Add(this.trackBar2_damage);
            this.Controls.Add(this.trackBar2_hp);
            this.Controls.Add(this.trackBar1_armor);
            this.Controls.Add(this.trackBar1_damage);
            this.Controls.Add(this.trackBar1_hp);
            this.Controls.Add(this.Fight_butt);
            this.Controls.Add(this.viewHero2);
            this.Controls.Add(this.viewHero1);
            this.Controls.Add(this.hero2_type);
            this.Controls.Add(this.hero1_type);
            this.Name = "ChooseHeroes";
            this.Text = "ChooseHeroes";
            this.Load += new System.EventHandler(this.ChooseHeroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewHero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_armor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_armor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fight_butt;
        private System.Windows.Forms.PictureBox viewHero2;
        private System.Windows.Forms.PictureBox viewHero1;
        public System.Windows.Forms.Button hero2_type;
        public System.Windows.Forms.Button hero1_type;
        private System.Windows.Forms.TextBox textBox_hp;
        private System.Windows.Forms.TextBox textBox1_damage;
        private System.Windows.Forms.TextBox textBox1_armor;
        private System.Windows.Forms.TextBox textBox2_hp;
        private System.Windows.Forms.TextBox textBox2_damage;
        private System.Windows.Forms.TextBox textBox2_armor;
        public System.Windows.Forms.TrackBar trackBar1_hp;
        public System.Windows.Forms.TrackBar trackBar1_damage;
        public System.Windows.Forms.TrackBar trackBar1_armor;
        public System.Windows.Forms.TrackBar trackBar2_hp;
        public System.Windows.Forms.TrackBar trackBar2_damage;
        public System.Windows.Forms.TrackBar trackBar2_armor;
    }
}