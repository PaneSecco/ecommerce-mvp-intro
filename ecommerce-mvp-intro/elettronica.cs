using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class Elettronica : Product
    {
        private string modello_specifico;
        public Elettronica(string id, string name, string prod, string descr, int sconto, string modello_specifico) : base(id, name, prod, descr)
        {
            Sconto = sconto;
            Modello_specifico = modello_specifico;
        }
        public string Modello_specifico
        {
            get { return modello_specifico; }
            set { modello_specifico = value; }
        }

        public override float sconto_()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            string giorno = Convert.ToString(d);

            if (giorno == "Lunedì")
            {
                float sconto = Price / 100 * Sconto;
                return Price - sconto;
            }
            else
            {
                return this._price;
            }
        }
    }
}
