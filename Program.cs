using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
     class Programs
     {
         static void Main(string[] args)
         {
             List<Item> itemList = new List<Item>(); //Занесение в список переменных из Client.txt
             using (StreamReader sr = File.OpenText(@"C:\Users\vital\OneDrive\Desktop\Я\Практические работы и  не только\ОАиП\Individual_17\client.txt"))
             {
                 while (!sr.EndOfStream)
                 {
                     itemList.Add(new Item(sr.ReadLine()));
                 }
             }

             List<Uslugi> itemList1 = new List<Uslugi>(); //Занесение в список переменных из Uslugi.txt
             using (StreamReader sr = File.OpenText(@"C:\Users\vital\OneDrive\Desktop\Я\Практические работы и  не только\ОАиП\Individual_17\uslugi.txt"))
             {
                 while (!sr.EndOfStream)
                 {
                     itemList1.Add(new Uslugi(sr.ReadLine()));
                 }
             }

             List<Ispol> itemList3 = new List<Ispol>(); //Занесение в список переменных из Ispol.txt
            using (StreamReader sr = File.OpenText(@"C:\Users\vital\OneDrive\Desktop\Я\Практические работы и  не только\ОАиП\Individual_17\ispol.txt"))
            {
                while (!sr.EndOfStream)
                {
                    itemList3.Add(new Ispol(sr.ReadLine()));
                }
            }

             DateTime datesrok = new DateTime(2022, 4, 30);
            foreach (Item item in itemList)            //Вывод дат довлетвор. уловию
             {
                 if (Convert.ToDateTime(item.DateEnd) <= datesrok)
                 {
                     Console.WriteLine(item.DateEnd);
                     Console.WriteLine(item.numberd);
                     Console.WriteLine();
                 }
             }

            Console.ReadKey();
         }
     }
}