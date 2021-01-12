using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_2
{
    [Serializable]
    class Canvas
    {
        public Panel panel { get; set; }

        public Canvas(Panel panel)
        {
            this.panel    = panel;
        }

        public void SaveCanvas(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, this);
            stream.Close();
        }

        public Panel LoadCanvas(string path)
        {
            try
            {
                Panel panel;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

                panel = (Panel) formatter.Deserialize(stream);
                stream.Close();

                return panel;
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show("Error Message: " + e1.Message + "\n\nNo such file found.", "File Not Found",MessageBoxButtons.OK);
                return new Panel();
            }
            catch (SerializationException)
            {
                //do nothing.
                return new Panel();
            }
        }
    }
}
