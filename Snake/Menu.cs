using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menu : Form
    {
        private int choix =-1;
        public Menu()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        private void r_classic_CheckedChanged(object sender, EventArgs e)
        {
            choix = 0;
        }

        private void r_foot_CheckedChanged(object sender, EventArgs e)
        {
            choix = 1;
        }

        private void r_mine_CheckedChanged(object sender, EventArgs e)
        {
            choix = 2;
        }

        private void b_game_Click(object sender, EventArgs e)
        {
            if (choix != -1)
            {
                Hide();
                Game gm = new Game();
                gm.GameType = choix;
                choix = -1;
                gm.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Please choose a game type first.");
        }
    }
}
