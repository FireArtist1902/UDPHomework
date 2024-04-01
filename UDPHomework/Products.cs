using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPHomework
{
    public class Products
    {

        public bool Bread { get; }
        public bool Egg { get; }
        public bool Milk { get; }
        public bool Cheese { get; }
        public bool Sausage { get; }
        public bool Flavour { get; }

        public Products(bool[] products)
        {
            Bread = products[0];
            Egg = products[1];
            Milk = products[2];
            Cheese = products[3];
            Sausage = products[4];
            Flavour = products[5];
        }

        public string GetRecipe()
        {
            if(Egg && !Milk && !Cheese &&  Sausage && !Flavour && !Bread)
            {
                return "Яєчня з ковбасою";
            }
            else if(Egg && Milk && !Cheese && !Sausage && Flavour && !Bread)
            {
                return "Млинці";
            }
            else if(Egg && !Milk && !Cheese && !Sausage && !Flavour && !Bread)
            {
                return "Яєчня";
            }
            else if(!Egg && !Milk && Cheese && Sausage && !Flavour && Bread)
            {
                return "Бутерброд з ковбасою та сиром";
            }
            return "Я не знаю, що можна приготувати";
        }

    }
}
