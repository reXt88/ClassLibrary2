using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    //Мартынов В.В.
    public class Garden
    {
        public string Address { get; set; }

        public string Owner{ get; set; }

        public string Flowers{ get; set; }
        public List<Flower> Lib = new List<Flower>();

        public Garden(string add, string owner, string flowers)
        {
            Address = add;
            Owner = owner;
            Flowers = flowers;
        }

        public void ShowAll()
        {
            Console.WriteLine("Сад:\n" + $"Адрес: {Address}\n" + $"Владелец: {Owner}\n" + $"Цветок: {Flowers}\n");
            
        }
    }
    //Мартынов В.В.
    public class Flower : IComparable
    {
        public string Title { get; set; }

        public string Description { get; set; }
        public Flower(string t, string d)
        {
            Title = t;
            Description = d;
        }
        public void Show()
        {
            Console.WriteLine("Цветок:\n" + $"Название: {Title}\n" + $"Описание: {Description}");
        }
        public int CompareTo(object obj)
        {
            return (this.Description + this.Title).CompareTo(Description + Title);
        }
        //Мартынов В.В.
    }
}
