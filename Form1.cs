﻿using System;
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
                case 6:
                    Pen eraser = new Pen(panel1.BackColor, trackBarPenSize.Value * 4);
                    graphics.DrawLine(eraser, e.X, e.Y, dx, dy);
                    dx = e.X;
                    dy = e.Y;
                    break;
            }   
        }

        //τα κουμπιά στο group box των quick settings, χρησιμοποιούν την ίδια συνάρτηση όταν κλικάρονται
        private void ButtonsInQuickSettingsClick(object sender, EventArgs e)
        {
            //παίρνουμε το κουμπί που πατήθηκε και βάζουμε το tag του στην μεταβλτή που έχουμε θέσει για τα quicksettings
            Button buttonClicked   = (Button)sender;
            QuickSettingsSelection = int.Parse(buttonClicked.Tag.ToString());

            //ύστερα παίρνουμε όλα τα κουμπιά
            Button[] QuickSettingsButtons = { buttonFreestyleDraw, buttonLineSegment, buttonEllipse, buttonCircle, buttonRectangle };
            //αν το κουμπί είναι η σβήστρα
            if (QuickSettingsSelection == 6)
            {
                //τότε χρησιμοποιούμε την συνάρτησή μας, με ορίσματα ένα dummy κουμπί στο πρώτο όρισμα, ώστε να μην αλλάξει κάτι που δεν θέλουμε. Μετά βάζουμε τα υπόλοιπα κουμπιά για να γίνουν όλα γκρίζα.
                foreach (Button b in QuickSettingsButtons)
                {
                    b.BackColor = Color.FromArgb(224, 224, 224);
                    b.ForeColor = Color.Black;
                }

                //ύστερα κάνουμε μόνοι μας τη δουλειά της αλλαγής χρώματος
                buttonClicked.BackColor = Color.FromArgb(192, 0, 0);
                buttonClicked.ForeColor = Color.White;

                return;
            }

            //χρησιμοποιώντας LINQ, βγάζουμε το κουμπί που πατήθηκε από τη λίστα όλων των κουμπιών.
            var temp = from button in QuickSettingsButtons where button.Tag != buttonClicked.Tag select button;
            Button[] toBeChanged = temp.ToArray();

            //και μετά βάζουμε τα ανάλογα χρώματα στα κουμπιά
            buttonClicked.BackColor = Color.DarkGreen;
            buttonClicked.ForeColor = Color.White;

            foreach (Button b in toBeChanged)
            {
                b.BackColor = Color.FromArgb(224, 224, 224);
                b.ForeColor = Color.Black;
            }

            buttonEraser.BackColor = Color.FromArgb(255, 128, 128);
            buttonEraser.ForeColor = Color.Black;
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
                    Rectangle rectEllipse = new Rectangle();
                    rectEllipse.X         = lineX;
                    rectEllipse.Y         = lineY;
                    rectEllipse.Width     = Math.Abs(lineX - e.X);
                    rectEllipse.Height    = Math.Abs(lineY - e.Y);
                    graphics.DrawEllipse(pen, rectEllipse);
                    break;
                case 4:
                    Rectangle rectCircle = new Rectangle();
                    rectCircle.X         = rectCircle.Y = lineX;
                    rectCircle.Width     = rectCircle.Height = Math.Abs(lineX - e.X);
                    
                    graphics.DrawEllipse(pen, rectCircle);
                    break;
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }
    }
}
