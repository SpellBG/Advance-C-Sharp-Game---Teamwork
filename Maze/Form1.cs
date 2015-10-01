using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Maze : Form
    {
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");



        public Maze()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            //Play a sonud, show a MessageBox and then close the form.
            finishSoundPlayer.Play();
            MessageBox.Show("Conratulations!");
            Close();

        }

        // Play a sound, then move the pointer to the upper left corner
        // of the maze.
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a wall,
            // call MoveToStrat() method.
            MoveToStart();
        }
    }
}
