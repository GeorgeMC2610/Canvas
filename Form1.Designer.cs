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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapes = new csharp_vathmologoumeni_2.Shapes();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundImageHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxHandling = new System.Windows.Forms.ToolStripComboBox();
            this.manageDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theCreatorOfThisAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBoxSelfGeneratingDesigns = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.saveFileDialogCanvas = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogCanvas = new System.Windows.Forms.OpenFileDialog();
            this.timerHouse = new System.Windows.Forms.Timer(this.components);
            this.timerCube = new System.Windows.Forms.Timer(this.components);
            this.timerMail = new System.Windows.Forms.Timer(this.components);
            this.timerStickman = new System.Windows.Forms.Timer(this.components);
            this.shapesTableAdapter = new csharp_vathmologoumeni_2.ShapesTableAdapters.ShapesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxQuickSettings.SuspendLayout();
            this.groupBoxDrawingSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).BeginInit();
            this.groupBoxSelfGeneratingDesigns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BorderStyle", this.shapesBindingSource, "Type", true));
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
            // shapesBindingSource
            // 
            this.shapesBindingSource.DataMember = "Shapes";
            this.shapesBindingSource.DataSource = this.shapes;
            // 
            // shapes
            // 
            this.shapes.DataSetName = "Shapes";
            this.shapes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1782, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColourToolStripMenuItem,
            this.selectBackgroundImageToolStripMenuItem,
            this.selectBackgroundImageHandlingToolStripMenuItem,
            this.manageDatabaseToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // selectColourToolStripMenuItem
            // 
            this.selectColourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forBackgroundToolStripMenuItem,
            this.forPenToolStripMenuItem});
            this.selectColourToolStripMenuItem.Name = "selectColourToolStripMenuItem";
            this.selectColourToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.selectColourToolStripMenuItem.Text = "Select Color";
            // 
            // forBackgroundToolStripMenuItem
            // 
            this.forBackgroundToolStripMenuItem.Name = "forBackgroundToolStripMenuItem";
            this.forBackgroundToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.forBackgroundToolStripMenuItem.Text = "For Background";
            this.forBackgroundToolStripMenuItem.Click += new System.EventHandler(this.SelectColorToolStrip_Click);
            // 
            // forPenToolStripMenuItem
            // 
            this.forPenToolStripMenuItem.Name = "forPenToolStripMenuItem";
            this.forPenToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.forPenToolStripMenuItem.Text = "For Pen";
            this.forPenToolStripMenuItem.Click += new System.EventHandler(this.SelectColorToolStrip_Click);
            // 
            // selectBackgroundImageToolStripMenuItem
            // 
            this.selectBackgroundImageToolStripMenuItem.Name = "selectBackgroundImageToolStripMenuItem";
            this.selectBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.selectBackgroundImageToolStripMenuItem.Text = "Select Background Image...";
            this.selectBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.selectBackgroundImageToolStripMenuItem_Click);
            // 
            // selectBackgroundImageHandlingToolStripMenuItem
            // 
            this.selectBackgroundImageHandlingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxHandling});
            this.selectBackgroundImageHandlingToolStripMenuItem.Name = "selectBackgroundImageHandlingToolStripMenuItem";
            this.selectBackgroundImageHandlingToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.selectBackgroundImageHandlingToolStripMenuItem.Text = "Select Background Image Handling";
            // 
            // toolStripComboBoxHandling
            // 
            this.toolStripComboBoxHandling.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.toolStripComboBoxHandling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxHandling.Items.AddRange(new object[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.toolStripComboBoxHandling.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripComboBoxHandling.Name = "toolStripComboBoxHandling";
            this.toolStripComboBoxHandling.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxHandling.SelectedIndexChanged += new System.EventHandler(this.BackGroundImageHandling_IndexChanged);
            // 
            // manageDatabaseToolStripMenuItem
            // 
            this.manageDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewItemsToolStripMenuItem,
            this.clearDatabaseTableToolStripMenuItem});
            this.manageDatabaseToolStripMenuItem.Name = "manageDatabaseToolStripMenuItem";
            this.manageDatabaseToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.manageDatabaseToolStripMenuItem.Text = "Manage Database";
            // 
            // viewItemsToolStripMenuItem
            // 
            this.viewItemsToolStripMenuItem.Name = "viewItemsToolStripMenuItem";
            this.viewItemsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewItemsToolStripMenuItem.Text = "View Items";
            this.viewItemsToolStripMenuItem.Click += new System.EventHandler(this.ManageDatabaseItems_Click);
            // 
            // clearDatabaseTableToolStripMenuItem
            // 
            this.clearDatabaseTableToolStripMenuItem.Name = "clearDatabaseTableToolStripMenuItem";
            this.clearDatabaseTableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.clearDatabaseTableToolStripMenuItem.Text = "Clear Database Table";
            this.clearDatabaseTableToolStripMenuItem.Click += new System.EventHandler(this.ManageDatabaseItems_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theAppToolStripMenuItem,
            this.theCreatorOfThisAppToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // theAppToolStripMenuItem
            // 
            this.theAppToolStripMenuItem.Name = "theAppToolStripMenuItem";
            this.theAppToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.theAppToolStripMenuItem.Text = "This App";
            this.theAppToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // theCreatorOfThisAppToolStripMenuItem
            // 
            this.theCreatorOfThisAppToolStripMenuItem.Name = "theCreatorOfThisAppToolStripMenuItem";
            this.theCreatorOfThisAppToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.theCreatorOfThisAppToolStripMenuItem.Text = "The Creator Of This App";
            this.theCreatorOfThisAppToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
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
            this.groupBoxDrawingSettings.Controls.Add(this.labelPenSize);
            this.groupBoxDrawingSettings.Controls.Add(this.trackBarPenSize);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonEraseEverything);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonSelectBackgroundColour);
            this.groupBoxDrawingSettings.Controls.Add(this.buttonPenColour);
            this.groupBoxDrawingSettings.Location = new System.Drawing.Point(12, 315);
            this.groupBoxDrawingSettings.Name = "groupBoxDrawingSettings";
            this.groupBoxDrawingSettings.Size = new System.Drawing.Size(246, 221);
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
            this.buttonEraseEverything.Location = new System.Drawing.Point(6, 179);
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
            this.buttonSelectBackgroundColour.Location = new System.Drawing.Point(6, 144);
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
            // groupBoxSelfGeneratingDesigns
            // 
            this.groupBoxSelfGeneratingDesigns.Controls.Add(this.button1);
            this.groupBoxSelfGeneratingDesigns.Controls.Add(this.button3);
            this.groupBoxSelfGeneratingDesigns.Controls.Add(this.buttonCube);
            this.groupBoxSelfGeneratingDesigns.Controls.Add(this.buttonHouse);
            this.groupBoxSelfGeneratingDesigns.Location = new System.Drawing.Point(12, 591);
            this.groupBoxSelfGeneratingDesigns.Name = "groupBoxSelfGeneratingDesigns";
            this.groupBoxSelfGeneratingDesigns.Size = new System.Drawing.Size(246, 189);
            this.groupBoxSelfGeneratingDesigns.TabIndex = 10;
            this.groupBoxSelfGeneratingDesigns.TabStop = false;
            this.groupBoxSelfGeneratingDesigns.Text = "Self-Generating Designs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 32);
            this.button1.TabIndex = 12;
            this.button1.Tag = "4";
            this.button1.Text = "Stickman";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SelfGeneratingDesigns_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 99);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 32);
            this.button3.TabIndex = 11;
            this.button3.Tag = "3";
            this.button3.Text = "Mail";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SelfGeneratingDesigns_Click);
            // 
            // buttonCube
            // 
            this.buttonCube.BackColor = System.Drawing.Color.Silver;
            this.buttonCube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCube.ForeColor = System.Drawing.Color.Black;
            this.buttonCube.Location = new System.Drawing.Point(6, 63);
            this.buttonCube.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(234, 32);
            this.buttonCube.TabIndex = 10;
            this.buttonCube.Tag = "2";
            this.buttonCube.Text = "Cube";
            this.buttonCube.UseVisualStyleBackColor = false;
            this.buttonCube.Click += new System.EventHandler(this.SelfGeneratingDesigns_Click);
            // 
            // buttonHouse
            // 
            this.buttonHouse.BackColor = System.Drawing.Color.Silver;
            this.buttonHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHouse.ForeColor = System.Drawing.Color.Black;
            this.buttonHouse.Location = new System.Drawing.Point(6, 27);
            this.buttonHouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(234, 32);
            this.buttonHouse.TabIndex = 9;
            this.buttonHouse.Tag = "1";
            this.buttonHouse.Text = "House";
            this.buttonHouse.UseVisualStyleBackColor = false;
            this.buttonHouse.Click += new System.EventHandler(this.SelfGeneratingDesigns_Click);
            // 
            // saveFileDialogCanvas
            // 
            this.saveFileDialogCanvas.DefaultExt = "jpg";
            this.saveFileDialogCanvas.Filter = "SER Files|*.ser";
            // 
            // openFileDialogCanvas
            // 
            this.openFileDialogCanvas.DefaultExt = "ser";
            this.openFileDialogCanvas.Filter = "JPEG Icons|*.jpg|BMP Icons|*.bmp|PNG Icons|*.png|TGA Icons|*.tga";
            // 
            // timerHouse
            // 
            this.timerHouse.Interval = 300;
            this.timerHouse.Tick += new System.EventHandler(this.timerHouse_Tick);
            // 
            // timerCube
            // 
            this.timerCube.Interval = 300;
            this.timerCube.Tick += new System.EventHandler(this.timerCube_Tick);
            // 
            // timerMail
            // 
            this.timerMail.Interval = 300;
            this.timerMail.Tick += new System.EventHandler(this.timerMail_Tick);
            // 
            // timerStickman
            // 
            this.timerStickman.Interval = 300;
            this.timerStickman.Tick += new System.EventHandler(this.timerStickman_Tick);
            // 
            // shapesTableAdapter
            // 
            this.shapesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1782, 961);
            this.Controls.Add(this.groupBoxSelfGeneratingDesigns);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxQuickSettings.ResumeLayout(false);
            this.groupBoxDrawingSettings.ResumeLayout(false);
            this.groupBoxDrawingSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).EndInit();
            this.groupBoxSelfGeneratingDesigns.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.Button buttonEraseEverything;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label labelPenSize;
        private System.Windows.Forms.TrackBar trackBarPenSize;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.GroupBox groupBoxSelfGeneratingDesigns;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button button1;
        private Shapes shapes;
        private System.Windows.Forms.BindingSource shapesBindingSource;
        private ShapesTableAdapters.ShapesTableAdapter shapesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem selectColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forPenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCanvas;
        private System.Windows.Forms.OpenFileDialog openFileDialogCanvas;
        private System.Windows.Forms.Timer timerHouse;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundImageHandlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxHandling;
        private System.Windows.Forms.ToolStripMenuItem manageDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseTableToolStripMenuItem;
        private System.Windows.Forms.Timer timerCube;
        private System.Windows.Forms.Timer timerMail;
        private System.Windows.Forms.Timer timerStickman;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theCreatorOfThisAppToolStripMenuItem;
    }
}

