using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Lab_13
{
    class data//Immutable class
    {
        private readonly string Name;//Immutable variable
        private readonly string address;//Immutable variable
        private readonly string contact;//Immutable variable
        public data(string name, string Address, string Contact)
        {
            Name = name;
            address = Address;
            contact = Contact;
        }
        public string getname()
        {
            return Name;
        }
        public string getaddress()
        {
            return address;
        }
        public string getcontact()
        {
            return contact;
        }
    }

    class Program
    {
        public static double price;
        public static int i = 0 ;
        public static string[] store = new string[100];
        public static string Name;
        public static string address;
        public static string contact;

              
        //public static string Name { get => name; set => name = value; }
        static void Main(string[] args)
        {

           void menu()
            {
                StringBuilder FR = new StringBuilder();//Mutable variable initializing
                StringBuilder CM = new StringBuilder();//Mutable variable initializing
                StringBuilder CAM = new StringBuilder();//Mutable variable initializing
                StringBuilder AM = new StringBuilder();//Mutable variable initializing
                StringBuilder TC = new StringBuilder();//Mutable variable initializing
                Console.WriteLine("  Items\t\t\t\t\t  Prices");
                Console.WriteLine("1. FRAPPUCCINO-------------------------------{0}\n2. CARAMEL MACCHIATO-------------------------{1}\n3. CAFÉ MOCHA--------------------------------{2}\n4. AMERICANO---------------------------------{3}\n5. TURKISH COFFEE----------------------------{4} "
                    ,FR.Append("Rs.100"),CM.Append("Rs.120"),CAM.Append("RS.300"),AM.Append("Rs.200"),TC.Append("Rs.150"));//Applying mutable vaiables
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    price = price + 100;
                    store[i] = "FRAPPUCCINO----------------------------Rs.100";
                    i++;
                   
                }
                else if (select == 2)
                {
                    price = price + 120;
                    store[i] = "CARAMEL MACCHIATO-------------------------Rs.120";
                    i++;
                   
                }
                else if (select == 3)
                {
                    price = price + 300;
                    store[i] = "CAFÉ MOCHA------------------------------Rs.300";
                    i++;
                    
                }
                else if (select == 4)
                {
                    price = price + 200;
                    store[i] = "AMERICANO-----------------------------Rs.200";
                    i++;
                }
                else if (select == 5)
                {
                    price = price + 150;
                    store[i] = "TURKISH COFFEE----------------------------Rs.150";
                    i++;
                }
                options();
            }
            void sortStrings(String[] store, int n)
            {
                String temp;
                

                // Sorting strings using bubble sort 
                for (int j = 0; j < i - 1; j++)
                {
                    for (int l = j + 1; l < i; l++)
                    {
                        if (store[j].CompareTo(store[l]) > 0)
                        {
                            temp = store[j];
                            store[j] = store[l];
                            store[l] = temp;
                        }
                    }
                }
            }

            void Discount_deals()
            {

                Console.WriteLine("  Items\t\t\t\t\tPrices");
                Console.WriteLine("1. CAFE CUBANO(25%)---------------------------Rs.450\n2. IRISH COFFEE(50%)--------------------------Rs.200\n3. CAFÉ LATTE(20%)----------------------------Rs.150");
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {

                    price = price + ((450) - (0.25 * 450));
                    store[i] = "CAFE CUBANO---------------------------" + ((450) - (0.25 * 450));
                    i++;
                }
                else if (select == 2)
                {
                    price = price + (200 - (0.50 * 200));
                    store[i] = "IRISH COFFEE---------------------------" + (200 - (0.50 * 200));
                    i++;
                }
                else if (select == 3)
                {
                    price = price + (150 - (150 * 0.20));
                    store[i] = "CAFÉ LATTE------------------------------" + (150 - (150 * 0.20));
                    i++;
                }

            }
            void options()
            {
                data mydata = new data(Name, address, contact);
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
                    
                    Console.WriteLine("Name : " +  mydata.getname());
                    Console.WriteLine("Address : " + mydata.getaddress());
                    Console.WriteLine("Contact : " + mydata.getcontact());
                    int n = store.Length;
                    sortStrings(store,n);
                    for (int k = 0; k < i; k++)
                    {
                        Console.WriteLine("{0}.) {1}", k + 1, store[k]);
                    }
                    Console.Write("Total amount to pay : " + price);
                    StringBuilder TIME = new StringBuilder();//mutable variable initializing
                    Console.WriteLine(TIME.Append("\nDate Time of placing order : " + DateTime.Now.ToString()));//Applying mutable variable
                    Console.WriteLine("\n***********************************************");
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
                //Environment.Exit(0);
            }
            
            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine("your Name please : ");
                Name = Console.ReadLine();
                Console.WriteLine("Your address please : ");
                address = Console.ReadLine();
                Console.WriteLine("Your contact please ");
                contact = Console.ReadLine();
                Console.WriteLine("\n\t\t\t************* Please select one of them from below ************* ");
                options();
            }
        }

        
    }
}


