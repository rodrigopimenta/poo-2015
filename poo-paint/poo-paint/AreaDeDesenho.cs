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
            xini = e.X;
            yini = e.Y;
        }

        private void DesenhaCliqueFinal(object sender, MouseEventArgs e)
        {
            if (comboxFerramenta.SelectedIndex == 0)
            {
                if (e.X > xini)
                {
                    if (e.Y > yini)
                    {
                        AdicionaFigura(new Retangulo(xini, yini, (e.X - xini), (e.Y - yini)));
                    }
                    else
                    {
                        AdicionaFigura(new Retangulo(xini, e.Y, (e.X - xini), (yini - e.Y)));
                    }
                }
                else
                {
                    if (e.Y > yini)
                    {
                        AdicionaFigura(new Retangulo(e.X, yini, (xini - e.X), (e.Y - yini)));
                    }
                    else
                    {
                        AdicionaFigura(new Retangulo(e.X, e.Y, (xini - e.X), (yini - e.Y)));
                    }
                }
            }
            else
            {
                AdicionaFigura(new Circulo(e.X, e.Y, xini - e.X));
            }

            this.Invalidate();
        }

        private void AreaDeDesenho_Load(object sender, EventArgs e)
        {
            comboxFerramenta.Items.Add("Retangulo");
            comboxFerramenta.Items.Add("Circulo");
            comboxFerramenta.SelectedIndex = 0;
        }

    }
}