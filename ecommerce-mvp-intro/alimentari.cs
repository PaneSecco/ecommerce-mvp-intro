using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class Alimentari : Product
    {
        private int sconto;
        private DateTime prevDate;

        public Alimentari(string id, string name, string prod, string descr, int sconto, DateTime prevDate1) : base(id, name, prod, descr)
        {
            Sconto = sconto;
            PrevDate = prevDate;
        }

        public DateTime PrevDate
        {
            get { return prevDate; }
            set { prevDate = value; }
        }
        public override float sconto_ ()
        {
            bool da_fare;
            var today = DateTime.Now;
            var diffOfDates = today - PrevDate;

            if (diffOfDates.Days > 7 && today.Day % 2 == 0)
            {
                da_fare = true;
            }
            else
            {
                da_fare = false;
            }

            if (da_fare == true)
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
