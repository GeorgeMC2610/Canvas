using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        OleDbConnection connection;
        OleDbCommand command;

        private void Form1_Load(object sender, EventArgs e)
        {
            //πρώτο-πρώτο πράγμα που κάνουμε με το άνοιγμα της φόρμας είναι το connection με τη βάση δεδομένων
            try
            {
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;;Data Source=database1.mdb";
                connection = new OleDbConnection(connString);
                connection.Open();
            }
            catch (Exception exc)
            {
                //αν δεν γίνει επιτυχώς, δεν ανοίγουμε καν τη φόρμα.
                MessageBox.Show("Couldn't open database. Exception error: " + exc.Message + ". \n\n Make sure the Database has EXACTLY the name 'database1.mdb', its path is inside the Debug folder and is saved as Access Database 2002-2003 format.", "Could Not Connect to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
           
            pen = new Pen(buttonPenColour.BackColor, trackBarPenSize.Value);
            graphics = panel1.CreateGraphics();
        }

        //κουμπί για την αλλαγή του pen
        private void buttonPenColour_Click(object sender, EventArgs e)
        {
            //κάθε φορά που αλλάζει ο χρήστης το χρώμα
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            //δίνουμε το ίδιο χρώμα στο κουμπί που αντιστοιχεί στην αλλαγή του χρώματος
            buttonPenColour.BackColor = colorDialog1.Color;
            pen.Color                 = colorDialog1.Color;

            //αν το χρώμα είναι πολύ σκούρο ή πολύ ανοιχτό, κάνουμε τα γράμματα του κουμπιού άσπρα ή μαύρα αντίστοιχα.
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

        private void buttonEraseEverything_Click(object sender, EventArgs e)
        {
            //αν ο χρήστης θέλει να σβήσει ό,τι έχει ο καμβάς
            if (MessageBox.Show("Are you sure you want to clear the canvas? Effects cannot be reverted.", "Clear Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            //απλώς γεμίζουμε το background με το χρώμα που έχει επιλέξει ο χρήστης.
            graphics.Clear(panel1.BackColor);
            buttonSelectBackgroundColour.Enabled = true;
            panel1.BackgroundImage = null;
        }

        private void SelfGeneratingDesigns_Click(object sender, EventArgs e)
        {
            //αν ο χώρος που θα ζωγραφίσει το πρόγραμμα είναι πολύ μικρός, τότε δεν μπαίνουμε σε αυτήν την διαδικασία. Δείχνουμε ανάλογο μήνυμα στον χρήστη
            if (panel1.Width < 500 || panel1.Height < 400)
            {
                MessageBox.Show("The panel is not big enough to draw. Resize the panel, so it has a bigger capacity and then try again", "ERROR: Panel is too small", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //αλλιώς κοιτάμε τι κουμπί πατήθηκε
            Button pressedbutton = (Button)sender;
            switch (pressedbutton.Text)
            {
                case "House":
                    houseTimer = 1;
                    timerHouse.Enabled = true;
                    break;
                case "Cube":
                    cubeTimer = 1;
                    timerCube.Enabled = true;
                    break;
                case "Mail":
                    mailTimer = 1;
                    timerMail.Enabled = true;
                    break;
                case "Stickman":
                    stickManTimer = 1;
                    timerStickman.Enabled = true;
                    break;
            }

            //κι όσο σχεδιάζεται η ζωγραφιά, απενεργοποιούμε τα κοντρόλς
            ButtonHandling(false);
        }

        //μία συνάρτηση που (απ)ενεργοποιεί τα κοντρόλς της φόρμας, ανάλογα με την βούλησή μας.
        private void ButtonHandling(bool EnableOrDisable)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals("panel1"))
                    return;

                c.Enabled = EnableOrDisable;
            }
        }

        int houseTimer = 1;
        private void timerHouse_Tick(object sender, EventArgs e)
        {
            //φτιάχνουμε όλους τους υπολογισμούς ώστε να βγει το σπίτι
            //TΙΠ: ΤΟ ΣΠΙΤΙ ΔΟΥΛΕΥΕΙ ΚΑΛΥΤΕΡΑ, ΟΤΑΝ ΔΕΝ ΕΧΕΙ ΔΙΑΦΟΡΟΠΟΙΗΘΕΙ ΤΟ ΜΕΓΕΘΟΣ ΤΟΥ ΣΠΙΤΙΟΥ.
            graphics = panel1.CreateGraphics();
            int centreX = panel1.Width / 2;
            int centreY = panel1.Height / 2;
            int multiplier = 70;
            int halfX, halfY;

            //και κάθε φορά που ανεβαίνει ο μετρητής, σχεδιάζουμε κλιμακωτά το σπίτι.
            switch (houseTimer)
            {
                case 1:
                    graphics.DrawLine(pen, centreX, centreY, centreX, centreY + multiplier);
                    break;
                case 2:
                    graphics.DrawLine(pen, centreX, centreY, centreX + (int)(multiplier *1.5), centreY);
                    break;
                case 3:
                    graphics.DrawLine(pen, centreX + (int)(multiplier * 1.5), centreY, centreX + (int)(multiplier * 1.5), centreY + multiplier);
                    break;
                case 4:
                    graphics.DrawLine(pen, centreX, centreY + multiplier, centreX + (int)(multiplier *1.5), centreY + multiplier);
                    break;
                case 5:
                    halfX = (centreX + (int)(centreX + multiplier * 1.5)) / 2;
                    halfY = (int)((int)(centreY - halfX * 0.428) * 3.5);
                    graphics.DrawLine(pen, centreX, centreY, halfX, halfY);
                    break;
                case 6:
                    halfX = (centreX + (int)(centreX + multiplier * 1.5)) / 2;
                    halfY = (int)((int)(centreY - halfX * 0.428) * 3.5);
                    graphics.DrawLine(pen, centreX + (int)(multiplier * 1.5), centreY, halfX, halfY);
                    break;
                default:
                    timerHouse.Enabled = false;
                    houseTimer = 0;
                    ButtonHandling(true);
                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('House Template', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
            }

            //μετά από κάθε επανάληψη προσθέτουμε τον μετρητή, ώστε να πάμε στο επόμενο σχέδιο.
            houseTimer++;
        }

        int cubeTimer = 1;
        private void timerCube_Tick(object sender, EventArgs e)
        {
            //φτιάχνουμε τα γραφικά
            graphics = panel1.CreateGraphics();
            int X = (panel1.Width / 2) - 10;
            int Y = (panel1.Height / 2) - 10;

            //και ύστερα (με σταθερούς συντελεστές) φτιάχνουμε διαδοχικά τον κύβο.
            switch (cubeTimer)
            {
                case 1:
                    graphics.DrawLine(pen, X, Y, X, Y + 128);
                    break;
                case 2:
                    graphics.DrawLine(pen, X, Y + 128, X + 128, Y + 128);
                    break;
                case 3:
                    graphics.DrawLine(pen, X + 128, Y + 128, X + 128, Y);
                    break;
                case 4:
                    graphics.DrawLine(pen, X + 128, Y, X, Y);
                    break;
                case 5:
                    graphics.DrawLine(pen, X + 64, Y - 64, X + 192, Y - 64);
                    break;
                case 6:
                    graphics.DrawLine(pen, X + 192, Y - 64, X + 192, Y + 64);
                    break;
                case 7:
                    graphics.DrawLine(pen, X + 192, Y + 64, X + 64, Y + 64);
                    break;
                case 8:
                    graphics.DrawLine(pen, X + 64, Y + 64, X + 64, Y - 64);
                    break;
                case 9:
                    graphics.DrawLine(pen, X, Y, X + 64, Y - 64);
                    break;
                case 10:
                    graphics.DrawLine(pen, X + 128, Y, X + 192, Y - 64);
                    break;
                case 11:
                    graphics.DrawLine(pen, X + 128, Y + 128, X + 192, Y + 64);
                    break;
                case 12:
                    graphics.DrawLine(pen, X, Y + 128, X + 64, Y + 64);
                    break;
                default:
                    timerCube.Enabled = false;
                    cubeTimer = 0;
                    ButtonHandling(true);
                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Cube Template', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
            }

            //αυξάνουμε το cube timer κατά ένα κάθε «επανάληψη»
            cubeTimer++;
        }

        int mailTimer = 1;
        private void timerMail_Tick(object sender, EventArgs e)
        {
            //φτιάχνουμε τα γραφικά
            graphics = panel1.CreateGraphics();
            int X = (panel1.Width / 2) - 10;
            int Y = (panel1.Height / 2) - 10;

            //μετά φτιάχνουμε διαδοχικά το σχέδιο.
            switch (mailTimer)
            {
                case 1:
                    graphics.DrawLine(pen, X, Y, X, Y + 128);
                    break;
                case 2:
                    graphics.DrawLine(pen, X, Y + 128, X + 256, Y + 128);
                    break;
                case 3:
                    graphics.DrawLine(pen, X + 256, Y + 128, X + 256, Y);
                    break;
                case 4:
                    graphics.DrawLine(pen, X + 256, Y, X, Y);
                    break;
                case 5:
                    graphics.DrawLine(pen, X, Y, X + 128, Y + 48);
                    break;
                case 6:
                    graphics.DrawLine(pen, X + 256, Y, X + 128, Y + 48);
                    break;
                default:
                    timerMail.Enabled = false;
                    mailTimer = 0;
                    ButtonHandling(true);
                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Mail Template', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
            }

            //και αυξάνουμε κατά ένα τον μετρητή, ώστε να δώσουμε το εφέ της «επανάληψης»
            mailTimer++;
        }

        int stickManTimer = 1;
        private void timerStickman_Tick(object sender, EventArgs e)
        {
            //φτιάχνουμε τα γραφικά
            graphics = panel1.CreateGraphics();
            int X = (panel1.Width / 2) - 35;
            int Y = (panel1.Height / 2) - 35;

            //μετά φτιάχνουμε διαδοχικά το σχέδιο.
            switch (stickManTimer)
            {
                case 1:
                    graphics.DrawLine(pen, X, Y, X, Y + 128);
                    break;
                case 2:
                    graphics.DrawLine(pen, X, Y, X + 64, Y + 64);
                    break;
                case 3:
                    graphics.DrawLine(pen, X, Y, X - 64, Y + 64);
                    break;
                case 4:
                    graphics.DrawLine(pen, X, Y + 128, X - 64, Y + 192);
                    break;
                case 5:
                    graphics.DrawLine(pen, X, Y + 128, X + 64, Y + 192);
                    break;
                case 6:
                //μετά φτιάχνουμε το κεφάλι, ζωγραφίζοντας έναν κύκλο στην κορυφή του σημείου
                    Rectangle head = new Rectangle(X - 32, Y - 64, 64, 64);
                    graphics.DrawEllipse(pen, head);
                    break;
                default:
                    timerStickman.Enabled = false;
                    stickManTimer = 0;
                    ButtonHandling(true);
                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Stickman Template', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
            }

            //και αυξάνουμε κατά ένα τον μετρητή, ώστε να δώσουμε το εφέ της «επανάληψης»
            stickManTimer++;
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

        private void ManageDatabaseItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem == viewItemsToolStripMenuItem)
            {
                Hide();
                new Form2().Show();
            }
        }

        private void SelectColorToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            //όταν ο χρήστης θέλει να αλλάξει τα χρώματα μέσω του menustrip, τότε απλά πατάμε τα αντίστοιχα κουμπιά
            if (clickedItem == forBackgroundToolStripMenuItem)
                buttonSelectBackgroundColour.PerformClick();
            else
                buttonPenColour.PerformClick();
        }

        private void selectBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogCanvas.ShowDialog() == DialogResult.Cancel)
                return;

            panel1.BackColor = Color.White;
            buttonSelectBackgroundColour.Enabled = false;
            panel1.BackgroundImage = Image.FromFile(openFileDialogCanvas.FileName);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //καθε φορά που ο χρήστης σταματάει να πατάει το ποντίκι, κάνουμε false την canDraw, ώστε να μην συνεχίζει να ζωγραφίζει
            canDraw = false;

            //ύστερα για κάθε σχήμα που δημιουργεί ο χρήστης, βάζουμε και την κατάλληλη πληροφορία στη βάση
            switch (QuickSettingsSelection)
            {
                case 1:
                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Freestyle', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
                case 2:
                    graphics.DrawLine(pen, e.X, e.Y, lineX, lineY);

                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Line Segment', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
                case 3:
                    Rectangle rectEllipse = new Rectangle();
                    rectEllipse.X         = lineX;
                    rectEllipse.Y         = lineY;
                    rectEllipse.Width     = Math.Abs(lineX - e.X);
                    rectEllipse.Height    = Math.Abs(lineY - e.Y);
                    graphics.DrawEllipse(pen, rectEllipse);

                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Ellipse', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
                case 4:
                    Rectangle rectCircle = new Rectangle();
                    rectCircle.X         = rectCircle.Y = lineX;
                    rectCircle.Width     = rectCircle.Height = Math.Abs(lineX - e.X);
                    graphics.DrawEllipse(pen, rectCircle);

                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Circle', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
                case 5:
                    Rectangle rect = new Rectangle();
                    rect.X         = lineX;
                    rect.Y         = lineY;
                    rect.Width     = Math.Abs(lineX - e.X);
                    rect.Height    = Math.Abs(lineY - e.Y);
                    graphics.DrawRectangle(pen, rect);

                    command = new OleDbCommand("INSERT INTO Shapes (Type, Date_Created, Time_Created, Color, Pen_Size) VALUES ('Rectangle', '" + DateTime.Today.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + colorDialog1.Color.ToString() + "', '" + trackBarPenSize.Value.ToString() + "')", connection);
                    command.ExecuteNonQuery();
                    break;
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }

        //το κουμπί της εξόδου (θα ρωτάει και αν θέλει ο χρήστης να φύγει)
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave?", "Quit Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();

            int length = Application.OpenForms.Count;
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Application.OpenForms[i].Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
