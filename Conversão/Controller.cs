using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TauanMaciel
{
    public class Controller
    {
        Iview view1;
        Iview view2;
        private Model model;

        public Controller(Iview view1, Model model)
        {
            this.view1 = view1;
            this.model = model;
            this.view1.SetController(this);
        }

        internal void AbrirForms()
        {
            view2 = new Form2();
            view2.SetController(this);
            if (view2 is Form form2)
            {
                form2.ShowDialog();
                view1.Valor = view2.Valor;
            }
        }

        public void Converter()
        {
            double valor = view1.Valor;
            double polegada = model.Polegada(valor);
            double pe = model.Pe(valor);
            double milha = model.Milha(valor);
            double galao = model.Galao(valor);
            double libra = model.Libra(valor);
            double cm = model.Cm(valor);
            double metro = model.Metro(valor);
            double quilometro = model.Quilometro(valor);
            double litro = model.Litro(valor);
            double.
        }
    }
}
