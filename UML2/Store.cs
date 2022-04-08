using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    public class Store
    {
        public void Start() {

            Test();

            




        }
        public void Test() {


            CustomerList cL = new CustomerList();
            Customer c1 = new Customer(14, "Oliver ", 54863325);
            Customer c2 = new Customer(19, "Thomas ", 21971321);
            Customer c3 = new Customer(31, "Lars ", 31115625);
         
            
            cL.CreateCustomer(c1);
            cL.CreateCustomer(c2);
            cL.CreateCustomer(c3);
            

            MenuCatalog menu = new MenuCatalog();

            Pizza p1 = new Pizza(1, "Hawai", 55);
            Pizza p2 = new Pizza(2, "ROMANA", 78);
            Pizza p3 = new Pizza(3, "MARGHERITA", 69);
            Pizza p4 = new Pizza(3, "VESUVIO", 75);
            Pizza p5 = new Pizza(4, "ITALIANA", 75);

            menu.CreatePizza(p1);
            menu.CreatePizza(p2);
            menu.CreatePizza(p3);
            menu.CreatePizza(p5);


            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("                | Create a new Pizza |     ");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine($"   - {p1} ");
            Console.WriteLine($"   - {p2} ");
            Console.WriteLine($"   - {p3} ");
            Console.WriteLine($"   - {p5} ");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("");
            Console.Write("");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("               |READ A PIZZA |              ");
            Console.WriteLine("____________________________________________________________________");
            Console.Write("");
            Console.WriteLine($"    - {menu.ReadPizza(1)}  ");
            Console.WriteLine($"    - {menu.ReadPizza(2)}  ");
            Console.WriteLine($"    - {menu.ReadPizza(3)}  ");
            Console.WriteLine($"    - {menu.ReadPizza(4)}  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            menu.UpdatePizza(p4);
            Console.WriteLine("_______________________________________________________________________ ");
            Console.WriteLine("                |UPDATE A PIZZA|");
            Console.WriteLine("_______________________________________________________________________ ");
            Console.WriteLine($"    - {menu.ReadPizza(3)}  ");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("_______________________________________________________________________ ");
            Console.WriteLine("                |Delete a pizza|  ");
            Console.WriteLine("_______________________________________________________________________ ");
            menu.DeletePizza(p2);
            try
            {
                Console.WriteLine(menu.ReadPizza(2));
            }
            catch
            {
                Console.WriteLine("    - Pizza NOT found");

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("                  | Print info |   ");
            Console.WriteLine("_______________________________________________________________________");
            
            menu.PrintInfo();



            List<string> menulist = new List<string>();
            menulist.Add("     - Creat a new pizza");
            menulist.Add("     - Search for a pizza");
            menulist.Add("     - Update a pizza");
            menulist.Add("     - Delete a pizza");
            menulist.Add("     - Display pizza menu");
            menulist.Add("     - Exit");
            Console.WriteLine("______________________________________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("");
            int menuChoic = menu.MenuChoice(menulist);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine($"     |{menuChoic}|          ");
            Console.WriteLine("___________________________________________________________________________");



            Pizza searched = menu.Search("VESUVIO");
            Pizza searched1 = menu.Search("ITALIANA");
            Pizza updated1 = menu.UpdatePizza(p1);
            

            
         

            Console.WriteLine($"Selected pizza  =   : ID:    {searched.ID} : NAME : {searched.Name}: PRICE : {searched.Price} . kr");
            
            Console.WriteLine($"Selected pizza  =   : ID :  {searched1.ID} : Name: {searched1.Name} : PRICE : {searched1.Price} . kr");

            Console.WriteLine($"Updated pizza   =   : ID :   {updated1.ID} : Name: {updated1.Name}  : Price : {updated1.Price} . kr ");

            Console.WriteLine("");
            Console.WriteLine("");

            Customer searchedCustomer = cL.Search("Oliver");
            Customer searchedCustomer1 = cL.Search("Thomas");
            Customer searchedCustomer2 = cL.Search("Lars");
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("                 |Selected customer|     ");
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine($"Selected customer  =  : Customer ID :  { searchedCustomer.Id} :  Customer name: {searchedCustomer.Name} : Customer TLf no :{searchedCustomer.TelefonNomber}");
            Console.WriteLine($"Selected customer  =  : Customer ID :  { searchedCustomer1.Id} :  Customer name: {searchedCustomer1.Name} : Customer TLf no :{searchedCustomer1.TelefonNomber}");
            Console.WriteLine($"Selected customer  =  : Customer ID :  { searchedCustomer2.Id} :  Customer name: {searchedCustomer2.Name} : Customer TLf no :{searchedCustomer2.TelefonNomber}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            
            Console.ReadLine();
            

            
            
            

        }
       
    }
}
