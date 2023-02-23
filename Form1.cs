using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsAppColision
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private List<ball> balls;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Boolean down;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;

            // Inicializar la lista de bolas
            balls = new List<ball>();

            // Crear 50 bolas con diferentes propiedades aleatorias
            Random random = new Random();

           

            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(pictureBox1.Width - 50);
                int y = random.Next(pictureBox1.Height - 50);
                int dx = random.Next(-10, 10);
                int dy = random.Next(-10, 10);
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                balls.Add(new ball(x, y, dx, dy, color));
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            graphics.Clear(Color.Black);

            // Actualizar y dibujar cada bola
            foreach (ball ball in balls)
            {
                SolidBrush brush = new SolidBrush(ball.color);
                graphics.FillEllipse(brush, ball.x, ball.y, 50, 50);
                ball.update(pictureBox1.Width - 50, pictureBox1.Height - 50, 0, 0);
            }

            pictureBox1.Invalidate();
            
        }
    
    }
}
