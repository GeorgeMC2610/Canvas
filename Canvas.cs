using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
        public Graphics graphics { get; set; }
        public Panel panel { get; set; }

        public Canvas(Panel panel, Graphics graphics)
        {
            this.panel    = panel;
            this.graphics = graphics;
        }

        public Canvas()
        {
            this.panel = null;
        }

        public void SaveCanvas(string path)
        {
            Bitmap picture = new Bitmap(panel.Width, panel.Height, graphics);
            panel.DrawToBitmap(picture, new Rectangle(0, 0, panel.Width, panel.Height));
            picture.Save(path, ImageFormat.Bmp);
            picture.Dispose();
        }

        //public Graphics LoadCanvas(string path)
        //{
        //    
        //}
    }
}
