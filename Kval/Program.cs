using System;
using System.Collections.Generic;
using System.Linq;
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
            Flower fl = new Flower("Ромашка", "Цветок, с белыми лепестакми и желтым кружком в середине");
            Flower fl2 = new Flower("Одуванчик", "Цветок, который сначала желтый, а потом превращается в пушистый белый комок, на который можно подуть и с него слетят пушинки");
            Flower fl3 = new Flower("Тюльпан", "Цветок, который чаще всего дарят на 8 марта");

            Garden gar = new Garden("улица Мира, дом 3", "Аня", "Одуванчик");
            Garden gar2 = new Garden("улица Иванова, дом 5", "Оля", "Ромашка");
            Garden gar3 = new Garden("улица Ленина, до 54", "Вика", "Тюльпан");
            
            fl.Show();
            fl2.Show();
            fl3.Show();

            gar.ShowAll();
            gar2.ShowAll();
            gar3.ShowAll();
            
            
            
            Console.ReadKey();
        }
        //Мартынов В.В.
    }
}
