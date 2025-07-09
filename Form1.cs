using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 255, 255);

            Pen whitePen = new Pen(color, 15);

            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 850, 140, 850, 620);

        }

        private void get_picture(PictureBox pictureBox)
        {
            if (pictureBox.Tag == "X" || pictureBox.Tag == "O")
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbl_player.Text == "Player 1")
                {
                    pictureBox.Image = Properties.Resources.X;
                    pictureBox.Tag = "X";
                    lbl_player.Text = "Player 2";
                }
                else if (lbl_player.Text == "Player 2")
                {
                    pictureBox.Image = Properties.Resources.O;
                    pictureBox.Tag = "O";
                    lbl_player.Text = "Player 1";
                }
            }
        }

        private void check_winner()
        {
            if ((pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag) ||
                (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag) ||
                (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag) ||
                (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag) ||
                (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag) ||
                (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag) ||
                (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag) ||
                (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag))
            {
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string winner = "";

                if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag)
                {
                    winner = pictureBox1.Tag.ToString();
                    pictureBox1.BackColor = pictureBox2.BackColor = pictureBox3.BackColor = Color.GreenYellow;
                }
                else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag)
                {
                    winner = pictureBox4.Tag.ToString();
                    pictureBox4.BackColor = pictureBox5.BackColor = pictureBox6.BackColor = Color.GreenYellow;

                }
                else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag)
                {
                    winner = pictureBox7.Tag.ToString();
                    pictureBox7.BackColor = pictureBox8.BackColor = pictureBox9.BackColor = Color.GreenYellow;

                }
                else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag)
                {
                    winner = pictureBox1.Tag.ToString();
                    pictureBox1.BackColor = pictureBox4.BackColor = pictureBox7.BackColor = Color.GreenYellow;
                }
                else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag)
                {
                    winner = pictureBox2.Tag.ToString();
                    pictureBox2.BackColor = pictureBox5.BackColor = pictureBox8.BackColor = Color.GreenYellow;
                }
                else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag)
                {
                    winner = pictureBox3.Tag.ToString();
                    pictureBox3.BackColor = pictureBox6.BackColor = pictureBox9.BackColor = Color.GreenYellow;
                }
                else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag)
                {
                    winner = pictureBox1.Tag.ToString();
                    pictureBox1.BackColor = pictureBox5.BackColor = pictureBox9.BackColor = Color.GreenYellow;

                }
                else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag)
                {
                    winner = pictureBox3.Tag.ToString();
                    pictureBox3.BackColor = pictureBox5.BackColor = pictureBox7.BackColor = Color.GreenYellow;

                }

                if (winner == "X")
                {
                    lbl_winner.Text = "Player1";
                    lbl_player.Text = "Game Over";
                }
                else if (winner == "O")
                {
                    lbl_winner.Text = "Player2";
                    lbl_player.Text = "Game Over";
                }
                
            }

            else
            {
                bool isDraw =
                pictureBox1.Tag.ToString() != "1" &&
                pictureBox2.Tag.ToString() != "2" &&
                pictureBox3.Tag.ToString() != "3" &&
                pictureBox4.Tag.ToString() != "4" &&
                pictureBox5.Tag.ToString() != "5" &&
                pictureBox6.Tag.ToString() != "6" &&
                pictureBox7.Tag.ToString() != "7" &&
                pictureBox8.Tag.ToString() != "8" &&
                pictureBox9.Tag.ToString() != "9";

                if (isDraw)
                {
                    MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_winner.Text = "Draw";
                    lbl_player.Text = "Game Over";
                }
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            get_picture((PictureBox)sender);
            check_winner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.question_mark_96;
            pictureBox2.Image = Properties.Resources.question_mark_96;
            pictureBox3.Image = Properties.Resources.question_mark_96;
            pictureBox4.Image = Properties.Resources.question_mark_96;
            pictureBox5.Image = Properties.Resources.question_mark_96;
            pictureBox6.Image = Properties.Resources.question_mark_96;
            pictureBox7.Image = Properties.Resources.question_mark_96;
            pictureBox8.Image = Properties.Resources.question_mark_96;
            pictureBox9.Image = Properties.Resources.question_mark_96;

            pictureBox1.Tag = "1";
            pictureBox2.Tag = "2";
            pictureBox3.Tag = "3";
            pictureBox4.Tag = "4";
            pictureBox5.Tag = "5";
            pictureBox6.Tag = "6";
            pictureBox7.Tag = "7";
            pictureBox8.Tag = "8";
            pictureBox9.Tag = "9";

            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BackColor = Color.Black;

            lbl_player.Text = "Player 1";
            lbl_winner.Text = "In Progress";
        }
    }
}
