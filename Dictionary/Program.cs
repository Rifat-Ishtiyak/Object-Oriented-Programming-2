using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(1, "one");
            d1.Add(2, "two");
            d1.Add(3, "three");

            Console.WriteLine("Total elements : "+d1.Count);
            foreach(var data in d1)
            {
                Console.WriteLine(data.Key+" "+data.Value);
            }
            Console.WriteLine("");

            var city = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham" },
                {"USA","Chicago, New York, Washington" },
                {"Bangladesh","Dhaka, Thakurgaon, Dinajpur"}
            };
            Console.WriteLine(city["UK"]);
            Console.WriteLine(city["Bangladesh"]);
            
            if (city.ContainsKey("USA"))
            {
                Console.WriteLine(city["USA"]);
            }
            
        }
    }
    
    
}
