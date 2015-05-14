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

        public void AdicionarFigura(Figura f)
        {


        }
    }
}
