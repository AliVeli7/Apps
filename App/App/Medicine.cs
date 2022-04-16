using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Medicine
    {
        public static int _id=1;
        public  int Id { get; }
        public string Name;
        public double Price;
        public int Count;
        public bool IsDeleted;


        public Medicine(string name, double price,int count,bool isDeleted=false)
        {
            Id=_id++;
            Name = name;
            Price = price;
            Count = count;
            IsDeleted = isDeleted;
        }


        public void Sell()
        {
            Count--;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Price: {Price} Count: {Count} IsDeleted: {IsDeleted}");
        }

    }
}
