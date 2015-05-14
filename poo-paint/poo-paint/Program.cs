using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    class Program
    {
        public static void Main(String[] args)
        {
            AreaDeDesenho area = new AreaDeDesenho();
            area.AdicionaFigura(new Retangulo(3, 4, 20, 50));
            area.AdicionaFigura(new Circulo(150, 45, 20));
            Application.Run(area);
        }
    }
}
