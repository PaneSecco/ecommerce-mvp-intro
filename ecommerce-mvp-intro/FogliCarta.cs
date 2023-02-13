using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class FogliCarta : Cancelleria
    {
        private string funzionamento;
        public FogliCarta(string id, string name, string prod, string descr, int sconto, string funzionamento) : base(id, name, prod, descr, sconto)
        {
            Funzionamento = funzionamento;
        }

        public string Funzionamento
        {
            get { return funzionamento; }
            set { funzionamento = value; }
        }
    }
}
