using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadlyDuel
{
    public partial class ChooseHeroes : Form
    {
        public static int hp1, damage1, armor1, hp2, damage2, armor2;
        public static string type1, type2;


        public ChooseHeroes()
        {
            InitializeComponent();
        }
        private void ChooseHeroes_Load(object sender, EventArgs e)
        {

        }
     
        int chooseHero = 0;
        private void hero1_type_Click(object sender, EventArgs e)
        {
            chooseHero++;

            switch (chooseHero)
            {
                case 1:
                    {
                        hero1_type.Text = "Warrior";
                        break;
                    }
                case 2:
                    {
                        hero1_type.Text = "Knight";
                        break;
                    }
                case 3:
                    {
                        hero1_type.Text = "Assassin";
                        break;
                    }
                case 4:
                    {
                        hero1_type.Text = "Monk";
                        break;
                    }
                case 5:
                    {
                        hero1_type.Text = "Swordsman";
                        chooseHero = 0;
                        break;
                    }
            }
            viewHero1.Image = Image.FromFile("../../resourses/animations/knight1Stay.png");
        }

        int chooseHero2 = 0;
        private void hero2_type_Click(object sender, EventArgs e)
        {
            chooseHero2++;
            switch (chooseHero2)
            {
                case 1:
                    {
                        hero2_type.Text = "Warrior";
                        break;
                    }
                case 2:
                    {
                        hero2_type.Text = "Knight";
                        break;
                    }
                case 3:
                    {
                        hero2_type.Text = "Assassin";
                        break;
                    }
                case 4:
                    {
                        hero2_type.Text = "Monk";
                        break;
                    }
                case 5:
                    {
                        hero2_type.Text = "Swordsman";
                        chooseHero2 = 0;
                        break;
                    }                   
            }
            viewHero2.Image = Image.FromFile("../../resourses/animations/knight2Stay.png");
        }

        private void Fight_butt_Click(object sender, EventArgs e)
        {
            type1 = hero1_type.Text; type2 = hero2_type.Text;
            hp1 = trackBar1_hp.Value; hp2 = trackBar2_hp.Value;
            damage1 = trackBar1_damage.Value; damage2 = trackBar2_damage.Value;
            armor1 = trackBar1_armor.Value; armor2 = trackBar2_armor.Value;
            Close();
        }

        public  void trackBar1_hp_Scroll(object sender, EventArgs e)
        {
            textBox_hp.Text = "Hp: " + trackBar1_hp.Value.ToString();
        }

        private void textBox_hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_damage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_armor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_damage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_armor_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_armor_Scroll(object sender, EventArgs e)
        {
            textBox2_armor.Text = "Armor: " + trackBar2_armor.Value.ToString();
        }

        private void trackBar2_damage_Scroll(object sender, EventArgs e)
        {
            textBox2_damage.Text = "Damage: " + trackBar2_damage.Value.ToString();
        }

        private void trackBar2_hp_Scroll(object sender, EventArgs e)
        {
            textBox2_hp.Text = "Hp: " + trackBar2_hp.Value.ToString();
        }

        private void trackBar1_damage_Scroll(object sender, EventArgs e)
        {
            textBox1_damage.Text = "Damage: " + trackBar1_damage.Value.ToString();
        }

        private void trackBar1_armor_Scroll(object sender, EventArgs e)
        {
            textBox1_armor.Text = "Armor: " + trackBar1_armor.Value.ToString();
        }
    }
}
