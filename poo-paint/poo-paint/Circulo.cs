using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Circulo : Figura
    {
        private int praio;
        static int contador;

        public Circulo(int x, int y, int raio)
        {
            pro_x = x;
            pro_y = y;
            praio = raio;

            contador += 1;
        }

        public override string Imprime()
        {
            return "circulo[x:" + pro_x + ",y:" + pro_y + ",raio:" + praio + "]";
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
            g.DrawEllipse(Pens.Black, pro_x, pro_y, praio * 2, praio * 2);
        }
    }
}