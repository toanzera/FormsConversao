using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauanMaciel
{
    public interface Iview
    {
        void SetController(Controller controller);

        double Valor {  get; set; }
    }
}
