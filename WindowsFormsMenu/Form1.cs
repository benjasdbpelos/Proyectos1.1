using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonCua_Click(object sender, EventArgs e)
        {
            Graphics cuadrado;
            cuadrado = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            cuadrado.DrawRectangle(lapiz, 10, 10, 10, 10); //pixeles 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics rectangulo;
            rectangulo = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            rectangulo.DrawRectangle(lapiz, 25, 10, 25, 10); // pixeles
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics circulo;
            circulo = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            circulo.DrawEllipse(lapiz, 50,50,50,50); // pixeles 
        }

        private void Line_Click(object sender, EventArgs e)
        {
            Graphics linea;
            linea = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Point[] Puntos =
            {
            new Point(10,  10),
                 new Point(10, 100),
                 new Point(200,  50),
                 new Point(250, 300)
            };
            linea.DrawLines(lapiz,Puntos); // pixeles 
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //falta
        }

        private void Aceptarop_Click(object sender, EventArgs e)
        {
            //falta colores
        }
    }
}
