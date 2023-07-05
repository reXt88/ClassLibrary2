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

        public List<Flowers> fl = new List<Flowers>();

        public Garden(string add, string owner, string flowers)
        {
            Address = add;
            Owner = owner;
        }

        public void ShowAll()
        {
            Console.WriteLine("Сад:\n" + $"Адрес: {Address}\n" + $"Владелец: {Owner}\nЦветы:");
            fl.Sort();
            foreach (Flowers f in fl )
            {
                f.Show();
            }
        }
    }
    //Мартынов В.В.
    public class Flowers : IComparable
    {
        public string Title { get; set; }

        public string Description { get; set; }
        public Flowers(string t, string d)
        {
            Title = t;
            Description = d;
        }
        public void Show()
        {
            Console.WriteLine($"Название: {Title}\n" + $"Описание: {Description}");
        }
        public int CompareTo(object obj)
        {
            return (this.Description + this.Title).CompareTo(Description + Title);
        }
        //Мартынов В.В.
    }
}
