namespace csharp_vathmologoumeni_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFreestyleDraw = new System.Windows.Forms.Button();
            this.buttonLineSegment = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.groupBoxQuickSettings = new System.Windows.Forms.GroupBox();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.groupBoxDrawingSettings = new System.Windows.Forms.GroupBox();
            this.labelPenSize = new System.Windows.Forms.Label();
            this.trackBarPenSize = new System.Windows.Forms.TrackBar();
            this.buttonEraseEverything = new System.Windows.Forms.Button();
            this.buttonSelectBackgroundColour = new System.Windows.Forms.Button();
            this.buttonPenColour = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxQuickSettings.SuspendLayout();
            this.groupBoxDrawingSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(264, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 914);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1782, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveAsToolStripMenuItem.Text = "Save To Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // buttonFreestyleDraw
            // 
            this.buttonFreestyleDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFreestyleDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFreestyleDraw.ForeColor = System.Drawing.Color.Black;
            this.buttonFreestyleDraw.Location = new System.Drawing.Point(6, 27);
            this.buttonFreestyleDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFreestyleDraw.Name = "buttonFreestyleDraw";
            this.buttonFreestyleDraw.Size = new System.Drawing.Size(234, 32);
            this.buttonFreestyleDraw.TabIndex = 1;
            this.buttonFreestyleDraw.Tag = "1";
            this.buttonFreestyleDraw.Text = "Freestyle Draw";
            this.buttonFreestyleDraw.UseVisualStyleBackColor = false;
            this.buttonFreestyleDraw.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // buttonLineSegment
            // 
            this.buttonLineSegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLineSegment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLineSegment.ForeColor = System.Drawing.Color.Black;
            this.buttonLineSegment.Location = new System.Drawing.Point(6, 63);
            this.buttonLineSegment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLineSegment.Name = "buttonLineSegment";
            this.buttonLineSegment.Size = new System.Drawing.Size(234, 32);
            this.buttonLineSegment.TabIndex = 2;
            this.buttonLineSegment.Tag = "2";
            this.buttonLineSegment.Text = "Line Segment";
            this.buttonLineSegment.UseVisualStyleBackColor = false;
            this.buttonLineSegment.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEllipse.ForeColor = System.Drawing.Color.Black;
            this.buttonEllipse.Location = new System.Drawing.Point(6, 99);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(234, 32);
            this.buttonEllipse.TabIndex = 3;
            this.buttonEllipse.Tag = "3";
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCircle.ForeColor = System.Drawing.Color.Black;
            this.buttonCircle.Location = new System.Drawing.Point(6, 135);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(234, 32);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.Tag = "4";
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // groupBoxQuickSettings
            // 
            this.groupBoxQuickSettings.Controls.Add(this.buttonRectangle);
            this.groupBoxQuickSettings.Controls.Add(this.buttonEraser);
            this.groupBoxQuickSettings.Controls.Add(this.buttonFreestyleDraw);
            this.groupBoxQuickSettings.Controls.Add(this.buttonCircle);
            this.groupBoxQuickSettings.Controls.Add(this.buttonLineSegment);
            this.groupBoxQuickSettings.Controls.Add(this.buttonEllipse);
            this.groupBoxQuickSettings.ForeColor = System.Drawing.Color.Black;
            this.groupBoxQuickSettings.Location = new System.Drawing.Point(12, 32);
            this.groupBoxQuickSettings.Name = "groupBoxQuickSettings";
            this.groupBoxQuickSettings.Size = new System.Drawing.Size(246, 250);
            this.groupBoxQuickSettings.TabIndex = 6;
            this.groupBoxQuickSettings.TabStop = false;
            this.groupBoxQuickSettings.Text = "Quick Settings";
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRectangle.ForeColor = System.Drawing.Color.Black;
            this.buttonRectangle.Location = new System.Drawing.Point(6, 171);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(234, 32);
            this.buttonRectangle.TabIndex = 5;
            this.buttonRectangle.Tag = "5";
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEraser.ForeColor = System.Drawing.Color.Black;
            this.buttonEraser.Location = new System.Drawing.Point(6, 208);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(234, 32);
            this.buttonEraser.TabIndex = 6;
            this.buttonEraser.Tag = "6";
            this.buttonEraser.Text = "Eraser";
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.ButtonsInQuickSettingsClick);
            // 
            // groupBoxDrawingSettings
            // 
            this.groupBoxDrawingSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxDrawingSettings.Controls.Add(this.labelPenSize);
            this.groupBoxDrawingSettings.Controls.Add(this.trackBarPenSize);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonEraseEverything);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonSelectBackgroundColour);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonPenColour);
            this.groupBoxDrawingSettings.Location = new System.Drawing.Point(12, 315);
            this.groupBoxDrawingSettings.Name = "groupBoxDrawingSettings";
            this.groupBoxDrawingSettings.Size = new System.Drawing.Size(246, 245);
            this.groupBoxDrawingSettings.TabIndex = 8;
            this.groupBoxDrawingSettings.TabStop = false;
            this.groupBoxDrawingSettings.Text = "Drawing Settings";
            // 
            // labelPenSize
            // 
            this.labelPenSize.AutoSize = true;
            this.labelPenSize.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.labelPenSize.Location = new System.Drawing.Point(82, 35);
            this.labelPenSize.Name = "labelPenSize";
            this.labelPenSize.Size = new System.Drawing.Size(83, 19);
            this.labelPenSize.TabIndex = 12;
            this.labelPenSize.Text = "Pen Size: 1";
            // 
            // trackBarPenSize
            // 
            this.trackBarPenSize.LargeChange = 2;
            this.trackBarPenSize.Location = new System.Drawing.Point(6, 57);
            this.trackBarPenSize.Maximum = 11;
            this.trackBarPenSize.Minimum = 1;
            this.trackBarPenSize.Name = "trackBarPenSize";
            this.trackBarPenSize.Size = new System.Drawing.Size(234, 45);
            this.trackBarPenSize.TabIndex = 11;
            this.trackBarPenSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPenSize.Value = 1;
            this.trackBarPenSize.Scroll += new System.EventHandler(this.trackBarPenSize_Scroll);
            // 
            // buttonEraseEverything
            // 
            this.buttonEraseEverything.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEraseEverything.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEraseEverything.ForeColor = System.Drawing.Color.White;
            this.buttonEraseEverything.Location = new System.Drawing.Point(6, 189);
            this.buttonEraseEverything.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEraseEverything.Name = "buttonEraseEverything";
            this.buttonEraseEverything.Size = new System.Drawing.Size(234, 32);
            this.buttonEraseEverything.TabIndex = 10;
            this.buttonEraseEverything.Text = "Erase Everything From Canvas";
            this.buttonEraseEverything.UseVisualStyleBackColor = false;
            this.buttonEraseEverything.Click += new System.EventHandler(this.buttonEraseEverything_Click);
            // 
            // buttonSelectBackgroundColour
            // 
            this.buttonSelectBackgroundColour.BackColor = System.Drawing.Color.Silver;
            this.buttonSelectBackgroundColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectBackgroundColour.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectBackgroundColour.Location = new System.Drawing.Point(6, 149);
            this.buttonSelectBackgroundColour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectBackgroundColour.Name = "buttonSelectBackgroundColour";
            this.buttonSelectBackgroundColour.Size = new System.Drawing.Size(234, 32);
            this.buttonSelectBackgroundColour.TabIndex = 9;
            this.buttonSelectBackgroundColour.Text = "Select Background Colour";
            this.buttonSelectBackgroundColour.UseVisualStyleBackColor = false;
            this.buttonSelectBackgroundColour.Click += new System.EventHandler(this.buttonSelectBackgroundColour_Click);
            // 
            // buttonPenColour
            // 
            this.buttonPenColour.BackColor = System.Drawing.Color.Silver;
            this.buttonPenColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPenColour.ForeColor = System.Drawing.Color.Black;
            this.buttonPenColour.Location = new System.Drawing.Point(6, 109);
            this.buttonPenColour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPenColour.Name = "buttonPenColour";
            this.buttonPenColour.Size = new System.Drawing.Size(234, 32);
            this.buttonPenColour.TabIndex = 8;
            this.buttonPenColour.Text = "Select Pen Colour";
            this.buttonPenColour.UseVisualStyleBackColor = false;
            this.buttonPenColour.Click += new System.EventHandler(this.buttonPenColour_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(12, 915);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 33);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Self-Generating Designs";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 32);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cube";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "House";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1782, 961);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxDrawingSettings);
            this.Controls.Add(this.groupBoxQuickSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canvas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxQuickSettings.ResumeLayout(false);
            this.groupBoxDrawingSettings.ResumeLayout(false);
            this.groupBoxDrawingSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonFreestyleDraw;
        private System.Windows.Forms.Button buttonLineSegment;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.GroupBox groupBoxQuickSettings;
        private System.Windows.Forms.GroupBox groupBoxDrawingSettings;
        private System.Windows.Forms.Button buttonPenColour;
        private System.Windows.Forms.Button buttonSelectBackgroundColour;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button buttonEraseEverything;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label labelPenSize;
        private System.Windows.Forms.TrackBar trackBarPenSize;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

