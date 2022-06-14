using System;

namespace _14_iyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
            {
                 new Human (30, "Humay", "Seferova"),
                 new Human (23, "Gulay", "Asgarova"),
                 new Human (18, "Vali", "Sxyeva")
                
            };
            humans[0].Name = "lala";
            Console.WriteLine("Deyeri daxil edin");

            //string input = Console.ReadLine();
            //for (int i = 0; i < humans.Length; i++)
            //{
            //    if (humans[i].Name.Contains(input))
            //    {
            //        Console.WriteLine(humans[i].Name);
            //    }
             
            //}
            Console.WriteLine("milklerin sayini daxil edin");
            string input = Console.ReadLine();
            int change = int.Parse(input);
            Milk[] milks = new Milk[change];





            for (int i = 0; i < milks.Length; i++)
            {
                Console.WriteLine("Milkin adini yaz");
                string name = Console.ReadLine();
                Console.WriteLine("Milkin qiymetini daxil edin");
                string pricee = Console.ReadLine();
                double price = Convert.ToDouble(pricee);
                Console.WriteLine("Milkin yagliliq faizini yazin");
                double fatPercent = double.Parse(Console.ReadLine());
     
                milks[i].Name = name;
                milks[i].Price = price;
                milks[i].FatPercent = fatPercent;
                


            
                
            };








        }
    }
}
