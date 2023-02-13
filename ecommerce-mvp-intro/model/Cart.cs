using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_oop_ecommerce_basic.model
{
    public class Cart
    {
        //attributes
        private string _id;
        private int currentLenght;
        private new List<Product> prodotti = new List<Product>();

        //properties
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Invalid Id");
            }
        }

        public List<Product> Prodotti
        {
            get
            {
                return prodotti;
            }
            set
            {
                //non lo uso
            }
        }

        //constructors
        public Cart(string id)
        {
            this.Id = id;
            Clear();
        }

        //copy constrcutor for clone
        protected Cart(Cart c) : this(c.Id)
        {
            Id = c.Id;
            currentLenght = c.currentLenght;
            for (int i = 0; i < c.prodotti.Count; i++)
            {
                if (c.prodotti[i] != null)
                {
                    //_prod[i] = c._prod[i].Clone();
                }
            }


        }
        public Cart Clone()
        {
            return new Cart(this);
        }

        //metodi specifici
        public void Clear()
        {
            prodotti = null;
        }
        public void Add(Product p)
        {
            if (p != null)
            {
                prodotti.Add(p);
            }
            else
                throw new Exception("Invalid product");
        }

        public int IndexOf(Product q)
        {
            int index=prodotti.IndexOf(q);
            if (index != -1)
            {
                return index;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public void Modify(Product p)
        {
            int i = IndexOf(p);
            if (i>=0)
            {
                prodotti[i] = p;
            }
            else
                throw new Exception("Product not found");
        }

        public Product Remove(Product p)
        {
            if (IndexOf(p) != -1)
            {
                for (int i = IndexOf(p); i < prodotti.Count - 1; i++)
                    prodotti[i] = prodotti[i + 1];

                prodotti[prodotti.Count - 1] = null;

                return p;
            }
            else
                throw new Exception("Product not found");
        }

    }
}
