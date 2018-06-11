using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadlyDuel
{
    public partial class FightScene : Form
    {


        public ChooseHeroes f = new ChooseHeroes();
        int pause = 1000;
        int timeSec = 0, timeMin = 0;

        Random rand = new Random(DateTime.Now.Millisecond);

        public FightScene()
        {
            InitializeComponent();
        }

        private void FightScene_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.setMode("loop", true);
            musicPlayer.Visible = false;
            musicPlayer.URL = "sounds/sound.mp3";
            musicPlayer.Ctlcontrols.play();

            f.ShowDialog();

            Hide();


            Player1_box.Image = Image.FromFile("../../resourses/animations/knight1Stay.png");
            Player2_box.Image = Image.FromFile("../../resourses/animations/knight2Stay.png");
        }

        private void Pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

        private void Player2_box_Click(object sender, EventArgs e)
        {

        }

        private void gameSpeed_butt_CheckedChanged(object sender, EventArgs e)
        {

            if (gameSpeed_butt.Checked)
            {
                pause = 250;
                gameTimer.Interval = 250;
            }
            else
            {
                pause = 1000;
                gameTimer.Interval = 1000;
            }
        }

        private void NoSound_butt_CheckedChanged(object sender, EventArgs e)
        {
            if (NoSound_butt.Checked)
            {
                musicPlayer.Ctlcontrols.pause();
            }
            else
            {
                musicPlayer.Ctlcontrols.play();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeSec++;
            if (timeSec <= 9)
            {
                timerDisplay.Text = timerDisplay.Text.Substring(0, 4) + timeSec.ToString();
            }
            else if (timeSec >= 9)
            {
                timerDisplay.Text = timerDisplay.Text.Substring(0, 3) + timeSec.ToString();
            }


            if (timeSec == 60)
            {
                timeMin++; timeSec = 0;
                timerDisplay.Text = timerDisplay.Text.Substring(0, 1) + timeMin.ToString() + ":" + timeSec.ToString();
            }
            if (timeMin > 9)
            {
                timerDisplay.Text = timeMin.ToString() + ":" + timeSec.ToString();
            }
        }

         

        private void startGame_butt_Click(object sender, EventArgs e)
        {
            startGame_butt.Enabled = false;
            Player p1 = new Warrior(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
            Player p2 = new Warrior(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
            switch (ChooseHeroes.type1)
            {
                case "Warriror":
                    {
                        p1 = new Warrior(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
                        break;
                    }
                case "Knight":
                    {
                        p1 = new Knight(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
                        break;
                    }
                case "Assassin":
                    {
                        p1 = new Assassin(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
                        break;
                    }
                case "Monk":
                    {
                        p1 = new Monk(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
                        break;
                    }
                case "Swordsman":
                    {
                        p1 = new Swordsman(ChooseHeroes.hp1, ChooseHeroes.damage1, ChooseHeroes.armor1);
                        break;
                    }
            }

            switch (ChooseHeroes.type2)
            {
                case "Warriror":
                    {
                        p2 = new Warrior(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
                        break;
                    }
                case "Knight":
                    {
                        p2 = new Knight(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
                        break;
                    }
                case "Assassin":
                    {
                        p2 = new Assassin(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
                        break;
                    }
                case "Monk":
                    {
                        p2 = new Monk(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
                        break;
                    }
                case "Swordsman":
                    {
                        p2 = new Swordsman(ChooseHeroes.hp2, ChooseHeroes.damage2, ChooseHeroes.armor2);
                        break;
                    }
            }

            string heroOneType = p1.GetType().ToString().Remove(0, 11);
            string heroTwoType = p2.GetType().ToString().Remove(0, 11);

            battleLog.Clear();
            Player1_type.Text = heroOneType; Player2_type.Text = heroTwoType;

            timeSec = 0; timeMin = 0;
            timerDisplay.Text = "00:00";
            gameTimer.Start();

            progressBar_hp1.Minimum = 0;
            progressBar_hp1.Maximum = p1.HealthPoints;
            progressBar_hp1.Value = p1.HealthPoints;
            progressBar_hp2.Minimum = 0;
            progressBar_hp2.Maximum = p2.HealthPoints;
            progressBar_hp2.Value = p2.HealthPoints;



            battleLog.Text += heroOneType + " VS " + heroTwoType + Environment.NewLine;
            int dmg1, dmg2;

            while (p1.IsAlive() && p2.IsAlive())
            {
                try
                {
                    soundsPlayer.Ctlcontrols.stop();
                    if (NoSound_butt.Checked)
                    {
                        soundsPlayer.Ctlcontrols.stop();
                    }
                    else if (rand.Next() % 2 == 0)
                    {
                        soundsPlayer.URL = @"sounds/hit2.mp3";
                    }
                    else
                    {
                        soundsPlayer.URL = @"sounds/hit3.mp3";
                    }
                }
                catch (Exception)
                {
                    return;
                }

                Player1_box.BringToFront();
                Player1_box.Image = Image.FromFile("../../resourses/animations/knight1Hit.gif");
                Pause(pause);

                dmg1 = p2.HealthPoints - GameEngine.PlayerOneHit(p1, p2);

                battleLog.Text += heroOneType + " give damage: " + dmg1 + p1.IsAbilityUsed() + p2.IsAbilityUsed() + Environment.NewLine;
                p1.Ability = null; p2.Ability = null;

                currentHp2.Text = p2.HealthPoints.ToString();
                currentDamage1.Text = "-" + dmg1;
                currentDamage2.Text = "";
                try
                {
                    progressBar_hp2.Value = p2.HealthPoints;
                }
                catch (Exception)
                {
                    gameTimer.Stop();
                    progressBar_hp2.Value = progressBar_hp2.Minimum;
                    battleLog.Text += $"{heroOneType} HP: {p1.HealthPoints}    {heroTwoType} HP: 0" + Environment.NewLine;
                    battleLog.Text += "Winer: " + heroOneType + Environment.NewLine + "Time: " + timerDisplay.Text + Environment.NewLine; ;
                    currentHp2.Text = "0"; currentDamage1.Text = "";
                    break;
                }

                Player1_box.Image = Image.FromFile("../../resourses/animations/knight1Stay.png");
                Player2_box.BringToFront();
                Player2_box.Image = Image.FromFile("../../resourses/animations/knight2Hit.gif");
                try
                {
                    soundsPlayer.Ctlcontrols.stop();
                    if (NoSound_butt.Checked)
                    {
                        soundsPlayer.Ctlcontrols.stop();
                    }
                    else if (rand.Next() % 2 == 0)
                    {
                        soundsPlayer.URL = @"sounds/hit2.mp3";
                    }
                    else
                    {
                        soundsPlayer.URL = @"sounds/hit3.mp3";
                    }
                }
                catch (Exception)
                {
                    return;
                }

                Pause(pause);


                dmg2 = p1.HealthPoints - GameEngine.PlayerTwoHit(p1, p2);

                battleLog.Text += heroTwoType + " give damage: " + dmg2 + p1.IsAbilityUsed() + p2.IsAbilityUsed() + Environment.NewLine;
                p2.Ability = null; p1.Ability = null;
                currentHp1.Text = p1.HealthPoints.ToString();

                currentDamage2.Text = "-" + dmg2;
                currentDamage1.Text = "";
                try
                {
                    progressBar_hp1.Value = p1.HealthPoints;
                }
                catch (Exception)
                {
                    gameTimer.Stop();
                    progressBar_hp1.Value = progressBar_hp1.Minimum;
                    battleLog.Text += $"{heroOneType} HP: 0    {heroTwoType} HP: {p2.HealthPoints}" + Environment.NewLine;
                    battleLog.Text += "Winer: " + heroTwoType + Environment.NewLine + "Time: " + timerDisplay.Text + Environment.NewLine;
                    currentHp1.Text = "0"; currentDamage2.Text = "";
                    break;
                }
                Player2_box.Image = Image.FromFile("../../resourses/animations/knight2Stay.png");
            }
            Player1_box.Image = Image.FromFile("../../resourses/animations/knight1Stay.png");
            Player2_box.Image = Image.FromFile("../../resourses/animations/knight2Stay.png");
            startGame_butt.Enabled = true;
        }
    }
}
