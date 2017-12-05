using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text) shape;





//            var list = new ArrayList();
//            list.Add(1);
//            list.Add("Rebecca");
//            list.Add(new Text());
//
//            var anotherList = new List<int>();

            // StreamReader read = new StreamReader(new MemoryStream());

//            Text text = new Text();
//            Shape shape = text;
//
//            text.Width = 200;
//            shape.Width = 100;
//
//            Console.WriteLine(text.Width); // 100
        }
    }
}
