using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace csharp_oop_ecommerce_basic.model
{
    public abstract class Product
    {   
        //ATTRIBUTES
        private string _id, _name, _manufacturer, _description;
        protected float _price;
        private int sconto;

        //SET AND GET MEDIANTE PROPERTIES

        public int Sconto
        {
            get { return sconto; }
            set {
                if (value > 0 && value < 100)
                    sconto = value;
                else
                    throw new Exception("sconto must be between 0 and 100");
            }
        }
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Price must be >0");
            }
        }

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
                    throw new Exception("Invalid ID");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value != null)
                    _name = value;
                else
                    throw new Exception("Invalid name");
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            private set
            {
                if (value != null)
                    _manufacturer = value;
                else
                    throw new Exception("Invalid manifacturer");
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                if (value != null)
                    _description = value;
                else
                    throw new Exception("Invalid description");
            }
        }

        //CONSTRUCTORS

        public Product(string id, string name, string prod, string descr, float price, int sconto)
        {
            if(String.IsNullOrEmpty(id) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(prod) || price<=0)
            {
                throw new Exception("invalid product parameters ");
            }
            Id = id;
            Name = name;
            Manufacturer = prod;
            Description = descr;
            Price = price;
        }

        public Product(string id, string name, string prod, string descr) : this(id, name, prod, descr, 10, 9)
        {
        }

        public Product(string id, string name, string prod) : this(id, name, prod, "N/A", 10, 9)
        {
        }

        public Product() : this("IDVUOTO", "N/A", "N/A", "N/A", 10, 9)
        {
        }

        public Product(string id, string name, string prod, float price) : this(id, name, prod, "N/A", price, 9)
        {

        }

        public Product(string id) : this(id, "N/A", "N/A", "N/A", 1, 9)
        {

        }

        //copy constructor for clone
        protected Product(Product other) : this(other.Id, other.Name, other.Manufacturer, other.Description, other.Price, 9)
        {
        }

        /*
        protected Product Clone()
        {
            return new Product(this);   
        }
        */

        //Equals

        public bool Equals(Product p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }

        //ToString
        public override string ToString()
        {
            return "Product:" +Id + ";" + Name + ";" + Manufacturer+";"+Description + ";" + Price;
        }

        public virtual float sconto_()
        {
            return -1;
        }
    }
}
