using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Linha : Figura
    {
        private int priv_larg;
        private int priv_altu;
        static int contador;

        public Linha(int x, int y, int largura, int altura)
        {
            pro_x = x;
            pro_y = y;
            priv_larg = largura;
            priv_altu = altura;

            contador += 1;
        }

        public override string Imprime()
        {
            return "linha[x:" + pro_x + ",y:" + pro_y + ",l:" + priv_larg + ",a:" + priv_altu + "]";
        }

        public static void ZeraContador()
        {
            contador = 0;
        }

        public static int LeContador()
        {
            return contador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawLine(Pens.Black, pro_x, pro_y, priv_larg, priv_altu);
        }
    }
}