using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Side_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        bool gameOver = false;
        int level = 0;
        int coins = 0;
        int armor = 0;
        int player_damage;
        int enemy_damage;
        int skillPoints = 0;

        public Form1()
        {
            InitializeComponent();

            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            try
            {
                player_damage = random.Next(30, 40);
                prgEnemyHealth.Value -= player_damage;
            }
            catch (Exception)
            {
                prgEnemyHealth.Value = 0;
            }
           
            // Disable player buttons to change turn
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;

            if (prgEnemyHealth.Value <= 0)
            {
                MessageBox.Show("PLAYER WINS!");

                int coinsGained = random.Next(5, 10);
                coins += coinsGained;
                MessageBox.Show("You gained " + coinsGained.ToString() + " coins!");

                btnAttack.Enabled = false;
                btnDefend.Enabled = false;
                btnTown.Enabled = true;
                btnBattle.Enabled = true;
                gameOver = true;

                prgXP.Value += 50;
                if (prgXP.Value == 100)
                {
                    MessageBox.Show("You leveled up!");
                    level += 1;
                    skillPoints += 1;

                    prgXP.Value = 0;
                }
            }

            if (gameOver)
            {
                prgEnemyHealth.Value = 100;
                gameOver = false;
            }
            else
            {
                if (prgHealth.Value < 0)
                {
                    MessageBox.Show("YOU LOST! (dead forever)");
                    btnAttack.Enabled = false;
                    btnDefend.Enabled = false;
                    btnTown.Enabled = false;
                    btnBattle.Enabled = false;
                }
                else
                {
                    try
                    {
                        enemy_damage = random.Next(20, 30);
                        prgHealth.Value -= enemy_damage;
                        MessageBox.Show("The enemy did " + enemy_damage.ToString() + " damage...");
                    }
                    catch (Exception)
                    {
                        prgHealth.Value = 0;
                    }

                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                }
            }   
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = true;
            btnDefend.Enabled = true;
            btnTown.Enabled = false;
            btnBattle.Enabled = false;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEALTH: " + prgHealth.Value.ToString() + "\nDAMAGE: " + player_damage.ToString() + "\nSKILL POINTS: " + skillPoints.ToString() + "\nCOINS: " + coins.ToString() + "\nARMOR: " + armor.ToString());
        }

        private void btnTown_Click(object sender, EventArgs e)
        {
            townScreen newlevel = new townScreen();
            this.Hide();
            newlevel.Show();
        }
    }
}
