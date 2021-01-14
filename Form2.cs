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
            // TODO: This line of code loads data into the 'shapes._Shapes' table. You can move, or remove it, as needed.
            this.shapesTableAdapter.Fill(this.shapes._Shapes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                form.Close();
        }
    }
}
