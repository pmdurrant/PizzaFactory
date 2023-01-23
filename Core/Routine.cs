using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Core
{
    public class Routine
    {
      public  Topping GetRandomTopping()
        {

            Array values = Enum.GetValues(typeof(Topping));
            Random random = new Random();
            var toppingEnumMemberCount = Enum.GetNames(typeof(Topping)).Length;


            Topping randomtopping = (Topping)values.GetValue(random.Next(toppingEnumMemberCount));


            return randomtopping;
        }
    }
}
