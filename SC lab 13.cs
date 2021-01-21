using System;

namespace AIlabASsignment1
{
    class Program
    { public static double price ;
        public static int i;
        public static string name;
        public static string address;
        public static string contact;
        public static string[] store = new string[100];
       
        static void Main(string[] args)
        {
          
            void menu() 
            {
                Console.WriteLine("  Items\t\t\t\t\tPrices");
                Console.WriteLine("1. Biryani----------------------------Rs.100\n2. Fried Rice-------------------------Rs.120\n3. Pizza------------------------------Rs.300\n4. Nehari-----------------------------Rs.200\n5. Naan-------------------------------Rs.10 ");
             int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                price = price + 100;
                    store[i] = "Biryani----------------------------Rs.100";
                    i++;
            }
            else if (select == 2)
            {
                price = price + 120;
                    store[i] = "Fried Rice-------------------------Rs.120";
                    i++;
                }
            else if (select == 3)
            {
                price = price + 300;
                    store[i] = "Pizza------------------------------Rs.300";
                    i++;
                }
            else if (select == 4)
            {
                price = price + 200;
                    store[i] = "Nehari-----------------------------Rs.200";
                    i++;
                }
            else if (select == 5)
            {
                price = price + 10;
                    store[i] = "Naan----------------------------Rs.10";
                    i++;
                }
                options();
            }
            void Discount_deals() 
            {

                Console.WriteLine("  Items\t\t\t\t\tPrices");
                Console.WriteLine("1. KFC(25%)---------------------------Rs.450\n2. Zinger(50%)------------------------Rs.200\n3. Roll Pratah(20%)-------------------Rs.150");
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    
                    price = price + ((450)-(0.25*450));
                    store[i] = "KFC---------------------------" + ((450) - (0.25 * 450));
                    i++;
                }
                else if (select == 2)
                {
                    price = price + (200-(0.50*200));
                    store[i] = "Zinger-------------------------" + (200 - (0.50 * 200));
                    i++;
                }
                else if (select == 3)
                {
                    price = price + (150-(150*0.20));
                    store[i] = "Roll Pratah---------------------" + (150 - (150 * 0.20));
                    i++;
                }
               
            }
            void options()
            {
                Console.WriteLine("Please select any of the one from Following :\n1). Topping addition in order\n2). Reordering\n3). Discounter Deals\n4). Invoie Printing ");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    menu();
                }
                else if (choose == 2)
                {
                    price = 0;
                    i = 0;
                    Array.Clear(store, 0, store.Length);
                    menu();
                }
                else if (choose == 3)
                {
                    Discount_deals();
                    options();
                }
                else if (choose == 4)
                {
                    Console.WriteLine("**********************BILL*********************");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("Address : " + address);
                    Console.WriteLine("Contact : " + contact);
                    for (int k = 0; k < i; k++)
                    {
                        Console.WriteLine("{0}.) {1}", k + 1, store[k]);
                    }
                    Console.Write("Total amount to pay : " + price);
                    Console.WriteLine("\n***********************************************");
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
            for (int j = 0; j <= 2; j++)
            {

                Console.WriteLine("your Name please : ");
                name =  Console.ReadLine();
                Console.WriteLine("Your address please : ");
                address = Console.ReadLine();
                Console.WriteLine("Your contact please ");
                contact = Console.ReadLine();
                Console.WriteLine("\n\t\t\t************* Menu ************* ");
           
          options();
            }
            }
          
        }
    }

