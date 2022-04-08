using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML2
{
    class MenuCatalog
    {


        Dictionary<int, Pizza> pizzas;


        public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        
        }
        public void CreatePizza(Pizza pizza) {
            pizzas.Add(pizza.ID, pizza);


        }
        public Pizza ReadPizza(int ID)
        {

            return pizzas[ID];

        }
        public Pizza UpdatePizza(Pizza pizza)
        {
            Pizza p = ReadPizza(pizza.ID);
            p.Name = pizza.Name;
            p.Price = pizza.Price;
            return p;

        }
        
        
        public void DeletePizza(Pizza pizza) 
        {

            pizzas.Remove(pizza.ID);

        }
        public void PrintInfo() 
        {
            foreach (var p in pizzas)
            {
                Console.WriteLine($"{p.Value.ID}  : {p.Value.Name} :  {p.Value.Price}");
            }
            
        }
        public Pizza Search(string name)
        {
            return pizzas.FirstOrDefault(a=> a.Value.Name.Contains(name)).Value ;
        }
        



        public int MenuChoice(List<string> menuItems) 
        {

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~_____________________~~~~~~~~~~~~~~");
            Console.WriteLine("                    | Pizza menu options  |             ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~_____________________~~~~~~~~~~~~~~");

            Console.WriteLine("");
            Console.WriteLine("");
            int index = 1;
            foreach (string choice in menuItems)

            {
                Console.WriteLine("");
                Console.WriteLine($"{index} , {choice}");

                index++;
                Console.WriteLine("________________________________|");

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("____________________________________");
            Console.WriteLine("            |Select Menu |         ");
            Console.WriteLine("____________________________________|");
            string selected = Console.ReadLine();
            
            int selectedint =  menuItems.IndexOf(menuItems.Find(a => a.ToUpper().Contains(selected.ToUpper())))+1;

            if(selectedint == 0)
            {
                Console.WriteLine("Menu not found");
            
            }

            return selectedint;



        }



    }
}

     

        
       
        

    







    
