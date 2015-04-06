using Roluan.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roluan.Emulator
{
    public partial class Screen : Form
    {

        private List<Trit> TritMap { get; set; }
        private Resolution CurrentResolution { get; set; }
        private ColorScheme CurrentColorScheme { get; set; }
        public Screen(List<Trit> TritMap, Resolution CurrentResolution, ColorScheme CurrentColorScheme)
        {

            this.TritMap = TritMap;
            this.CurrentResolution = CurrentResolution;
            this.CurrentColorScheme = CurrentColorScheme;

            InitializeComponent();
            panelScrn.Paint += new PaintEventHandler(panelScrn_Paint);



        }

        void panelScrn_Paint(object sender, PaintEventArgs e)
        {

            int i = 1;
            int j = 1;
            int n = 0;
            int m = 0;
            int multiplier = 1;

            foreach (var trit in TritMap)
            {
                var color = Color.Black;
                if (trit.State == Common.Enums.TritState.Positive)
                {
                    color = Color.White;
                }

                e.Graphics.DrawRectangle(new Pen(color, multiplier), i * multiplier, j * multiplier, multiplier, multiplier);

                if (i == (n + 1) * 9)
                {
                    j++;
                    i = n * 9;
                }

                if (j == (m + 1) * 9 + 1)
                {
                    n += 1;
                    j = m * 9 + 1;
                    i = n * 9 + 1;
                }
                else
                {
                    i++;
                }

                if (n >= (CurrentResolution.Width / 9))
                {
                    m += 1;
                    n = 0;
                    i = 1;
                    j = m * 9 + 1;
                }

            }

        }


        private void Screen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }


        //public void drawPoint(int x, int y)
        //{
        //    Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
        //    SolidBrush brush = new SolidBrush(Color.White);
        //    Point dPoint = new Point(x, y);
        //    dPoint.X = dPoint.X - 2;
        //    dPoint.Y = dPoint.Y - 2;
        //    Rectangle rect = new Rectangle(dPoint, new Size(4, 4));
        //    g.FillRectangle(brush, rect);
        //    g.Dispose();
        //    pictureBox1.RectangleToScreen(rect);
        //}
    }
}
