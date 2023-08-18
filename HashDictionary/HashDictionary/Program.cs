using HashtableTester;
using System;

namespace HashDictionary
{
    public class Program
    {

        public static void Main()
        {
            IDictionary<int, int> d = new HashDictionary<int, int>();
           TestDriver.Instance.Run(d, 10000);

            var t = new HashDictionary<GeoLocation, int>();
            t.Add(new GeoLocation(1, 2), 1);

            
            Console.WriteLine(t[new GeoLocation(1, 2)]);
        }
    }


}
