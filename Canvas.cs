using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    //[Serializable]
    class Canvas
    {
        public Graphics graphics { get; set; }
        public Panel panel { get; set; }

        public Canvas(Panel panel, Graphics graphics)
        {
            this.panel    = panel;
            this.graphics = graphics;
        }

        public void SaveCanvas(string path)
        {
            /*Bitmap picture = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(picture, new Rectangle(0, 0, panel.Width, panel.Height));

            picture.Save(stream, ImageFormat.Bmp);
            picture.Dispose();*/

            Image image = Image.FromFile(path);
            graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, panel.Width, panel.Height), 0, 0, panel.Width, panel.Height, GraphicsUnit.Pixel);
            image.Save(path);
            image.Dispose();
        }

        public void SaveCanvas(string path, string aaaaa)
        {

        }

        //public Graphics LoadCanvas(string path)
        //{
        //    
        //}
    }
}
