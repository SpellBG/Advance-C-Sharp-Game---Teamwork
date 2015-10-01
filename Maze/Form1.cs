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
            //Show a MessageBox and then close the form.
            MessageBox.Show("Conratulations!");
            Close();

        }

        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }
    }
}
