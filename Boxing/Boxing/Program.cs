using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // no type safety & boxing
            var list = new ArrayList();
            list.Add(1);
            list.Add("Rebecca");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            // every added element must be an int
            // anotherList.Add(); 
            var names = new List<string>();
            // every added element must be a string
            // names.Add();

        }
    }
}
