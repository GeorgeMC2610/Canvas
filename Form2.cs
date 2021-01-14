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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void shapesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shapesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapes);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Shapes' table. You can move, or remove it, as needed.
            this.shapesTableAdapter1.Fill(this.database1DataSet1.Shapes);
            // TODO: This line of code loads data into the 'database1DataSet1.Shapes' table. You can move, or remove it, as needed.
            this.shapesTableAdapter1.Fill(this.database1DataSet1.Shapes);
            // TODO: This line of code loads data into the 'shapes._Shapes' table. You can move, or remove it, as needed.
            this.shapesTableAdapter.Fill(this.shapes._Shapes);

        }

        bool controlledExit = false;
        private void button1_Click(object sender, EventArgs e)
        {
            controlledExit = true;

            new Form1().Show();
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (controlledExit)
                return;

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
