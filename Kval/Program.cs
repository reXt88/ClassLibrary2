using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Kval
{
    internal class Program
    {
        //Мартынов В.В.
        static void Main(string[] args)
        {
            Garden gar = new Garden("улица Мира, дом 3", "Аня", "Одуванчик");

            gar.fl.Add(new Flowers("Ромашка", "Цветок, с белыми лепестакми и желтым кружком в середине"));
            gar.fl.Add(new Flowers("Одуванчик", "Цветок, который сначала желтый, а потом превращается в пушистый белый комок, на который можно подуть и с него слетят пушинки"));
            gar.fl.Add(new Flowers("Тюльпан", "Цветок, который чаще всего дарят на 8 марта"));

            gar.ShowAll();
  
            
            
            Console.ReadKey();
        }
        //Мартынов В.В.
    }
}
