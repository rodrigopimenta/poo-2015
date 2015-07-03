using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Figura
    {
        protected int pro_x;
        protected int pro_y;

        public virtual string Imprime()
        {
            return "figura[x:" + pro_x + ",y:" + pro_y + "]";
        }

        public virtual string GeraLinhaArquivo()
        {
            return "Figura(x, y, l, a)";
        }

        public virtual void Desenha(Graphics g)
        {
        }
    }
}
