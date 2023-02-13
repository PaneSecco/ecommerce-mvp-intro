using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class Penne : Cancelleria 
    {
        private int grammatura;
        public Penne(string id, string name, string prod, string descr, int sconto, int grammatura) : base(id, name, prod, descr, sconto)
        {
            Grammatura = grammatura;
        }

        public int Grammatura { 
            get { return grammatura; } 
            set { 
                if (value > 0)
                {
                    grammatura = value;
                }
                else
                {
                    throw new Exception("grammatura must be >0");
                }

            } 
        }
    }
}
