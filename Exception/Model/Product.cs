using System;
namespace Exception.Model
{
	public class Product
	{
        private int _productId;
        private string _name;
        private float _price;
        private int _stock;

        //Readonly properties to access the field values outside of the class
        public int ProductId
        {
            get { return _productId; }
        }

        public string Name
        {
            get { return _name; }
        }

        public float Price //Read-Write property to access and/or modify the field values outside of the class
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new System.Exception("Price cannot be negative");
                _price = value;
            } //allows the Price to be modified outside the class
        }
        public int Stock
        {
            get { return _stock; }
            //TODO: define a set accessor for stock, ensuring stock is never negative
        }

        public virtual float NetPrice //A computed property, does not wrap a field directly
        {
            get
            {
                float tax = _price * .13F;
                return _price + tax;
            }
        }

        //TODO: create a computed property to calculate the total stock value
        public Product(int productId, string name, float price, int stock)
        {
            _productId = productId;
            _name = name;
            Price = price; //will call the property setter and hence enforce validation checks
            _stock = stock;
        }

        public override string ToString()
        {
            return $"{ProductId},{Name},{Stock},{Price}";
            
		
		}

        public int ReduceStock(int unitsToReduce)
        {
            if (unitsToReduce <= 0)
                throw new System.Exception("Units to Reduce can not be negative.");
            if (unitsToReduce > Stock)
                throw new System.Exception("Not enough stock");
            _stock -= unitsToReduce;
            return _stock;
        }
	}
}

