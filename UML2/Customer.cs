using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
   public class Customer
   {  
        // Instance fields
        private int customersId;
        private string customersName;
        private int teleFonNomber;
        
        //Constructor
        public Customer(int id, string name, int teleFonNomber) 
        {
            this.customersId = id;
            this.customersName = name;
            this.teleFonNomber = teleFonNomber;     
        }
        
        //Properties
        public int Id
        {
            get { return this.customersId; }
            set { this.customersId = value; }
        } 
        public string Name
        {
            get {  return this.customersName; }
            set { this.customersName = value; }

        }

        public int TelefonNomber
        {
            get { return this.teleFonNomber; }
            set { this.teleFonNomber = value; }
        }
        public override string ToString() {
            return "[Customer ID ]: " + this.customersId +  " [Customer Name] :" + this.customersId + " [ Telefon No] :" + teleFonNomber; 
        }
        
        
    }
}
