using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int QuickSettingsSelection = 0, dx, dy, lineX, lineY;
        bool canDraw = false;
        Graphics graphics;
        Pen pen;

        private void Form1_Load(object sender, EventArgs e)
        {
            pen      = new Pen(buttonPenColour.BackColor, trackBarPenSize.Value);
            graphics = panel1.CreateGraphics();
        }

        private void ChangeQuickSettingButton(Button toChange, params Button[] buttonsUnselected)
        {
            toChange.BackColor = Color.DarkGreen;
            toChange.ForeColor = Color.White;

            foreach (Button b in buttonsUnselected)
            {
                b.BackColor = Color.FromArgb(224, 224, 224);
                b.ForeColor = Color.Black;
            }
        }

        //τα κουμπιά που επιλέγουν τον τύπο της ζωγραφικής
        private void buttonFreestyleDraw_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 1;
            ChangeQuickSettingButton(buttonFreestyleDraw, buttonLineSegment, buttonEllipse, buttonCircle);

            buttonEraser.BackColor = Color.FromArgb(255, 128, 128);
            buttonEraser.ForeColor = Color.Black;
        }

        private void buttonLineSegment_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 2;
            ChangeQuickSettingButton(buttonLineSegment, buttonFreestyleDraw, buttonEllipse, buttonCircle);

            buttonEraser.BackColor = Color.FromArgb(255, 128, 128);
            buttonEraser.ForeColor = Color.Black;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 3;
            ChangeQuickSettingButton(buttonEllipse, buttonFreestyleDraw, buttonLineSegment, buttonCircle);

            buttonEraser.BackColor = Color.FromArgb(255, 128, 128);
            buttonEraser.ForeColor = Color.Black;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 4;
            ChangeQuickSettingButton(buttonCircle, buttonFreestyleDraw, buttonLineSegment, buttonEllipse);

            buttonEraser.BackColor = Color.FromArgb(255, 128, 128);
            buttonEraser.ForeColor = Color.Black;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 5;
            ChangeQuickSettingButton(new Button(), buttonFreestyleDraw, buttonLineSegment, buttonEllipse, buttonCircle);

            buttonEraser.BackColor = Color.Maroon;
            buttonEraser.ForeColor = Color.White;
        }

        //το κουμπί της εξόδου (θα ρωτάει και αν θέλει ο χρήστης να φύγει)
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //κουμπί για την αλλαγή του pen
        private void buttonPenColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            buttonPenColour.BackColor = colorDialog1.Color;
            pen.Color                 = colorDialog1.Color;

            if (buttonPenColour.BackColor.GetBrightness() > 0.45)
                buttonPenColour.ForeColor = Color.Black;
            else
                buttonPenColour.ForeColor = Color.White;
        }

        private void buttonSelectBackgroundColour_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            panel1.BackColor = colorDialog2.Color;
        }

        private void trackBarPenSize_Scroll(object sender, EventArgs e)
        {
            labelPenSize.Text = "Pen Size: " + trackBarPenSize.Value.ToString();
            pen.Width = trackBarPenSize.Value*2;
        }

        //πράττουμε ανάλογα με τις ενέργειες που έχει επιλέξει ο χρήστης.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!canDraw)
                return;

            switch (QuickSettingsSelection)
            {
                case 1:
                    graphics.DrawLine(pen, e.X, e.Y, dx, dy);
                    dx = e.X;
                    dy = e.Y;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Pen eraser = new Pen(panel1.BackColor, trackBarPenSize.Value * 4);
                    graphics.DrawLine(eraser, e.X, e.Y, dx, dy);
                    dx = e.X;
                    dy = e.Y;
                    break;
            }   
        }

        //αν το ποντίκι είναι πατημένο εντός του πάνελ, τότε ενεργοποιούμε την canDraw, ώστε να μπορεί να ζωγραφίσει ο χρήστης
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canDraw = true;
            dx = e.X;
            dy = e.Y;

            lineX = e.X;
            lineY = e.Y;
        }

        private void buttonEraseEverything_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the canvas? Effects cannot be reverted.", "Clear Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            graphics.Clear(panel1.BackColor);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;

            switch (QuickSettingsSelection)
            {
                case 2:
                    graphics.DrawLine(pen, e.X, e.Y, lineX, lineY);
                    break;
                case 3:
                    Rectangle rect = new Rectangle();
                    rect.X = lineX;
                    rect.Y = lineY;
                    rect.Width = Math.Abs(lineX - e.X);
                    rect.Height = Math.Abs(lineY - e.Y);
                    graphics.DrawEllipse(pen, rect);
                    break;
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }
    }
}
