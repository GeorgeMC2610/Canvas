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

        int QuickSettingsSelection = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void buttonFreestyleDraw_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 1;
            ChangeQuickSettingButton(buttonFreestyleDraw, buttonLineSegment, buttonEllipse, buttonCircle);
        }

        private void buttonLineSegment_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 2;
            ChangeQuickSettingButton(buttonLineSegment, buttonFreestyleDraw, buttonEllipse, buttonCircle);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 3;
            ChangeQuickSettingButton(buttonEllipse, buttonFreestyleDraw, buttonLineSegment, buttonCircle);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            QuickSettingsSelection = 4;
            ChangeQuickSettingButton(buttonCircle, buttonFreestyleDraw, buttonLineSegment, buttonEllipse);
        }
    }
}