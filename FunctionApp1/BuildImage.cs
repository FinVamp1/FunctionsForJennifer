using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    class BuildImage
    {

        public Bitmap FinImageTest(string imgPath)
        {
            Bitmap pg = new Bitmap((int)(8.5 * 72), (int)(11 * 72));
            Graphics gr = Graphics.FromImage(pg);

            // clear the canvas to white
            Rectangle pgRect = new Rectangle(0, 0, pg.Width, pg.Height);
            SolidBrush solidWhite = new SolidBrush(Color.White);
            gr.FillRectangle(solidWhite, pgRect);
            // load a new image and draw it centered on our canvas
            Stream stm = File.Open(imgPath, FileMode.Open);
            Image img = Image.FromStream(stm);
            int w = img.Width * 2;
            int h = img.Height * 2;
            Rectangle rc = new Rectangle((pg.Width - w) / 2, (pg.Height - h) / 2, w, h);
            gr.DrawImage(img, rc);
            // frame the image with a black border
            gr.DrawRectangle(new Pen(Color.Black, 4), rc);
            // add some text at the top left of the canvas
            Font fn = new Font("Comic Sans MS", 72);
            SolidBrush solidBlack = new SolidBrush(Color.Black);
            gr.DrawString("My Picture", fn, solidBlack, (int)(pg.Width * 0.1), (int)(pg.Height * 0.1));
            stm.Dispose();
            return pg;
        }
    }
}
