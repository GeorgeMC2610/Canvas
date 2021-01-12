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
        public Graphics panel { get; set; }

        public Canvas(Graphics panel)
        {
            this.panel = panel;
        }

        public Canvas()
        {
            this.panel = null;
        }

        public void SaveCanvas(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream        = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, this);
            stream.Close();
        }

        public Graphics LoadCanvas(string path)
        {
            Canvas canvas = new Canvas();

            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

                canvas = (Canvas) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show("Error Message: " + e1.Message + "\n\nNo such file found.", "File Not Found",MessageBoxButtons.OK);
            }
            catch (SerializationException)
            {
                //do nothing.
            }

            return canvas.panel;
        }
    }
}
