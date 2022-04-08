using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class Pizza
    {   //Instance feilds
        private int _iD;
        private  string _name;
        private double _price;

        //Constructor
        public Pizza(int iD, string name, double price) {
            _iD = iD;
            _name = name;
            _price = price;

        }
        // Properties
        
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public override string ToString() {
            return "Pizza No" + _iD + "  ( pizza name ) : " + _name +  " ( Pizza Price)  : " + _price + " kr.";
        }

      

    }
}
