using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppColision
{
    public class ball
    {
        public int x { get; set; }
        public int y { get; set; }
        public int vx { get; set; }
        public int vy { get; set; }
        public Color color { get; set; }

        public ball(int x, int y, int vx, int vy, Color color)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.color = color;
        }

        public void update(int maxX, int maxY, int minX, int minY)
        {
            x += vx;
            y += vy;

            if (x + 50 > maxX || x < minX)
            {
                vx *= -1;
            }
            if (y + 50 > maxY || y < minY)
            {
                vy *= -1;
            }

        }

    }

}
