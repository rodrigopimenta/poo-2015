using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        private static int qtdfiguras = 0;
        Figura[] figuras = new Figura[0];
        private int xini;
        private int yini;
        private int desenhando = 0;

        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        public void AdicionaFigura(Figura f)
        {
            qtdfiguras++;
            Array.Resize(ref figuras, (qtdfiguras));
            figuras[qtdfiguras - 1] = f;
        }

        public void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < this.figuras.Length; i++)
            {
                Figura f = new Figura();
                f = this.figuras[i];
                f.Desenha(g);
            }
        }

        private void DesenhaCliqueInicial(object sender, MouseEventArgs e)
        {
            desenhando = 1;
            xini = e.X;
            yini = e.Y;
        }

        private void DesenhaCliqueFinal(object sender, MouseEventArgs e)
        {
            desenhando = 0;
            if (comboxFerramenta.SelectedIndex == 0)
            {
                AdicionaFigura(new Retangulo(Math.Min(xini, e.X), Math.Min(yini, e.Y), Math.Abs(e.X - xini), Math.Abs(e.Y - yini)));
            }
            else if (comboxFerramenta.SelectedIndex == 1)
            {
                int xx = Math.Abs(e.X - xini);
                int yy = Math.Abs(e.Y - yini);
                int raio = (int)Math.Sqrt(xx * xx + yy * yy);

                AdicionaFigura(new Circulo(xini - raio, yini - raio, raio));
            }
            else if (comboxFerramenta.SelectedIndex == 2)
            {
                AdicionaFigura(new Linha(xini, yini, e.X, e.Y));
            }

            this.Invalidate();
        }

        private void AreaDeDesenho_Load(object sender, EventArgs e)
        {
            comboxFerramenta.Items.Add("Retangulo");
            comboxFerramenta.Items.Add("Circulo");
            comboxFerramenta.Items.Add("Linha");

            comboxFerramenta.SelectedIndex = 0;
        }

        private void DesenhaArrasta(object sender, MouseEventArgs e)
        {
            if (desenhando == 7) //teste..... arrastando
            {
                DesenhaCliqueFinal(sender, e);
            }
        }
    }
}